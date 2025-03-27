namespace Bolero.BlazorGenerator

open System

type internal TypeDefinition =
    | BasicType of name: string * t: Type
    | GenericType of name: string * parameters: TypeDefinition list * t: Type
    | GenericParameter of name: string * t: Type

    member this.Name =
        match this with
        | BasicType(n, _)
        | GenericType(n, _, _)
        | GenericParameter(n, _) -> n


type internal PropertyType =
    | BasicProperty
    | EventParameter of eventType: TypeDefinition * eventName: string
    | RenderFragmentParameter
    | RenderFragmentParameterWith of parametrType: TypeDefinition

type internal PropertyDescription =
    { name: string
      functionName: string
      typeDefinition: TypeDefinition
      propertyType: PropertyType

    }

type internal ComponentDescription =
    { typeDefinition: TypeDefinition
      properties: PropertyDescription list
      capturesUnmatched: bool
      moduleName: string
      name: string }
