open Bolero.BlazorGenerator
open System.IO

let confMudblazor =
    Configuration(
        (typeof<MudBlazor.MudButton>).Assembly,
        "Bolero.BlazorGenerator.GeneratedComponentTest.Mudblazor",
        moduleNameGenerator = (Namings.simpleTypeName >> Namings.firstToLower >> Namings.append "Attrs")
    )



let outputFileMudblazor =
    Path.Combine
        [| __SOURCE_DIRECTORY__
           ".."
           "Bolero.BlazorGenerator.GeneratedComponentTest"
           "Mudblazor.fs" |]

Generator.generateToFile confMudblazor outputFileMudblazor

let confRadzen =
    Configuration(
        (typeof<Radzen.Blazor.RadzenButton>).Assembly,
        "Bolero.BlazorGenerator.GeneratedComponentTest.Radzen",
        moduleNameGenerator = (Namings.simpleTypeName >> Namings.firstToLower >> Namings.append "Attrs")
    )



let outputFileRadzen =
    Path.Combine
        [| __SOURCE_DIRECTORY__
           ".."
           "Bolero.BlazorGenerator.GeneratedComponentTest"
           "Radzen.fs" |]

Generator.generateToFile confRadzen outputFileRadzen

