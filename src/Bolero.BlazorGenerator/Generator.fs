module Bolero.BlazorGenerator.Generator

open System.Reflection
open Fantomas.Core.SyntaxOak
open Fantomas.FCS.Text
open Fantomas.Core


let private removeAttributeSuffice (s: string) =
    if s.EndsWith("Attribute") then s[0 .. s.Length - 10] else s

let private PrepareIdentListFromTypeName (t: string) =
    let nodes =
        t.Split(".")
        |> Seq.map (fun d ->
            [ IdentifierOrDot.UnknownDot
              IdentifierOrDot.Ident(SingleTextNode(d, Range.Zero)) ])
        |> Seq.concat
        |> Seq.skip 1
        |> Seq.toList

    IdentListNode(nodes, Range.Zero)




let rec private getComponentType (c: TypeDefinition) =
    match c with
    | GenericType(n, pars, _) ->
        let p = pars |> List.map (getComponentType)

        Type.AppPrefix(
            TypeAppPrefixNode(
                Type.LongIdent(PrepareIdentListFromTypeName n),
                None,
                SingleTextNode("<", Range.Zero),
                p,
                SingleTextNode(">", Range.Zero),
                Range.Zero
            )
        )
    | BasicType(n, _) -> Type.Anon(SingleTextNode(n, Range.Zero))
    | GenericParameter(n, _) -> Type.Anon(SingleTextNode($"'%s{n}", Range.Zero))


let private prepareTyparDecls (t: TypeDefinition) =
    let rec allParams (ttt: TypeDefinition) =
        match ttt with
        | GenericParameter(_, _) -> [ ttt.Name, ttt ]
        | BasicType _ -> []
        | GenericType(_, p, _) -> p |> Seq.map allParams |> Seq.concat |> Seq.distinct |> Seq.toList


    let getConstraint (ttt: TypeDefinition) =
        match ttt with
        | GenericParameter(n, x) ->
            let typeconstraints =
                x.GetGenericParameterConstraints()
                |> Seq.map BlazorReader.getType
                |> Seq.map getComponentType
                |> Seq.toList

            seq {
                if typeconstraints.Length > 0 then
                    let i = 0
                    ()

                if x.IsValueType then
                    yield
                        TypeConstraint.Single(
                            TypeConstraintSingleNode(
                                SingleTextNode($"'%s{n}", Range.Zero),
                                SingleTextNode("struct", Range.Zero),
                                Range.Zero
                            )
                        )

                if
                    (x.GenericParameterAttributes
                     &&& GenericParameterAttributes.DefaultConstructorConstraint) = GenericParameterAttributes.DefaultConstructorConstraint
                then
                    yield
                        TypeConstraint.SupportsMember(
                            SyntaxOak.TypeConstraintSupportsMemberNode(
                                getComponentType ttt,
                                MemberDefn.SigMember(
                                    MemberDefnSigMemberNode(
                                        ValNode(
                                            None,
                                            None,
                                            None,
                                            None,
                                            false,
                                            None,
                                            SingleTextNode("new", Range.Zero),
                                            None,
                                            Type.Funs(
                                                TypeFunsNode(
                                                    [ Type.Anon(SingleTextNode("unit", Range.Zero)),
                                                      SingleTextNode("->", Range.Zero)

                                                      ],
                                                    Type.Anon(SingleTextNode($"'%s{n}", Range.Zero)),
                                                    Range.Zero
                                                )
                                            ),
                                            None,
                                            None,
                                            Range.Zero
                                        ),
                                        None,
                                        Range.Zero
                                    )
                                ),
                                Range.Zero
                            )
                        )


                for item in typeconstraints do
                    yield
                        TypeConstraint.SubtypeOfType(
                            TypeConstraintSubtypeOfTypeNode(
                                SingleTextNode($"'%s{ttt.Name}", Range.Zero),
                                item,
                                Range.Zero
                            )
                        )

            }
        | _ -> Seq.empty

    match t with
    | GenericType _ ->
        let op = allParams t
        let c = op |> List.map (snd >> getConstraint) |> Seq.concat |> Seq.toList

        let parTypes =
            op
            |> List.map (fun (x, _) ->
                TyparDeclNode(None, SingleTextNode($"'%s{x}", Range.Zero), List.empty, Range.Zero))

        if (parTypes.Length > 0) then
            TyparDecls.PostfixList(
                TyparDeclsPostfixListNode(
                    SingleTextNode("<", Range.Zero),
                    parTypes,
                    c,
                    SingleTextNode(">", Range.Zero),
                    Range.Zero
                )
            )
            |> Some
        else
            None
    | _ -> None








