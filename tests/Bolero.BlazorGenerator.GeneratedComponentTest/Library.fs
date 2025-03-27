namespace Bolero.BlazorGenerator.GeneratedComponentUssage

open Bolero
open Bolero.BlazorGenerator.GeneratedComponentTest
open Radzen.Blazor
open Bolero.BlazorGenerator.GeneratedComponentTest.Radzen
open Bolero.Html


type GridItem =
    {
        name:string
        salary:int
    }


type TestModel={
    employees:GridItem[]
}

type TestMessage=
    |TestAction
    |TestStringAction


type TestDatagridRadzenComponent()=
    inherit ElmishComponent<TestModel,TestMessage>()

    override this.View model dispatch =
        radzenDataGrid<GridItem>{
            radzenDataGridAttrs.data<GridItem> model.employees
            radzenDataGridAttrs.columns
                (
                  concat{
                      radzenDataGridColumn<GridItem>{
                          radzenDataGridColumnAttrs.property "name"
                          radzenDataGridColumnAttrs.filterable true
                      }
                      radzenDataGridColumn<GridItem>{
                          radzenDataGridColumnAttrs.property "salary"
                          radzenDataGridColumnAttrs.sortable true
                      }
                  }   
                )    
            
        }


type TestDatagridMudblazorComponent()=
    inherit ElmishComponent<TestModel,TestMessage>()
    
    override this.View model dispatch =
        mudDataGrid<GridItem>{
            mudDataGridAttrs.items<GridItem> model.employees
            mudDataGridAttrs.columns(
                    concat{
                        propertyColumn< GridItem,string>{
                            let extractor = fun (f: GridItem) -> f.name
                            propertyColumnAttrs.property<GridItem, string> extractor
                            propertyColumnAttrs.title "Name"
                        }  
                        propertyColumn< GridItem,int>{
                            let extractor = fun (f: GridItem) -> f.salary
                            propertyColumnAttrs.property<GridItem, int> extractor
                            propertyColumnAttrs.title "Salary"
                        }
                    }                
                )
        }