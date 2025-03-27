module internal Bolero.BlazorGenerator.BlazorReader

open System
open System.Collections.Concurrent
open System.Reflection
open Microsoft.AspNetCore.Components





let getParameterTypeName: (Type -> string) =
    let mutable i = 0
    let d = ConcurrentDictionary<Type, string>()

    fun x ->
        d.GetOrAdd(
            x,
            fun (l: Type) ->
                i <- i + 1
                $"%s{l.Name}%i{i}"
        )


let rec getType (t: Type) =
    let ti = t.GetTypeInfo()

    if ti.IsGenericType then
        let x =
            TypeDefinition.GenericType(
                name = t.GetGenericTypeDefinition().FullName.Split('`')[0],
                t = t,
                parameters =
                    (Seq.append ti.GenericTypeParameters ti.GenericTypeArguments
                     |> Seq.map getType
                     |> Seq.toList)
            )

        x
    elif t.IsGenericParameter then
        GenericParameter(name = getParameterTypeName t, t = t)
    else
        BasicType(name = t.FullName, t = t)


let private getParameterAttribute (p: PropertyInfo) =
    p.CustomAttributes
    |> Seq.filter (fun d -> d.AttributeType = typeof<ParameterAttribute>)
    |> Seq.tryHead
    |> Option.map (fun d -> d.NamedArguments)


let private readTypeDetails (c: Configuration) (t: Type) =
    let props =
        t.GetProperties()
        |> Seq.filter (fun p -> p.CanWrite)
        |> Seq.map (fun d -> d, getParameterAttribute d)
        |> Seq.filter (fun (_, d) -> d |> Option.isSome)
        |> Seq.map (fun (a, b) -> a, b.Value)
        |> Seq.toList

    let capturesUnmatched =
        props
        |> Seq.exists (fun (_, d) ->
            d
            |> Seq.exists (fun l -> l.MemberName = "CaptureUnmatchedValues" && l.TypedValue.Value = true))


    let p =
        props
        |> Seq.filter (fun (_, d) ->
            d
            |> Seq.exists (fun l -> l.MemberName = "CaptureUnmatchedValues" && l.TypedValue.Value = true)
            |> not)
        |> Seq.map (fun (a, _) -> a)
        |> Seq.map (fun d ->
            let t = getType d.PropertyType

            let propertyType =
                match t with
                | GenericType(n, [ p ], _) when n = typeof<EventCallback>.FullName ->
                    EventParameter(p, $"on%s{d.Name}")
                | GenericType(n, [ p ], _) when n = typeof<RenderFragment>.FullName -> RenderFragmentParameterWith(p)
                | BasicType(n, _) when n = typeof<RenderFragment>.FullName -> RenderFragmentParameter
                | _ -> BasicProperty

            { name = d.Name
              functionName = c.PropertyNameGenerator d
              typeDefinition = t
              propertyType = propertyType })
        |> Seq.toList

    let typeDefinition = getType t

    if not (c.Filter t) then
        None
    else
        Some
            { typeDefinition = typeDefinition
              properties = p |> Seq.toList
              capturesUnmatched = capturesUnmatched
              name = c.ComponentNameGenerator t
              moduleName = c.ModuleNameGenerator t }



let readTypes (c: Configuration) =
    let assembly = c.InputAssembly

    let types =
        assembly.GetTypes()
        |> Seq.filter (fun t -> t.IsAssignableTo(typeof<ComponentBase>) && not t.IsAbstract && t.IsPublic


        )
        |> Seq.choose (readTypeDetails c)


    types |> Seq.toList