let private preparecomponentBindNode (c: ComponentDescription) =

    let exp =
        Expr.TypeApp(
            ExprTypeAppNode(
                Expr.Ident(SingleTextNode("comp", Range.Zero)),
                SingleTextNode("<", Range.Zero),
                [ getComponentType c.typeDefinition ],
                SingleTextNode(">", Range.Zero),
                Range.Zero
            )
        )

    BindingNode(
        None,
        None,
        MultipleTextsNode([ SingleTextNode("let", Range.Zero) ], Range.Zero),
        false,
        None,
        None,
        Choice1Of2(IdentListNode([ IdentifierOrDot.Ident(SingleTextNode(c.name, Range.Zero)) ], Range.Zero)),
        prepareTyparDecls c.typeDefinition,
        [],
        None,
        SingleTextNode("=", Range.Zero),
        exp,
        Range.Zero
    )
    |> ModuleDecl.TopLevelBinding


let private words =
    Set["open"
        "type"
        "inline"
        "end"
        "match"
        "component"
        "to"
        "class"
        "lazy"
        "for"
        "default"
        "fixed"
        "checked"]

let escapeParam p =
    if words |> Set.contains p then $"``%s{p}``" else p

let private getPropertyFunctionName (prop: PropertyDescription) =
    match prop.propertyType with
    | EventParameter(_, n) ->
        Choice1Of2(IdentListNode([ IdentifierOrDot.Ident(SingleTextNode(n |> escapeParam, Range.Zero)) ], Range.Zero))
    | _ ->
        Choice1Of2(
            IdentListNode(
                [ IdentifierOrDot.Ident(SingleTextNode(prop.functionName |> escapeParam, Range.Zero)) ],
                Range.Zero
            )
        )




let private getPropertyParameters (prop: PropertyDescription) =
    match prop.propertyType with
    | BasicProperty ->
        [ Pattern.Paren(
              PatParenNode(
                  SingleTextNode("(", Range.Zero),
                  Pattern.Parameter(
                      PatParameterNode(
                          None,
                          Pattern.Named(PatNamedNode(None, SingleTextNode("p", Range.Zero), Range.Zero)),
                          getComponentType prop.typeDefinition |> Some,
                          Range.Zero
                      )
                  ),
                  SingleTextNode(")", Range.Zero),
                  Range.Zero
              )
          ) ]
    | RenderFragmentParameter -> [ Pattern.Named(PatNamedNode(None, SingleTextNode("p", Range.Zero), Range.Zero)) ]
    | EventParameter _ ->
        let paramAttributes =
            MultipleAttributeListNode(
                [ AttributeListNode(
                      SingleTextNode("[<", Range.Zero),
                      [ AttributeNode(
                            PrepareIdentListFromTypeName(
                                typeof<InlineIfLambdaAttribute>.FullName |> removeAttributeSuffice
                            ),
                            None,
                            None,
                            Range.Zero
                        ) ],
                      SingleTextNode(">]", Range.Zero),
                      Range.Zero
                  ) ],
                Range.Zero
            )

        [ Pattern.Paren(
              PatParenNode(
                  SingleTextNode("(", Range.Zero),
                  Pattern.Parameter(
                      PatParameterNode(
                          Some paramAttributes,
                          Pattern.Named(PatNamedNode(None, SingleTextNode("p", Range.Zero), Range.Zero)),
                          None,
                          Range.Zero
                      )
                  ),
                  SingleTextNode(")", Range.Zero),
                  Range.Zero
              )
          ) ]
    | RenderFragmentParameterWith t ->
        let paramAttributes =
            MultipleAttributeListNode(
                [ AttributeListNode(
                      SingleTextNode("[<", Range.Zero),
                      [ AttributeNode(
                            PrepareIdentListFromTypeName(
                                typeof<InlineIfLambdaAttribute>.FullName |> removeAttributeSuffice
                            ),
                            None,
                            None,
                            Range.Zero
                        ) ],
                      SingleTextNode(">]", Range.Zero),
                      Range.Zero
                  ) ],
                Range.Zero
            )

        [ Pattern.Paren(
              PatParenNode(
                  SingleTextNode("(", Range.Zero),
                  Pattern.Parameter(
                      PatParameterNode(
                          Some paramAttributes,
                          Pattern.Named(PatNamedNode(None, SingleTextNode("p", Range.Zero), Range.Zero)),
                          Type.Funs(
                              TypeFunsNode(
                                  [ getComponentType t, SingleTextNode("->", Range.Zero) ],
                                  Type.LongIdent(PrepareIdentListFromTypeName "Bolero.Node"),
                                  Range.Zero
                              )
                          )
                          |> Some,
                          Range.Zero
                      )
                  ),
                  SingleTextNode(")", Range.Zero),
                  Range.Zero
              )
          ) ]

