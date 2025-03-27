namespace Bolero.BlazorGenerator

open System
open System.Reflection



module Namings =
    let firstToLower (typeName: string) =
        $"%s{typeName[0..0].ToLower()}%s{typeName[1..]}"

    let firstToUpper (typeName: string) =
        $"%s{typeName[0..0].ToUpper()}%s{typeName[1..]}"

    let append (postfix: string) (s: string) = $"%s{s}%s{postfix}"

    let simpleTypeName (t: Type) =
        if t.IsGenericType then t.Name.Split('`')[0] else t.Name

    let propertyNameExtractor (p: PropertyInfo) = p.Name



type Configuration
    (
        inputAssembly: Assembly,
        baseModuleName: string,
        ?filter: Type -> bool,
        ?componentNameGenerator: Type -> string,
        ?moduleNameGenerator: Type -> string,
        ?propertyNameGenerator: PropertyInfo -> string
    ) =


    member this.InputAssembly = inputAssembly
    member this.BaseModuleName = baseModuleName
    member this.Filter = filter |> Option.defaultValue (fun x -> true)

    member this.ComponentNameGenerator =
        componentNameGenerator
        |> Option.defaultValue (Namings.simpleTypeName >> Namings.firstToLower)

    member this.ModuleNameGenerator =
        moduleNameGenerator
        |> Option.defaultValue (Namings.simpleTypeName >> Namings.firstToUpper)

    member this.PropertyNameGenerator =
        propertyNameGenerator
        |> Option.defaultValue (Namings.propertyNameExtractor >> Namings.firstToLower)