let private getPropertyExpression (_: ComponentDescription) (prop: PropertyDescription) =
    match prop.propertyType with
    | BasicProperty ->
        Expr.InfixApp(
            ExprInfixAppNode(
                Expr.Constant(Constant.FromText(SingleTextNode($"\"%s{prop.name}\"", Range.Zero))),
                SingleTextNode("=>", Range.Zero),
                Expr.Ident(SingleTextNode("p", Range.Zero)),
                Range.Zero
            )
        )
    | EventParameter(t, _) ->
        Expr.App(
            ExprAppNode(
                Expr.TypeApp(
                    ExprTypeAppNode(
                        Expr.OptVar(ExprOptVarNode(false, PrepareIdentListFromTypeName "attr.callback", Range.Zero)),
                        SingleTextNode("<", Range.Zero),
                        [ getComponentType t ],
                        SingleTextNode(">", Range.Zero),
                        Range.Zero

                    )
                ),
                [ Expr.Constant(Constant.FromText(SingleTextNode($"\"%s{prop.name}\"", Range.Zero)))
                  Expr.Ident(SingleTextNode("p", Range.Zero)) ],
                Range.Zero
            )
        )
    | RenderFragmentParameter ->
        Expr.App(
            ExprAppNode(
                Expr.OptVar(ExprOptVarNode(false, PrepareIdentListFromTypeName "attr.fragment", Range.Zero)),
                [ Expr.Constant(Constant.FromText(SingleTextNode($"\"%s{prop.name}\"", Range.Zero)))
                  Expr.Ident(SingleTextNode("p", Range.Zero)) ],
                Range.Zero
            )
        )
    | RenderFragmentParameterWith _ ->
        Expr.App(
            ExprAppNode(
                Expr.OptVar(ExprOptVarNode(false, PrepareIdentListFromTypeName "attr.fragmentWith", Range.Zero)),
                [ Expr.Constant(Constant.FromText(SingleTextNode($"\"%s{prop.name}\"", Range.Zero)))
                  Expr.Ident(SingleTextNode("p", Range.Zero)) ],
                Range.Zero
            )
        )




let private prepareComponentProperties (c: ComponentDescription) =
    seq {
        for prop in c.properties do
            yield
                BindingNode(
                    None,
                    None,
                    MultipleTextsNode([ SingleTextNode("let", Range.Zero) ], Range.Zero),
                    false,
                    SingleTextNode("inline", Range.Zero) |> Some,
                    None,
                    getPropertyFunctionName prop,
                    prepareTyparDecls prop.typeDefinition,
                    getPropertyParameters prop,
                    None,
                    SingleTextNode("=", Range.Zero),
                    getPropertyExpression c prop,
                    Range.Zero
                )
                |> ModuleDecl.TopLevelBinding
    }

let private preparecomponentComponentModule (c: ComponentDescription) =
    ModuleDecl.NestedModule(
        NestedModuleNode(
            None,
            None,
            SingleTextNode("module", Range.Zero),
            None,
            false,
            PrepareIdentListFromTypeName c.moduleName,
            SingleTextNode("=", Range.Zero),
            prepareComponentProperties c |> Seq.toList,
            Range.Zero
        )
    )

let private prepareBaseModule (c: Configuration) (comp: ComponentDescription list) =
    let baseModuleAttributes =
        MultipleAttributeListNode(
            [ AttributeListNode(
                  SingleTextNode("[<", Range.Zero),
                  [ AttributeNode(
                        PrepareIdentListFromTypeName(typeof<AutoOpenAttribute>.FullName |> removeAttributeSuffice),
                        None,
                        None,
                        Range.Zero
                    ) ],
                  SingleTextNode(">]", Range.Zero),
                  Range.Zero
              ) ],
            Range.Zero
        )

    let header =
        ModuleOrNamespaceHeaderNode(
            None,
            Some baseModuleAttributes,
            MultipleTextsNode([ SingleTextNode("module", Range.Zero) ], Range.Zero),
            None,
            false,
            Some(PrepareIdentListFromTypeName c.BaseModuleName),
            Range.Zero
        )

    let o =
        ModuleDecl.OpenList(
            OpenListNode
                [ Open.ModuleOrNamespace(
                      OpenModuleOrNamespaceNode(PrepareIdentListFromTypeName "Bolero.Html", Range.Zero)
                  ) ]
        )

    let statements =
        seq {
            yield o

            for c in comp do
                yield preparecomponentBindNode c

                if c.properties.Length > 0 then
                    yield preparecomponentComponentModule c
        }

    Oak([], [ ModuleOrNamespaceNode(Some header, statements |> Seq.toList, Range.Zero) ], Range.Zero)


let generate (c: Configuration) =
    let types = BlazorReader.readTypes c
    let l = prepareBaseModule c types
    CodeFormatter.FormatOakAsync(l, FormatConfig.Default) |> Async.RunSynchronously



let generateToFile (c: Configuration) (file: string) =
    let res = generate c
    System.IO.File.WriteAllText(file, res)
