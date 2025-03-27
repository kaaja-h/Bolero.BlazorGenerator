[<Microsoft.FSharp.Core.AutoOpen>]
module Bolero.BlazorGenerator.GeneratedComponentTest.Radzen

open Bolero.Html
let radzenComponentWithChildren = comp<Radzen.RadzenComponentWithChildren>

module radzenComponentWithChildrenAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenFlexComponent = comp<Radzen.RadzenFlexComponent>

module radzenFlexComponentAttrs =
    let inline justifyContent (p: Radzen.JustifyContent) = "JustifyContent" => p
    let inline alignItems (p: Radzen.AlignItems) = "AlignItems" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let dataBoundFormComponent<'T42> = comp<Radzen.DataBoundFormComponent<'T42>>

module dataBoundFormComponentAttrs =
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterOperator (p: Radzen.StringFilterOperator) = "FilterOperator" => p
    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Object> "Change" p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline value (p: System.Object) = "Value" => p
    let inline onValueChanged<'T42> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T42> "ValueChanged" p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline searchText (p: System.String) = "SearchText" => p

    let inline onSearchTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "SearchTextChanged" p

    let inline valueExpression<'T42> (p: System.Linq.Expressions.Expression<System.Func<'T42>>) = "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let dropDownBase<'T43> = comp<Radzen.DropDownBase<'T43>>

module dropDownBaseAttrs =
    let inline virtualizationOverscanCount (p: System.Int32) = "VirtualizationOverscanCount" => p
    let inline count (p: System.Int32) = "Count" => p
    let inline allowVirtualization (p: System.Boolean) = "AllowVirtualization" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline allowFiltering (p: System.Boolean) = "AllowFiltering" => p
    let inline filterAsYouType (p: System.Boolean) = "FilterAsYouType" => p
    let inline allowClear (p: System.Boolean) = "AllowClear" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline allowSelectAll (p: System.Boolean) = "AllowSelectAll" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p
    let inline removeChipTitle (p: System.String) = "RemoveChipTitle" => p
    let inline searchAriaLabel (p: System.String) = "SearchAriaLabel" => p
    let inline emptyAriaLabel (p: System.String) = "EmptyAriaLabel" => p

    let inline onSelectedItemChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "SelectedItemChanged" p

    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline filterDelay (p: System.Int32) = "FilterDelay" => p
    let inline selectedItem (p: System.Object) = "SelectedItem" => p
    let inline separator (p: System.String) = "Separator" => p
    let inline itemComparer (p: System.Collections.Generic.IEqualityComparer<System.Object>) = "ItemComparer" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterOperator (p: Radzen.StringFilterOperator) = "FilterOperator" => p
    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Object> "Change" p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline value (p: System.Object) = "Value" => p
    let inline onValueChanged<'T43> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T43> "ValueChanged" p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline searchText (p: System.String) = "SearchText" => p

    let inline onSearchTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "SearchTextChanged" p

    let inline valueExpression<'T43> (p: System.Linq.Expressions.Expression<System.Func<'T43>>) = "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let formComponentWithAutoComplete<'T44> =
    comp<Radzen.FormComponentWithAutoComplete<'T44>>

module formComponentWithAutoCompleteAttrs =
    let inline autoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "AutoCompleteType" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onValueChanged<'T44> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T44> "ValueChanged" p
    let inline value (p: 'T44) = "Value" => p
    let inline onChange<'T44> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T44> "Change" p
    let inline valueExpression<'T44> (p: System.Linq.Expressions.Expression<System.Func<'T44>>) = "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let formComponent<'T45> = comp<Radzen.FormComponent<'T45>>

module formComponentAttrs =
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onValueChanged<'T45> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T45> "ValueChanged" p
    let inline value (p: 'T45) = "Value" => p
    let inline onChange<'T45> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T45> "Change" p
    let inline valueExpression<'T45> (p: System.Linq.Expressions.Expression<System.Func<'T45>>) = "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let pagedDataBoundComponent<'T46> = comp<Radzen.PagedDataBoundComponent<'T46>>

module pagedDataBoundComponentAttrs =
    let inline pagerPosition (p: Radzen.PagerPosition) = "PagerPosition" => p
    let inline pagerAlwaysVisible (p: System.Boolean) = "PagerAlwaysVisible" => p
    let inline pagerHorizontalAlign (p: Radzen.HorizontalAlign) = "PagerHorizontalAlign" => p
    let inline density (p: Radzen.Density) = "Density" => p
    let inline allowPaging (p: System.Boolean) = "AllowPaging" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline pageNumbersCount (p: System.Int32) = "PageNumbersCount" => p
    let inline count (p: System.Int32) = "Count" => p

    let inline template<'T46> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T46 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline loadingTemplate p = attr.fragment "LoadingTemplate" p
    let inline data<'T46> (p: System.Collections.Generic.IEnumerable<'T46>) = "Data" => p
    let inline pageSizeOptions (p: System.Collections.Generic.IEnumerable<System.Int32>) = "PageSizeOptions" => p
    let inline pageSizeText (p: System.String) = "PageSizeText" => p
    let inline showPagingSummary (p: System.Boolean) = "ShowPagingSummary" => p
    let inline pagingSummaryFormat (p: System.String) = "PagingSummaryFormat" => p
    let inline firstPageTitle (p: System.String) = "FirstPageTitle" => p
    let inline firstPageAriaLabel (p: System.String) = "FirstPageAriaLabel" => p
    let inline prevPageLabel (p: System.String) = "PrevPageLabel" => p
    let inline prevPageTitle (p: System.String) = "PrevPageTitle" => p
    let inline prevPageAriaLabel (p: System.String) = "PrevPageAriaLabel" => p
    let inline lastPageTitle (p: System.String) = "LastPageTitle" => p
    let inline lastPageAriaLabel (p: System.String) = "LastPageAriaLabel" => p
    let inline nextPageLabel (p: System.String) = "NextPageLabel" => p
    let inline nextPageTitle (p: System.String) = "NextPageTitle" => p
    let inline nextPageAriaLabel (p: System.String) = "NextPageAriaLabel" => p
    let inline pageTitleFormat (p: System.String) = "PageTitleFormat" => p
    let inline pageAriaLabelFormat (p: System.String) = "PageAriaLabelFormat" => p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline onPage ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.PagerEventArgs> "Page" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenComponent = comp<Radzen.RadzenComponent>

module radzenComponentAttrs =
    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenAccordion = comp<Radzen.Blazor.RadzenAccordion>

module radzenAccordionAttrs =
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline onExpand ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Int32> "Expand" p

    let inline onCollapse ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "Collapse" p

    let inline items p = attr.fragment "Items" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenAccordionItem = comp<Radzen.Blazor.RadzenAccordionItem>

module radzenAccordionItemAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline selected (p: System.Boolean) = "Selected" => p

    let inline onSelectedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "SelectedChanged" p

    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline expandTitle (p: System.String) = "ExpandTitle" => p
    let inline collapseTitle (p: System.String) = "CollapseTitle" => p
    let inline expandAriaLabel (p: System.String) = "ExpandAriaLabel" => p
    let inline collapseAriaLabel (p: System.String) = "CollapseAriaLabel" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline template p = attr.fragment "Template" p
    let inline visible (p: System.Boolean) = "Visible" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p

let radzenAlert = comp<Radzen.Blazor.RadzenAlert>

module radzenAlertAttrs =
    let inline allowClose (p: System.Boolean) = "AllowClose" => p
    let inline showIcon (p: System.Boolean) = "ShowIcon" => p
    let inline title (p: System.String) = "Title" => p
    let inline text (p: System.String) = "Text" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline alertStyle (p: Radzen.AlertStyle) = "AlertStyle" => p
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline shade (p: Radzen.Shade) = "Shade" => p
    let inline size (p: Radzen.AlertSize) = "Size" => p

    let inline onVisibleChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "VisibleChanged" p

    let inline close (p: Microsoft.AspNetCore.Components.EventCallback) = "Close" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenAppearanceToggle = comp<Radzen.Blazor.RadzenAppearanceToggle>

module radzenAppearanceToggleAttrs =
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline toggleShade (p: Radzen.Shade) = "ToggleShade" => p
    let inline toggleButtonStyle (p: Radzen.ButtonStyle) = "ToggleButtonStyle" => p
    let inline lightTheme (p: System.String) = "LightTheme" => p
    let inline darkTheme (p: System.String) = "DarkTheme" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenArcGaugeScale = comp<Radzen.Blazor.RadzenArcGaugeScale>

module radzenArcGaugeScaleAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline tickLength (p: System.Double) = "TickLength" => p
    let inline minorTickLength (p: System.Double) = "MinorTickLength" => p
    let inline tickLabelOffset (p: System.Double) = "TickLabelOffset" => p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline height (p: System.Double) = "Height" => p
    let inline formatter (p: System.Func<System.Double, System.String>) = "Formatter" => p
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline tickPosition (p: Radzen.Blazor.GaugeTickPosition) = "TickPosition" => p
    let inline endAngle (p: System.Double) = "EndAngle" => p
    let inline radius (p: System.Double) = "Radius" => p
    let inline showFirstTick (p: System.Boolean) = "ShowFirstTick" => p
    let inline showLastTick (p: System.Boolean) = "ShowLastTick" => p
    let inline showTickLabels (p: System.Boolean) = "ShowTickLabels" => p
    let inline x (p: System.Double) = "X" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline step (p: System.Double) = "Step" => p
    let inline minorStep (p: System.Double) = "MinorStep" => p
    let inline y (p: System.Double) = "Y" => p
    let inline margin (p: System.Double) = "Margin" => p

let radzenArcGaugeScaleValue = comp<Radzen.Blazor.RadzenArcGaugeScaleValue>

module radzenArcGaugeScaleValueAttrs =
    let inline value (p: System.Double) = "Value" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline showValue (p: System.Boolean) = "ShowValue" => p
    let inline formatString (p: System.String) = "FormatString" => p

    let inline template
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenArcGaugeScaleValue -> Bolero.Node)
        =
        attr.fragmentWith "Template" p

let radzenAreaSeries<'TItem47> = comp<Radzen.Blazor.RadzenAreaSeries<'TItem47>>

module radzenAreaSeriesAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline smooth (p: System.Boolean) = "Smooth" => p
    let inline interpolation (p: Radzen.Blazor.Interpolation) = "Interpolation" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem47> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem47 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem47> (p: System.Collections.Generic.IEnumerable<'TItem47>) = "Data" => p

let radzenAutoComplete = comp<Radzen.Blazor.RadzenAutoComplete>

module radzenAutoCompleteAttrs =
    let inline selectedItem (p: System.Object) = "SelectedItem" => p

    let inline onSelectedItemChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "SelectedItemChanged" p

    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline multiline (p: System.Boolean) = "Multiline" => p
    let inline openOnFocus (p: System.Boolean) = "OpenOnFocus" => p
    let inline popupStyle (p: System.String) = "PopupStyle" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline minLength (p: System.Int32) = "MinLength" => p
    let inline filterDelay (p: System.Int32) = "FilterDelay" => p
    let inline inputType (p: System.String) = "InputType" => p
    let inline maxLength (p: System.Nullable<System.Int64>) = "MaxLength" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterOperator (p: Radzen.StringFilterOperator) = "FilterOperator" => p
    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Object> "Change" p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline value (p: System.Object) = "Value" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline searchText (p: System.String) = "SearchText" => p

    let inline onSearchTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "SearchTextChanged" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenAxisTitle = comp<Radzen.Blazor.RadzenAxisTitle>

module radzenAxisTitleAttrs =
    let inline text (p: System.String) = "Text" => p

let radzenBadge = comp<Radzen.Blazor.RadzenBadge>

module radzenBadgeAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline text (p: System.String) = "Text" => p
    let inline badgeStyle (p: Radzen.BadgeStyle) = "BadgeStyle" => p
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline shade (p: Radzen.Shade) = "Shade" => p
    let inline isPill (p: System.Boolean) = "IsPill" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenBarOptions = comp<Radzen.Blazor.RadzenBarOptions>

module radzenBarOptionsAttrs =
    let inline radius (p: System.Double) = "Radius" => p
    let inline margin (p: System.Double) = "Margin" => p
    let inline height (p: System.Nullable<System.Double>) = "Height" => p

let radzenBarSeries<'TItem48> = comp<Radzen.Blazor.RadzenBarSeries<'TItem48>>

module radzenBarSeriesAttrs =
    let inline fill (p: System.String) = "Fill" => p
    let inline fills (p: System.Collections.Generic.IEnumerable<System.String>) = "Fills" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokes (p: System.Collections.Generic.IEnumerable<System.String>) = "Strokes" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline fillRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "FillRange" => p
    let inline strokeRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "StrokeRange" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem48> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem48 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem48> (p: System.Collections.Generic.IEnumerable<'TItem48>) = "Data" => p

let radzenBody = comp<Radzen.Blazor.RadzenBody>

module radzenBodyAttrs =
    let inline style (p: System.String) = "Style" => p
    let inline expanded (p: System.Boolean) = "Expanded" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenBreadCrumb = comp<Radzen.Blazor.RadzenBreadCrumb>

module radzenBreadCrumbAttrs =
    let inline template
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenBreadCrumbItem -> Bolero.Node)
        =
        attr.fragmentWith "Template" p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenBreadCrumbItem = comp<Radzen.Blazor.RadzenBreadCrumbItem>

module radzenBreadCrumbItemAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline path (p: System.String) = "Path" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenButton = comp<Radzen.Blazor.RadzenButton>

module radzenButtonAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline text (p: System.String) = "Text" => p
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline buttonType (p: Radzen.ButtonType) = "ButtonType" => p
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline shade (p: Radzen.Shade) = "Shade" => p
    let inline size (p: Radzen.ButtonSize) = "Size" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "Click" p

    let inline isBusy (p: System.Boolean) = "IsBusy" => p
    let inline busyText (p: System.String) = "BusyText" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCard = comp<Radzen.Blazor.RadzenCard>

module radzenCardAttrs =
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCardGroup = comp<Radzen.Blazor.RadzenCardGroup>

module radzenCardGroupAttrs =
    let inline responsive (p: System.Boolean) = "Responsive" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCarousel = comp<Radzen.Blazor.RadzenCarousel>

module radzenCarouselAttrs =
    let inline items p = attr.fragment "Items" p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Int32> "Change" p
    let inline auto (p: System.Boolean) = "Auto" => p
    let inline interval (p: System.Double) = "Interval" => p
    let inline pagerPosition (p: Radzen.PagerPosition) = "PagerPosition" => p
    let inline pagerOverlay (p: System.Boolean) = "PagerOverlay" => p
    let inline allowPaging (p: System.Boolean) = "AllowPaging" => p
    let inline allowNavigation (p: System.Boolean) = "AllowNavigation" => p
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline buttonVariant (p: Radzen.Variant) = "ButtonVariant" => p
    let inline buttonShade (p: Radzen.Shade) = "ButtonShade" => p
    let inline buttonSize (p: Radzen.ButtonSize) = "ButtonSize" => p
    let inline nextText (p: System.String) = "NextText" => p
    let inline prevText (p: System.String) = "PrevText" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline prevIcon (p: System.String) = "PrevIcon" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCarouselItem = comp<Radzen.Blazor.RadzenCarouselItem>

module radzenCarouselItemAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

let radzenChart = comp<Radzen.Blazor.RadzenChart>

module radzenChartAttrs =
    let inline colorScheme (p: Radzen.Blazor.ColorScheme) = "ColorScheme" => p

    let inline onSeriesClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SeriesClickEventArgs> "SeriesClick" p

    let inline onLegendClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LegendClickEventArgs> "LegendClick" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline clickTolerance (p: System.Int32) = "ClickTolerance" => p
    let inline tooltipTolerance (p: System.Int32) = "TooltipTolerance" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenChartTooltipOptions = comp<Radzen.Blazor.RadzenChartTooltipOptions>

module radzenChartTooltipOptionsAttrs =
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline style (p: System.String) = "Style" => p
    let inline shared (p: System.Boolean) = "Shared" => p

let radzenCheckBox<'TValue49> = comp<Radzen.Blazor.RadzenCheckBox<'TValue49>>

module radzenCheckBoxAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline triState (p: System.Boolean) = "TriState" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue49> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue49> "ValueChanged" p

    let inline value (p: 'TValue49) = "Value" => p
    let inline onChange<'TValue49> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TValue49> "Change" p

    let inline valueExpression<'TValue49> (p: System.Linq.Expressions.Expression<System.Func<'TValue49>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCheckBoxList<'TValue50> =
    comp<Radzen.Blazor.RadzenCheckBoxList<'TValue50>>

module radzenCheckBoxListAttrs =
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p
    let inline readOnlyProperty (p: System.String) = "ReadOnlyProperty" => p
    let inline allowSelectAll (p: System.Boolean) = "AllowSelectAll" => p
    let inline selectAllText (p: System.String) = "SelectAllText" => p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline items p = attr.fragment "Items" p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue50> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<'TValue50>> "ValueChanged" p

    let inline value<'TValue50> (p: System.Collections.Generic.IEnumerable<'TValue50>) = "Value" => p

    let inline onChange<'TValue50> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<'TValue50>> "Change" p

    let inline valueExpression<'TValue50>
        (p: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue50>>>)
        =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCheckBoxListItem<'TValue51> =
    comp<Radzen.Blazor.RadzenCheckBoxListItem<'TValue51>>

module radzenCheckBoxListItemAttrs =
    let inline text (p: System.String) = "Text" => p

    let inline template<'TValue51>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenCheckBoxListItem<'TValue51> -> Bolero.Node)
        =
        attr.fragmentWith "Template" p

    let inline value (p: 'TValue51) = "Value" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenColorPicker = comp<Radzen.Blazor.RadzenColorPicker>

module radzenColorPickerAttrs =
    let inline toggleAriaLabel (p: System.String) = "ToggleAriaLabel" => p
    let inline ``open`` (p: Microsoft.AspNetCore.Components.EventCallback) = "Open" => p
    let inline close (p: Microsoft.AspNetCore.Components.EventCallback) = "Close" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline hexText (p: System.String) = "HexText" => p
    let inline redText (p: System.String) = "RedText" => p
    let inline greenText (p: System.String) = "GreenText" => p
    let inline blueText (p: System.String) = "BlueText" => p
    let inline alphaText (p: System.String) = "AlphaText" => p
    let inline buttonText (p: System.String) = "ButtonText" => p
    let inline showButton (p: System.Boolean) = "ShowButton" => p
    let inline showHSV (p: System.Boolean) = "ShowHSV" => p
    let inline showRGBA (p: System.Boolean) = "ShowRGBA" => p
    let inline showColors (p: System.Boolean) = "ShowColors" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline popupRenderMode (p: Radzen.PopupRenderMode) = "PopupRenderMode" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenColorPickerItem = comp<Radzen.Blazor.RadzenColorPickerItem>

module radzenColorPickerItemAttrs =
    let inline value (p: System.String) = "Value" => p

let radzenColumn = comp<Radzen.Blazor.RadzenColumn>

module radzenColumnAttrs =
    let inline size (p: System.Nullable<System.Int32>) = "Size" => p
    let inline sizeXS (p: System.Nullable<System.Int32>) = "SizeXS" => p
    let inline sizeSM (p: System.Nullable<System.Int32>) = "SizeSM" => p
    let inline sizeMD (p: System.Nullable<System.Int32>) = "SizeMD" => p
    let inline sizeLG (p: System.Nullable<System.Int32>) = "SizeLG" => p
    let inline sizeXL (p: System.Nullable<System.Int32>) = "SizeXL" => p
    let inline sizeXX (p: System.Nullable<System.Int32>) = "SizeXX" => p
    let inline offset (p: System.Nullable<System.Int32>) = "Offset" => p
    let inline offsetXS (p: System.Nullable<System.Int32>) = "OffsetXS" => p
    let inline offsetSM (p: System.Nullable<System.Int32>) = "OffsetSM" => p
    let inline offsetMD (p: System.Nullable<System.Int32>) = "OffsetMD" => p
    let inline offsetLG (p: System.Nullable<System.Int32>) = "OffsetLG" => p
    let inline offsetXL (p: System.Nullable<System.Int32>) = "OffsetXL" => p
    let inline offsetXX (p: System.Nullable<System.Int32>) = "OffsetXX" => p
    let inline order (p: System.String) = "Order" => p
    let inline orderXS (p: System.String) = "OrderXS" => p
    let inline orderSM (p: System.String) = "OrderSM" => p
    let inline orderMD (p: System.String) = "OrderMD" => p
    let inline orderLG (p: System.String) = "OrderLG" => p
    let inline orderXL (p: System.String) = "OrderXL" => p
    let inline orderXX (p: System.String) = "OrderXX" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenColumnOptions = comp<Radzen.Blazor.RadzenColumnOptions>

module radzenColumnOptionsAttrs =
    let inline radius (p: System.Double) = "Radius" => p
    let inline margin (p: System.Double) = "Margin" => p
    let inline width (p: System.Nullable<System.Double>) = "Width" => p

let radzenColumnSeries<'TItem52> = comp<Radzen.Blazor.RadzenColumnSeries<'TItem52>>

module radzenColumnSeriesAttrs =
    let inline fill (p: System.String) = "Fill" => p
    let inline fills (p: System.Collections.Generic.IEnumerable<System.String>) = "Fills" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokes (p: System.Collections.Generic.IEnumerable<System.String>) = "Strokes" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline fillRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "FillRange" => p
    let inline strokeRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "StrokeRange" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem52> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem52 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem52> (p: System.Collections.Generic.IEnumerable<'TItem52>) = "Data" => p

let radzenCompareValidator = comp<Radzen.Blazor.RadzenCompareValidator>

module radzenCompareValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.Object) = "Value" => p
    let inline operator (p: Radzen.Blazor.CompareOperator) = "Operator" => p
    let inline validateOnComponentValueChange (p: System.Boolean) = "ValidateOnComponentValueChange" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenContent = comp<Radzen.Blazor.RadzenContent>

module radzenContentAttrs =
    let inline container (p: System.String) = "Container" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenContentContainer = comp<Radzen.Blazor.RadzenContentContainer>

module radzenContentContainerAttrs =
    let inline name (p: System.String) = "Name" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenContextMenu = comp<Radzen.Blazor.RadzenContextMenu>
let radzenCustomValidator = comp<Radzen.Blazor.RadzenCustomValidator>

module radzenCustomValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline validator (p: System.Func<System.Boolean>) = "Validator" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDataAnnotationValidator =
    comp<Radzen.Blazor.RadzenDataAnnotationValidator>

module radzenDataAnnotationValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline messageSeparator (p: System.String) = "MessageSeparator" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDataFilter<'TItem53> = comp<Radzen.Blazor.RadzenDataFilter<'TItem53>>

module radzenDataFilterAttrs =
    let inline properties p = attr.fragment "Properties" p
    let inline data<'TItem53> (p: System.Collections.Generic.IEnumerable<'TItem53>) = "Data" => p
    let inline auto (p: System.Boolean) = "Auto" => p
    let inline logicalFilterOperator (p: Radzen.LogicalFilterOperator) = "LogicalFilterOperator" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterText (p: System.String) = "FilterText" => p
    let inline enumFilterSelectText (p: System.String) = "EnumFilterSelectText" => p
    let inline andOperatorText (p: System.String) = "AndOperatorText" => p
    let inline orOperatorText (p: System.String) = "OrOperatorText" => p
    let inline applyFilterText (p: System.String) = "ApplyFilterText" => p
    let inline clearFilterText (p: System.String) = "ClearFilterText" => p
    let inline addFilterText (p: System.String) = "AddFilterText" => p
    let inline removeFilterText (p: System.String) = "RemoveFilterText" => p
    let inline addFilterGroupText (p: System.String) = "AddFilterGroupText" => p
    let inline equalsText (p: System.String) = "EqualsText" => p
    let inline notEqualsText (p: System.String) = "NotEqualsText" => p
    let inline lessThanText (p: System.String) = "LessThanText" => p
    let inline lessThanOrEqualsText (p: System.String) = "LessThanOrEqualsText" => p
    let inline greaterThanText (p: System.String) = "GreaterThanText" => p
    let inline greaterThanOrEqualsText (p: System.String) = "GreaterThanOrEqualsText" => p
    let inline endsWithText (p: System.String) = "EndsWithText" => p
    let inline containsText (p: System.String) = "ContainsText" => p
    let inline doesNotContainText (p: System.String) = "DoesNotContainText" => p
    let inline inText (p: System.String) = "InText" => p
    let inline notInText (p: System.String) = "NotInText" => p
    let inline startsWithText (p: System.String) = "StartsWithText" => p
    let inline isNotNullText (p: System.String) = "IsNotNullText" => p
    let inline isNullText (p: System.String) = "IsNullText" => p
    let inline isEmptyText (p: System.String) = "IsEmptyText" => p
    let inline isNotEmptyText (p: System.String) = "IsNotEmptyText" => p
    let inline customText (p: System.String) = "CustomText" => p
    let inline allowColumnFiltering (p: System.Boolean) = "AllowColumnFiltering" => p
    let inline uniqueFilters (p: System.Boolean) = "UniqueFilters" => p

    let inline onViewChanged<'TItem53> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Linq.IQueryable<'TItem53>> "ViewChanged" p

    let inline filterDateFormat (p: System.String) = "FilterDateFormat" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDataFilterProperty<'TItem54> =
    comp<Radzen.Blazor.RadzenDataFilterProperty<'TItem54>>

module radzenDataFilterPropertyAttrs =
    let inline formatString (p: System.String) = "FormatString" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline title (p: System.String) = "Title" => p
    let inline property (p: System.String) = "Property" => p
    let inline filterProperty (p: System.String) = "FilterProperty" => p
    let inline isSelected (p: System.Boolean) = "IsSelected" => p
    let inline filterValue (p: System.Object) = "FilterValue" => p

    let inline filterTemplate
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.CompositeFilterDescriptor -> Bolero.Node)
        =
        attr.fragmentWith "FilterTemplate" p

    let inline ``type`` (p: System.Type) = "Type" => p
    let inline filterOperator (p: Radzen.FilterOperator) = "FilterOperator" => p

    let inline filterOperators (p: System.Collections.Generic.IEnumerable<Radzen.FilterOperator>) =
        "FilterOperators" => p

let radzenDataGrid<'TItem55> = comp<Radzen.Blazor.RadzenDataGrid<'TItem55>>

module radzenDataGridAttrs =
    let inline allowVirtualization (p: System.Boolean) = "AllowVirtualization" => p
    let inline virtualizationOverscanCount (p: System.Int32) = "VirtualizationOverscanCount" => p

    let inline onLoadColumnFilterData<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridLoadColumnFilterDataEventArgs<'TItem55>> "LoadColumnFilterData" p

    let inline onLoadChildData<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridLoadChildDataEventArgs<'TItem55>> "LoadChildData" p

    let inline expandChildItemAriaLabel (p: System.String) = "ExpandChildItemAriaLabel" => p
    let inline expandGroupAriaLabel (p: System.String) = "ExpandGroupAriaLabel" => p
    let inline filterToggleAriaLabel (p: System.String) = "FilterToggleAriaLabel" => p
    let inline allowCompositeDataCells (p: System.Boolean) = "AllowCompositeDataCells" => p
    let inline showEmptyMessage (p: System.Boolean) = "ShowEmptyMessage" => p
    let inline showHeader (p: System.Boolean) = "ShowHeader" => p
    let inline responsive (p: System.Boolean) = "Responsive" => p

    let inline enumFilterTranslationFunc (p: System.Func<System.String, System.String>) =
        "EnumFilterTranslationFunc" => p

    let inline onGroup<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnGroupEventArgs<'TItem55>> "Group" p

    let inline onKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "KeyDown" p

    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline footerTemplate p = attr.fragment "FooterTemplate" p
    let inline columns p = attr.fragment "Columns" p

    let inline onPickedColumnsChanged<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridPickedColumnsChangedEventArgs<'TItem55>> "PickedColumnsChanged" p

    let inline onSort<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnSortEventArgs<'TItem55>> "Sort" p

    let inline onFilter<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnFilterEventArgs<'TItem55>> "Filter" p

    let inline onFilterCleared<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnFilterEventArgs<'TItem55>> "FilterCleared" p

    let inline filterPopupRenderMode (p: Radzen.PopupRenderMode) = "FilterPopupRenderMode" => p
    let inline logicalFilterOperator (p: Radzen.LogicalFilterOperator) = "LogicalFilterOperator" => p
    let inline filterMode (p: Radzen.FilterMode) = "FilterMode" => p
    let inline expandMode (p: Radzen.DataGridExpandMode) = "ExpandMode" => p
    let inline showExpandColumn (p: System.Boolean) = "ShowExpandColumn" => p
    let inline editMode (p: Radzen.DataGridEditMode) = "EditMode" => p
    let inline filterIcon (p: System.String) = "FilterIcon" => p
    let inline filterText (p: System.String) = "FilterText" => p
    let inline enumFilterSelectText (p: System.String) = "EnumFilterSelectText" => p
    let inline enumNullFilterText (p: System.String) = "EnumNullFilterText" => p
    let inline andOperatorText (p: System.String) = "AndOperatorText" => p
    let inline orOperatorText (p: System.String) = "OrOperatorText" => p
    let inline applyFilterText (p: System.String) = "ApplyFilterText" => p
    let inline clearFilterText (p: System.String) = "ClearFilterText" => p
    let inline equalsText (p: System.String) = "EqualsText" => p
    let inline notEqualsText (p: System.String) = "NotEqualsText" => p
    let inline lessThanText (p: System.String) = "LessThanText" => p
    let inline lessThanOrEqualsText (p: System.String) = "LessThanOrEqualsText" => p
    let inline greaterThanText (p: System.String) = "GreaterThanText" => p
    let inline greaterThanOrEqualsText (p: System.String) = "GreaterThanOrEqualsText" => p
    let inline endsWithText (p: System.String) = "EndsWithText" => p
    let inline containsText (p: System.String) = "ContainsText" => p
    let inline doesNotContainText (p: System.String) = "DoesNotContainText" => p
    let inline inText (p: System.String) = "InText" => p
    let inline notInText (p: System.String) = "NotInText" => p
    let inline startsWithText (p: System.String) = "StartsWithText" => p
    let inline isNotNullText (p: System.String) = "IsNotNullText" => p
    let inline isNullText (p: System.String) = "IsNullText" => p
    let inline isEmptyText (p: System.String) = "IsEmptyText" => p
    let inline isNotEmptyText (p: System.String) = "IsNotEmptyText" => p
    let inline customText (p: System.String) = "CustomText" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterDelay (p: System.Int32) = "FilterDelay" => p
    let inline filterDateFormat (p: System.String) = "FilterDateFormat" => p
    let inline allowFilterDateInput (p: System.Boolean) = "AllowFilterDateInput" => p
    let inline columnWidth (p: System.String) = "ColumnWidth" => p
    let inline emptyText (p: System.String) = "EmptyText" => p
    let inline emptyTemplate p = attr.fragment "EmptyTemplate" p

    let inline editTemplate<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem55 -> Bolero.Node) =
        attr.fragmentWith "EditTemplate" p

    let inline isLoading (p: System.Boolean) = "IsLoading" => p
    let inline allowSorting (p: System.Boolean) = "AllowSorting" => p
    let inline allowMultiColumnSorting (p: System.Boolean) = "AllowMultiColumnSorting" => p
    let inline showMultiColumnSortingIndex (p: System.Boolean) = "ShowMultiColumnSortingIndex" => p
    let inline allowFiltering (p: System.Boolean) = "AllowFiltering" => p
    let inline allowColumnResize (p: System.Boolean) = "AllowColumnResize" => p
    let inline allowColumnReorder (p: System.Boolean) = "AllowColumnReorder" => p
    let inline allowColumnPicking (p: System.Boolean) = "AllowColumnPicking" => p
    let inline showCellDataAsTooltip (p: System.Boolean) = "ShowCellDataAsTooltip" => p
    let inline showColumnTitleAsTooltip (p: System.Boolean) = "ShowColumnTitleAsTooltip" => p
    let inline columnsShowingText (p: System.String) = "ColumnsShowingText" => p
    let inline columnsPickerMaxSelectedLabels (p: System.Int32) = "ColumnsPickerMaxSelectedLabels" => p
    let inline allColumnsText (p: System.String) = "AllColumnsText" => p
    let inline columnsText (p: System.String) = "ColumnsText" => p
    let inline removeGroupAriaLabel (p: System.String) = "RemoveGroupAriaLabel" => p
    let inline selectVisibleColumnsAriaLabel (p: System.String) = "SelectVisibleColumnsAriaLabel" => p
    let inline logicalOperatorAriaLabel (p: System.String) = "LogicalOperatorAriaLabel" => p
    let inline filterOperatorAriaLabel (p: System.String) = "FilterOperatorAriaLabel" => p
    let inline secondFilterOperatorAriaLabel (p: System.String) = "SecondFilterOperatorAriaLabel" => p
    let inline filterValueAriaLabel (p: System.String) = "FilterValueAriaLabel" => p
    let inline secondFilterValueAriaLabel (p: System.String) = "SecondFilterValueAriaLabel" => p
    let inline allowPickAllColumns (p: System.Boolean) = "AllowPickAllColumns" => p
    let inline columnsPickerAllowFiltering (p: System.Boolean) = "ColumnsPickerAllowFiltering" => p
    let inline allowGrouping (p: System.Boolean) = "AllowGrouping" => p
    let inline hideGroupedColumn (p: System.Boolean) = "HideGroupedColumn" => p
    let inline groupFootersAlwaysVisible (p: System.Boolean) = "GroupFootersAlwaysVisible" => p

    let inline groupHeaderTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Group -> Bolero.Node) =
        attr.fragmentWith "GroupHeaderTemplate" p

    let inline groupHeaderToggleTemplate<'TItem55>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p:
            System.ValueTuple<Radzen.Group, Radzen.Blazor.RadzenDataGridGroupRow<'TItem55>> -> Bolero.Node)
        =
        attr.fragmentWith "GroupHeaderToggleTemplate" p

    let inline groupPanelText (p: System.String) = "GroupPanelText" => p

    let inline onColumnResized<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnResizedEventArgs<'TItem55>> "ColumnResized" p

    let inline onColumnReordering<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnReorderingEventArgs<'TItem55>> "ColumnReordering" p

    let inline onColumnReordered<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridColumnReorderedEventArgs<'TItem55>> "ColumnReordered" p

    let inline value<'TItem55> (p: System.Collections.Generic.IList<'TItem55>) = "Value" => p

    let inline onValueChanged<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IList<'TItem55>> "ValueChanged" p

    let inline onRowSelect<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TItem55> "RowSelect" p

    let inline onRowDeselect<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TItem55> "RowDeselect" p

    let inline onRowClick<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridRowMouseEventArgs<'TItem55>> "RowClick" p

    let inline onRowDoubleClick<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridRowMouseEventArgs<'TItem55>> "RowDoubleClick" p

    let inline onCellClick<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridCellMouseEventArgs<'TItem55>> "CellClick" p

    let inline onCellDoubleClick<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridCellMouseEventArgs<'TItem55>> "CellDoubleClick" p

    let inline onCellContextMenu<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridCellMouseEventArgs<'TItem55>> "CellContextMenu" p

    let inline onRowExpand<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TItem55> "RowExpand" p

    let inline onGroupRowExpand ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Group> "GroupRowExpand" p

    let inline onRowCollapse<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TItem55> "RowCollapse" p

    let inline onGroupRowCollapse ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Group> "GroupRowCollapse" p

    let inline rowRender<'TItem55> (p: System.Action<Radzen.RowRenderEventArgs<'TItem55>>) = "RowRender" => p
    let inline groupRowRender (p: System.Action<Radzen.GroupRowRenderEventArgs>) = "GroupRowRender" => p
    let inline cellRender<'TItem55> (p: System.Action<Radzen.DataGridCellRenderEventArgs<'TItem55>>) = "CellRender" => p

    let inline headerCellRender<'TItem55> (p: System.Action<Radzen.DataGridCellRenderEventArgs<'TItem55>>) =
        "HeaderCellRender" => p

    let inline footerCellRender<'TItem55> (p: System.Action<Radzen.DataGridCellRenderEventArgs<'TItem55>>) =
        "FooterCellRender" => p

    let inline render<'TItem55> (p: System.Action<Radzen.DataGridRenderEventArgs<'TItem55>>) = "Render" => p

    let inline renderAsync<'TItem55>
        (p: System.Func<Radzen.DataGridRenderEventArgs<'TItem55>, System.Threading.Tasks.Task>)
        =
        "RenderAsync" => p

    let inline loadSettings (p: System.Action<Radzen.DataGridLoadSettingsEventArgs>) = "LoadSettings" => p
    let inline allGroupsExpanded (p: System.Nullable<System.Boolean>) = "AllGroupsExpanded" => p

    let inline onAllGroupsExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.Boolean>> "AllGroupsExpandedChanged" p

    let inline keyProperty (p: System.String) = "KeyProperty" => p
    let inline allowRowSelectOnRowClick (p: System.Boolean) = "AllowRowSelectOnRowClick" => p
    let inline allowAlternatingRows (p: System.Boolean) = "AllowAlternatingRows" => p
    let inline showGroupExpandColumn (p: System.Boolean) = "ShowGroupExpandColumn" => p
    let inline gridLines (p: Radzen.DataGridGridLines) = "GridLines" => p
    let inline gotoFirstPageOnSort (p: System.Boolean) = "GotoFirstPageOnSort" => p
    let inline selectionMode (p: Radzen.DataGridSelectionMode) = "SelectionMode" => p
    let inline onRowEdit<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TItem55> "RowEdit" p

    let inline onRowUpdate<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TItem55> "RowUpdate" p

    let inline onRowCreate<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TItem55> "RowCreate" p

    let inline onPageSizeChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "PageSizeChanged" p

    let inline settings (p: Radzen.DataGridSettings) = "Settings" => p

    let inline onSettingsChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.DataGridSettings> "SettingsChanged" p

    let inline pagerPosition (p: Radzen.PagerPosition) = "PagerPosition" => p
    let inline pagerAlwaysVisible (p: System.Boolean) = "PagerAlwaysVisible" => p
    let inline pagerHorizontalAlign (p: Radzen.HorizontalAlign) = "PagerHorizontalAlign" => p
    let inline density (p: Radzen.Density) = "Density" => p
    let inline allowPaging (p: System.Boolean) = "AllowPaging" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline pageNumbersCount (p: System.Int32) = "PageNumbersCount" => p
    let inline count (p: System.Int32) = "Count" => p

    let inline template<'TItem55> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem55 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline loadingTemplate p = attr.fragment "LoadingTemplate" p
    let inline data<'TItem55> (p: System.Collections.Generic.IEnumerable<'TItem55>) = "Data" => p
    let inline pageSizeOptions (p: System.Collections.Generic.IEnumerable<System.Int32>) = "PageSizeOptions" => p
    let inline pageSizeText (p: System.String) = "PageSizeText" => p
    let inline showPagingSummary (p: System.Boolean) = "ShowPagingSummary" => p
    let inline pagingSummaryFormat (p: System.String) = "PagingSummaryFormat" => p
    let inline firstPageTitle (p: System.String) = "FirstPageTitle" => p
    let inline firstPageAriaLabel (p: System.String) = "FirstPageAriaLabel" => p
    let inline prevPageLabel (p: System.String) = "PrevPageLabel" => p
    let inline prevPageTitle (p: System.String) = "PrevPageTitle" => p
    let inline prevPageAriaLabel (p: System.String) = "PrevPageAriaLabel" => p
    let inline lastPageTitle (p: System.String) = "LastPageTitle" => p
    let inline lastPageAriaLabel (p: System.String) = "LastPageAriaLabel" => p
    let inline nextPageLabel (p: System.String) = "NextPageLabel" => p
    let inline nextPageTitle (p: System.String) = "NextPageTitle" => p
    let inline nextPageAriaLabel (p: System.String) = "NextPageAriaLabel" => p
    let inline pageTitleFormat (p: System.String) = "PageTitleFormat" => p
    let inline pageAriaLabelFormat (p: System.String) = "PageAriaLabelFormat" => p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline onPage ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.PagerEventArgs> "Page" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDataGridColumn<'TItem56> =
    comp<Radzen.Blazor.RadzenDataGridColumn<'TItem56>>

module radzenDataGridColumnAttrs =
    let inline columns p = attr.fragment "Columns" p
    let inline allowCheckBoxListVirtualization (p: System.Boolean) = "AllowCheckBoxListVirtualization" => p
    let inline filterMode (p: System.Nullable<Radzen.FilterMode>) = "FilterMode" => p
    let inline uniqueID (p: System.String) = "UniqueID" => p
    let inline orderIndex (p: System.Nullable<System.Int32>) = "OrderIndex" => p
    let inline sortOrder (p: System.Nullable<Radzen.SortOrder>) = "SortOrder" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline headerTooltip (p: System.String) = "HeaderTooltip" => p
    let inline title (p: System.String) = "Title" => p
    let inline columnPickerTitle (p: System.String) = "ColumnPickerTitle" => p
    let inline property (p: System.String) = "Property" => p
    let inline sortProperty (p: System.String) = "SortProperty" => p
    let inline groupProperty (p: System.String) = "GroupProperty" => p
    let inline filterProperty (p: System.String) = "FilterProperty" => p
    let inline filterValue (p: System.Object) = "FilterValue" => p
    let inline filterPlaceholder (p: System.String) = "FilterPlaceholder" => p
    let inline customFilterExpression (p: System.String) = "CustomFilterExpression" => p
    let inline secondFilterValue (p: System.Object) = "SecondFilterValue" => p
    let inline width (p: System.String) = "Width" => p
    let inline minWidth (p: System.String) = "MinWidth" => p
    let inline maxWidth (p: System.String) = "MaxWidth" => p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline cssClass (p: System.String) = "CssClass" => p

    let inline calculatedCssClass<'TItem56>
        (p: System.Func<Radzen.Blazor.RadzenDataGridColumn<'TItem56>, 'TItem56, System.String>)
        =
        "CalculatedCssClass" => p

    let inline headerCssClass (p: System.String) = "HeaderCssClass" => p
    let inline footerCssClass (p: System.String) = "FooterCssClass" => p
    let inline groupFooterCssClass (p: System.String) = "GroupFooterCssClass" => p
    let inline headerWhiteSpace (p: Radzen.Blazor.WhiteSpace) = "HeaderWhiteSpace" => p
    let inline whiteSpace (p: Radzen.Blazor.WhiteSpace) = "WhiteSpace" => p
    let inline filterable (p: System.Boolean) = "Filterable" => p
    let inline sortable (p: System.Boolean) = "Sortable" => p
    let inline frozen (p: System.Boolean) = "Frozen" => p
    let inline frozenPosition (p: Radzen.FrozenColumnPosition) = "FrozenPosition" => p
    let inline resizable (p: System.Boolean) = "Resizable" => p
    let inline reorderable (p: System.Boolean) = "Reorderable" => p
    let inline groupable (p: System.Boolean) = "Groupable" => p
    let inline pickable (p: System.Boolean) = "Pickable" => p
    let inline textAlign (p: Radzen.TextAlign) = "TextAlign" => p

    let inline template<'TItem56> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem56 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline editTemplate<'TItem56> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem56 -> Bolero.Node) =
        attr.fragmentWith "EditTemplate" p

    let inline isInEditMode<'TItem56> (p: System.Func<System.String, 'TItem56, System.Boolean>) = "IsInEditMode" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline footerTemplate p = attr.fragment "FooterTemplate" p

    let inline groupFooterTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Group -> Bolero.Node) =
        attr.fragmentWith "GroupFooterTemplate" p

    let inline filterTemplate<'TItem56>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenDataGridColumn<'TItem56> -> Bolero.Node)
        =
        attr.fragmentWith "FilterTemplate" p

    let inline filterValueTemplate<'TItem56>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenDataGridColumn<'TItem56> -> Bolero.Node)
        =
        attr.fragmentWith "FilterValueTemplate" p

    let inline secondFilterValueTemplate<'TItem56>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenDataGridColumn<'TItem56> -> Bolero.Node)
        =
        attr.fragmentWith "SecondFilterValueTemplate" p

    let inline logicalFilterOperator (p: Radzen.LogicalFilterOperator) = "LogicalFilterOperator" => p
    let inline ``type`` (p: System.Type) = "Type" => p
    let inline formatProvider (p: System.IFormatProvider) = "FormatProvider" => p
    let inline filterOperator (p: Radzen.FilterOperator) = "FilterOperator" => p

    let inline filterOperators (p: System.Collections.Generic.IEnumerable<Radzen.FilterOperator>) =
        "FilterOperators" => p

    let inline secondFilterOperator (p: Radzen.FilterOperator) = "SecondFilterOperator" => p

let radzenDataGridRow<'TItem57> = comp<Radzen.Blazor.RadzenDataGridRow<'TItem57>>

module radzenDataGridRowAttrs =
    let inline columns<'TItem57> (p: System.Collections.Generic.IList<Radzen.Blazor.RadzenDataGridColumn<'TItem57>>) =
        "Columns" => p

    let inline item (p: 'TItem57) = "Item" => p
    let inline index (p: System.Int32) = "Index" => p
    let inline grid<'TItem57> (p: Radzen.Blazor.RadzenDataGrid<'TItem57>) = "Grid" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline cssClass (p: System.String) = "CssClass" => p
    let inline inEditMode (p: System.Boolean) = "InEditMode" => p
    let inline editContext (p: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => p

let radzenDataList<'TItem58> = comp<Radzen.Blazor.RadzenDataList<'TItem58>>

module radzenDataListAttrs =
    let inline showEmptyMessage (p: System.Boolean) = "ShowEmptyMessage" => p
    let inline emptyText (p: System.String) = "EmptyText" => p
    let inline emptyTemplate p = attr.fragment "EmptyTemplate" p
    let inline wrapItems (p: System.Boolean) = "WrapItems" => p
    let inline allowVirtualization (p: System.Boolean) = "AllowVirtualization" => p
    let inline isLoading (p: System.Boolean) = "IsLoading" => p
    let inline pagerPosition (p: Radzen.PagerPosition) = "PagerPosition" => p
    let inline pagerAlwaysVisible (p: System.Boolean) = "PagerAlwaysVisible" => p
    let inline pagerHorizontalAlign (p: Radzen.HorizontalAlign) = "PagerHorizontalAlign" => p
    let inline density (p: Radzen.Density) = "Density" => p
    let inline allowPaging (p: System.Boolean) = "AllowPaging" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline pageNumbersCount (p: System.Int32) = "PageNumbersCount" => p
    let inline count (p: System.Int32) = "Count" => p

    let inline template<'TItem58> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem58 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline loadingTemplate p = attr.fragment "LoadingTemplate" p
    let inline data<'TItem58> (p: System.Collections.Generic.IEnumerable<'TItem58>) = "Data" => p
    let inline pageSizeOptions (p: System.Collections.Generic.IEnumerable<System.Int32>) = "PageSizeOptions" => p
    let inline pageSizeText (p: System.String) = "PageSizeText" => p
    let inline showPagingSummary (p: System.Boolean) = "ShowPagingSummary" => p
    let inline pagingSummaryFormat (p: System.String) = "PagingSummaryFormat" => p
    let inline firstPageTitle (p: System.String) = "FirstPageTitle" => p
    let inline firstPageAriaLabel (p: System.String) = "FirstPageAriaLabel" => p
    let inline prevPageLabel (p: System.String) = "PrevPageLabel" => p
    let inline prevPageTitle (p: System.String) = "PrevPageTitle" => p
    let inline prevPageAriaLabel (p: System.String) = "PrevPageAriaLabel" => p
    let inline lastPageTitle (p: System.String) = "LastPageTitle" => p
    let inline lastPageAriaLabel (p: System.String) = "LastPageAriaLabel" => p
    let inline nextPageLabel (p: System.String) = "NextPageLabel" => p
    let inline nextPageTitle (p: System.String) = "NextPageTitle" => p
    let inline nextPageAriaLabel (p: System.String) = "NextPageAriaLabel" => p
    let inline pageTitleFormat (p: System.String) = "PageTitleFormat" => p
    let inline pageAriaLabelFormat (p: System.String) = "PageAriaLabelFormat" => p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline onPage ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.PagerEventArgs> "Page" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDatePicker<'TValue59> = comp<Radzen.Blazor.RadzenDatePicker<'TValue59>>

module radzenDatePickerAttrs =
    let inline showCalendarWeek (p: System.Boolean) = "ShowCalendarWeek" => p
    let inline calendarWeekTitle (p: System.String) = "CalendarWeekTitle" => p
    let inline toggleAriaLabel (p: System.String) = "ToggleAriaLabel" => p
    let inline okAriaLabel (p: System.String) = "OkAriaLabel" => p
    let inline prevMonthAriaLabel (p: System.String) = "PrevMonthAriaLabel" => p
    let inline nextMonthAriaLabel (p: System.String) = "NextMonthAriaLabel" => p
    let inline toggleAmPmAriaLabel (p: System.String) = "ToggleAmPmAriaLabel" => p

    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline yearFormatter (p: System.Func<System.Int32, System.String>) = "YearFormatter" => p
    let inline yearFormat (p: System.String) = "YearFormat" => p
    let inline allowClear (p: System.Boolean) = "AllowClear" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline name (p: System.String) = "Name" => p
    let inline inputClass (p: System.String) = "InputClass" => p
    let inline buttonClass (p: System.String) = "ButtonClass" => p
    let inline min (p: System.Nullable<System.DateTime>) = "Min" => p
    let inline max (p: System.Nullable<System.DateTime>) = "Max" => p
    let inline initialViewDate (p: System.Nullable<System.DateTime>) = "InitialViewDate" => p
    let inline dateRender (p: System.Action<Radzen.DateRenderEventArgs>) = "DateRender" => p
    let inline kind (p: System.DateTimeKind) = "Kind" => p
    let inline value (p: System.Object) = "Value" => p

    let inline onCurrentDateChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.DateTime> "CurrentDateChanged" p

    let inline parseInput (p: System.Func<System.String, System.Nullable<System.DateTime>>) = "ParseInput" => p
    let inline ``inline`` (p: System.Boolean) = "Inline" => p
    let inline timeOnly (p: System.Boolean) = "TimeOnly" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline allowInput (p: System.Boolean) = "AllowInput" => p
    let inline showButton (p: System.Boolean) = "ShowButton" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline showDays (p: System.Boolean) = "ShowDays" => p
    let inline showTime (p: System.Boolean) = "ShowTime" => p
    let inline showSeconds (p: System.Boolean) = "ShowSeconds" => p
    let inline hoursStep (p: System.String) = "HoursStep" => p
    let inline minutesStep (p: System.String) = "MinutesStep" => p
    let inline secondsStep (p: System.String) = "SecondsStep" => p
    let inline padHours (p: System.Boolean) = "PadHours" => p
    let inline padMinutes (p: System.Boolean) = "PadMinutes" => p
    let inline padSeconds (p: System.Boolean) = "PadSeconds" => p
    let inline showTimeOkButton (p: System.Boolean) = "ShowTimeOkButton" => p
    let inline dateFormat (p: System.String) = "DateFormat" => p
    let inline yearRange (p: System.String) = "YearRange" => p
    let inline hourFormat (p: System.String) = "HourFormat" => p
    let inline placeholder (p: System.String) = "Placeholder" => p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.DateTime>> "Change" p

    let inline onValueChanged<'TValue59> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue59> "ValueChanged" p

    let inline footerTemplate p = attr.fragment "FooterTemplate" p

    let inline valueExpression<'TValue59> (p: System.Linq.Expressions.Expression<System.Func<'TValue59>>) =
        "ValueExpression" => p

    let inline popupRenderMode (p: Radzen.PopupRenderMode) = "PopupRenderMode" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDayView = comp<Radzen.Blazor.RadzenDayView>

module radzenDayViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline startTime (p: System.TimeSpan) = "StartTime" => p
    let inline endTime (p: System.TimeSpan) = "EndTime" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p

let radzenDonutSeries<'TItem60> = comp<Radzen.Blazor.RadzenDonutSeries<'TItem60>>

module radzenDonutSeriesAttrs =
    let inline innerRadius (p: System.Nullable<System.Double>) = "InnerRadius" => p
    let inline titleTemplate p = attr.fragment "TitleTemplate" p
    let inline x (p: System.Nullable<System.Double>) = "X" => p
    let inline y (p: System.Nullable<System.Double>) = "Y" => p
    let inline radius (p: System.Nullable<System.Double>) = "Radius" => p
    let inline fills (p: System.Collections.Generic.IEnumerable<System.String>) = "Fills" => p
    let inline strokes (p: System.Collections.Generic.IEnumerable<System.String>) = "Strokes" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline totalAngle (p: System.Double) = "TotalAngle" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem60> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem60 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem60> (p: System.Collections.Generic.IEnumerable<'TItem60>) = "Data" => p

let radzenDropDown<'TValue61> = comp<Radzen.Blazor.RadzenDropDown<'TValue61>>

module radzenDropDownAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline readOnly (p: System.Boolean) = "ReadOnly" => p

    let inline valueTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "ValueTemplate" p

    let inline emptyTemplate p = attr.fragment "EmptyTemplate" p
    let inline openOnFocus (p: System.Boolean) = "OpenOnFocus" => p
    let inline clearSearchAfterSelection (p: System.Boolean) = "ClearSearchAfterSelection" => p
    let inline filterPlaceholder (p: System.String) = "FilterPlaceholder" => p
    let inline filterAutoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "FilterAutoCompleteType" => p

    let inline itemRender<'TValue61> (p: System.Action<Radzen.DropDownItemRenderEventArgs<'TValue61>>) =
        "ItemRender" => p

    let inline maxSelectedLabels (p: System.Int32) = "MaxSelectedLabels" => p
    let inline popupStyle (p: System.String) = "PopupStyle" => p
    let inline chips (p: System.Boolean) = "Chips" => p
    let inline selectedItemsText (p: System.String) = "SelectedItemsText" => p
    let inline selectAllText (p: System.String) = "SelectAllText" => p
    let inline ``open`` (p: Microsoft.AspNetCore.Components.EventCallback) = "Open" => p
    let inline close (p: Microsoft.AspNetCore.Components.EventCallback) = "Close" => p
    let inline virtualizationOverscanCount (p: System.Int32) = "VirtualizationOverscanCount" => p
    let inline count (p: System.Int32) = "Count" => p
    let inline allowVirtualization (p: System.Boolean) = "AllowVirtualization" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline allowFiltering (p: System.Boolean) = "AllowFiltering" => p
    let inline filterAsYouType (p: System.Boolean) = "FilterAsYouType" => p
    let inline allowClear (p: System.Boolean) = "AllowClear" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline allowSelectAll (p: System.Boolean) = "AllowSelectAll" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p
    let inline removeChipTitle (p: System.String) = "RemoveChipTitle" => p
    let inline searchAriaLabel (p: System.String) = "SearchAriaLabel" => p
    let inline emptyAriaLabel (p: System.String) = "EmptyAriaLabel" => p

    let inline onSelectedItemChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "SelectedItemChanged" p

    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline filterDelay (p: System.Int32) = "FilterDelay" => p
    let inline selectedItem (p: System.Object) = "SelectedItem" => p
    let inline separator (p: System.String) = "Separator" => p
    let inline itemComparer (p: System.Collections.Generic.IEqualityComparer<System.Object>) = "ItemComparer" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterOperator (p: Radzen.StringFilterOperator) = "FilterOperator" => p
    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Object> "Change" p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline value (p: System.Object) = "Value" => p

    let inline onValueChanged<'TValue61> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue61> "ValueChanged" p

    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline searchText (p: System.String) = "SearchText" => p

    let inline onSearchTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "SearchTextChanged" p

    let inline valueExpression<'TValue61> (p: System.Linq.Expressions.Expression<System.Func<'TValue61>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDropDownDataGrid<'TValue62> =
    comp<Radzen.Blazor.RadzenDropDownDataGrid<'TValue62>>

module radzenDropDownDataGridAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline rowRender (p: System.Action<Radzen.RowRenderEventArgs<System.Object>>) = "RowRender" => p
    let inline cellRender (p: System.Action<Radzen.DataGridCellRenderEventArgs<System.Object>>) = "CellRender" => p
    let inline footerTemplate p = attr.fragment "FooterTemplate" p
    let inline chips (p: System.Boolean) = "Chips" => p
    let inline popupStyle (p: System.String) = "PopupStyle" => p
    let inline openOnFocus (p: System.Boolean) = "OpenOnFocus" => p

    let inline valueTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "ValueTemplate" p

    let inline density (p: Radzen.Density) = "Density" => p
    let inline emptyTemplate p = attr.fragment "EmptyTemplate" p
    let inline pagerAlwaysVisible (p: System.Boolean) = "PagerAlwaysVisible" => p
    let inline pagerHorizontalAlign (p: Radzen.HorizontalAlign) = "PagerHorizontalAlign" => p
    let inline allowColumnResize (p: System.Boolean) = "AllowColumnResize" => p
    let inline columnWidth (p: System.String) = "ColumnWidth" => p
    let inline responsive (p: System.Boolean) = "Responsive" => p
    let inline showSearch (p: System.Boolean) = "ShowSearch" => p

    let inline onAdd ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "Add" p

    let inline showAdd (p: System.Boolean) = "ShowAdd" => p
    let inline preserveRowSelectionOnPaging (p: System.Boolean) = "PreserveRowSelectionOnPaging" => p
    let inline pageNumbersCount (p: System.Int32) = "PageNumbersCount" => p
    let inline showPagingSummary (p: System.Boolean) = "ShowPagingSummary" => p
    let inline pagingSummaryFormat (p: System.String) = "PagingSummaryFormat" => p
    let inline firstPageTitle (p: System.String) = "FirstPageTitle" => p
    let inline firstPageAriaLabel (p: System.String) = "FirstPageAriaLabel" => p
    let inline prevPageTitle (p: System.String) = "PrevPageTitle" => p
    let inline prevPageAriaLabel (p: System.String) = "PrevPageAriaLabel" => p
    let inline lastPageTitle (p: System.String) = "LastPageTitle" => p
    let inline lastPageAriaLabel (p: System.String) = "LastPageAriaLabel" => p
    let inline nextPageTitle (p: System.String) = "NextPageTitle" => p
    let inline nextPageAriaLabel (p: System.String) = "NextPageAriaLabel" => p
    let inline pageTitleFormat (p: System.String) = "PageTitleFormat" => p
    let inline pageAriaLabelFormat (p: System.String) = "PageAriaLabelFormat" => p
    let inline emptyText (p: System.String) = "EmptyText" => p
    let inline searchTextPlaceholder (p: System.String) = "SearchTextPlaceholder" => p
    let inline addAriaLabel (p: System.String) = "AddAriaLabel" => p
    let inline selectedValue (p: System.Object) = "SelectedValue" => p
    let inline columns p = attr.fragment "Columns" p
    let inline maxSelectedLabels (p: System.Int32) = "MaxSelectedLabels" => p
    let inline selectedItemsText (p: System.String) = "SelectedItemsText" => p
    let inline focusFilterOnPopup (p: System.Boolean) = "FocusFilterOnPopup" => p
    let inline isLoading (p: System.Boolean) = "IsLoading" => p
    let inline allowSorting (p: System.Boolean) = "AllowSorting" => p
    let inline allowFiltering (p: System.Boolean) = "AllowFiltering" => p
    let inline allowFilteringByAllStringColumns (p: System.Boolean) = "AllowFilteringByAllStringColumns" => p
    let inline allowFilteringByWord (p: System.Boolean) = "AllowFilteringByWord" => p
    let inline allowRowSelectOnRowClick (p: System.Boolean) = "AllowRowSelectOnRowClick" => p
    let inline virtualizationOverscanCount (p: System.Int32) = "VirtualizationOverscanCount" => p
    let inline count (p: System.Int32) = "Count" => p
    let inline allowVirtualization (p: System.Boolean) = "AllowVirtualization" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline filterAsYouType (p: System.Boolean) = "FilterAsYouType" => p
    let inline allowClear (p: System.Boolean) = "AllowClear" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline allowSelectAll (p: System.Boolean) = "AllowSelectAll" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p
    let inline removeChipTitle (p: System.String) = "RemoveChipTitle" => p
    let inline searchAriaLabel (p: System.String) = "SearchAriaLabel" => p
    let inline emptyAriaLabel (p: System.String) = "EmptyAriaLabel" => p

    let inline onSelectedItemChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "SelectedItemChanged" p

    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline filterDelay (p: System.Int32) = "FilterDelay" => p
    let inline selectedItem (p: System.Object) = "SelectedItem" => p
    let inline separator (p: System.String) = "Separator" => p
    let inline itemComparer (p: System.Collections.Generic.IEqualityComparer<System.Object>) = "ItemComparer" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterOperator (p: Radzen.StringFilterOperator) = "FilterOperator" => p
    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Object> "Change" p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline value (p: System.Object) = "Value" => p

    let inline onValueChanged<'TValue62> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue62> "ValueChanged" p

    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline searchText (p: System.String) = "SearchText" => p

    let inline onSearchTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "SearchTextChanged" p

    let inline valueExpression<'TValue62> (p: System.Linq.Expressions.Expression<System.Func<'TValue62>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDropZone<'TItem63> = comp<Radzen.Blazor.RadzenDropZone<'TItem63>>

module radzenDropZoneAttrs =
    let inline value (p: System.Object) = "Value" => p
    let inline footer p = attr.fragment "Footer" p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDropZoneContainer<'TItem64> =
    comp<Radzen.Blazor.RadzenDropZoneContainer<'TItem64>>

module radzenDropZoneContainerAttrs =
    let inline data<'TItem64> (p: System.Collections.Generic.IEnumerable<'TItem64>) = "Data" => p

    let inline itemSelector<'TItem64>
        (p: System.Func<'TItem64, Radzen.Blazor.RadzenDropZone<'TItem64>, System.Boolean>)
        =
        "ItemSelector" => p

    let inline canDrop<'TItem64> (p: System.Func<Radzen.RadzenDropZoneItemEventArgs<'TItem64>, System.Boolean>) =
        "CanDrop" => p

    let inline itemRender<'TItem64> (p: System.Action<Radzen.RadzenDropZoneItemRenderEventArgs<'TItem64>>) =
        "ItemRender" => p

    let inline template<'TItem64> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem64 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline onDrop<'TItem64> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.RadzenDropZoneItemEventArgs<'TItem64>> "Drop" p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenDropZoneItem<'TItem65> = comp<Radzen.Blazor.RadzenDropZoneItem<'TItem65>>

module radzenDropZoneItemAttrs =
    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenEmailValidator = comp<Radzen.Blazor.RadzenEmailValidator>

module radzenEmailValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenFieldset = comp<Radzen.Blazor.RadzenFieldset>

module radzenFieldsetAttrs =
    let inline allowCollapse (p: System.Boolean) = "AllowCollapse" => p
    let inline collapsed (p: System.Boolean) = "Collapsed" => p
    let inline expandTitle (p: System.String) = "ExpandTitle" => p
    let inline collapseTitle (p: System.String) = "CollapseTitle" => p
    let inline expandAriaLabel (p: System.String) = "ExpandAriaLabel" => p
    let inline collapseAriaLabel (p: System.String) = "CollapseAriaLabel" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline text (p: System.String) = "Text" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline summaryTemplate p = attr.fragment "SummaryTemplate" p
    let inline expand (p: Microsoft.AspNetCore.Components.EventCallback) = "Expand" => p
    let inline collapse (p: Microsoft.AspNetCore.Components.EventCallback) = "Collapse" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenFileInput<'TValue66> = comp<Radzen.Blazor.RadzenFileInput<'TValue66>>

module radzenFileInputAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline chooseText (p: System.String) = "ChooseText" => p
    let inline deleteText (p: System.String) = "DeleteText" => p
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline title (p: System.String) = "Title" => p

    let inline onError ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadErrorEventArgs> "Error" p

    let inline onImageClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ImageClick" p

    let inline accept (p: System.String) = "Accept" => p
    let inline maxFileSize (p: System.Int32) = "MaxFileSize" => p
    let inline maxWidth (p: System.Int32) = "MaxWidth" => p
    let inline maxHeight (p: System.Int32) = "MaxHeight" => p
    let inline imageStyle (p: System.String) = "ImageStyle" => p
    let inline fileName (p: System.String) = "FileName" => p

    let inline onFileNameChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "FileNameChanged" p

    let inline fileSize (p: System.Nullable<System.Int64>) = "FileSize" => p

    let inline onFileSizeChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.Int64>> "FileSizeChanged" p

    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue66> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue66> "ValueChanged" p

    let inline value (p: 'TValue66) = "Value" => p
    let inline onChange<'TValue66> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TValue66> "Change" p

    let inline valueExpression<'TValue66> (p: System.Linq.Expressions.Expression<System.Func<'TValue66>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenFooter = comp<Radzen.Blazor.RadzenFooter>

module radzenFooterAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenFormField = comp<Radzen.Blazor.RadzenFormField>

module radzenFormFieldAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline start p = attr.fragment "Start" p
    let inline ``end`` p = attr.fragment "End" p
    let inline helper p = attr.fragment "Helper" p
    let inline text (p: System.String) = "Text" => p
    let inline allowFloatingLabel (p: System.Boolean) = "AllowFloatingLabel" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline variant (p: Radzen.Variant) = "Variant" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenGoogleMap = comp<Radzen.Blazor.RadzenGoogleMap>

module radzenGoogleMapAttrs =
    let inline data (p: System.Collections.Generic.IEnumerable<Radzen.Blazor.RadzenGoogleMapMarker>) = "Data" => p

    let inline onMapClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.GoogleMapClickEventArgs> "MapClick" p

    let inline onMarkerClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.RadzenGoogleMapMarker> "MarkerClick" p

    let inline apiKey (p: System.String) = "ApiKey" => p
    let inline mapId (p: System.String) = "MapId" => p
    let inline options (p: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Options" => p
    let inline zoom (p: System.Double) = "Zoom" => p
    let inline fitBoundsToMarkersOnUpdate (p: System.Boolean) = "FitBoundsToMarkersOnUpdate" => p
    let inline center (p: Radzen.GoogleMapPosition) = "Center" => p
    let inline markers p = attr.fragment "Markers" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenGoogleMapMarker = comp<Radzen.Blazor.RadzenGoogleMapMarker>

module radzenGoogleMapMarkerAttrs =
    let inline position (p: Radzen.GoogleMapPosition) = "Position" => p
    let inline title (p: System.String) = "Title" => p
    let inline label (p: System.String) = "Label" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenGravatar = comp<Radzen.Blazor.RadzenGravatar>

module radzenGravatarAttrs =
    let inline email (p: System.String) = "Email" => p
    let inline alternateText (p: System.String) = "AlternateText" => p
    let inline size (p: System.Int32) = "Size" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenGridLines = comp<Radzen.Blazor.RadzenGridLines>

module radzenGridLinesAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenHeader = comp<Radzen.Blazor.RadzenHeader>

module radzenHeaderAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenHeading = comp<Radzen.Blazor.RadzenHeading>

module radzenHeadingAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline size (p: System.String) = "Size" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenHtml = comp<Radzen.Blazor.RadzenHtml>

module radzenHtmlAttrs =
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline childContent p = attr.fragment "ChildContent" p

let radzenHtmlEditor = comp<Radzen.Blazor.RadzenHtmlEditor>

module radzenHtmlEditorAttrs =
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline mode (p: Radzen.HtmlEditorMode) = "Mode" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline uploadHeaders (p: System.Collections.Generic.IDictionary<System.String, System.String>) =
        "UploadHeaders" => p

    let inline onInput ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Input" p

    let inline onPaste ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.HtmlEditorPasteEventArgs> "Paste" p

    let inline onUploadError ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadErrorEventArgs> "UploadError" p

    let inline onExecute ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.HtmlEditorExecuteEventArgs> "Execute" p

    let inline uploadUrl (p: System.String) = "UploadUrl" => p

    let inline onUploadComplete ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadCompleteEventArgs> "UploadComplete" p

    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenHtmlEditorAlignCenter = comp<Radzen.Blazor.RadzenHtmlEditorAlignCenter>

module radzenHtmlEditorAlignCenterAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorAlignLeft = comp<Radzen.Blazor.RadzenHtmlEditorAlignLeft>

module radzenHtmlEditorAlignLeftAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorAlignRight = comp<Radzen.Blazor.RadzenHtmlEditorAlignRight>

module radzenHtmlEditorAlignRightAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorBackground = comp<Radzen.Blazor.RadzenHtmlEditorBackground>

module radzenHtmlEditorBackgroundAttrs =
    let inline value (p: System.String) = "Value" => p
    let inline title (p: System.String) = "Title" => p
    let inline showHSV (p: System.Boolean) = "ShowHSV" => p
    let inline showRGBA (p: System.Boolean) = "ShowRGBA" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline showColors (p: System.Boolean) = "ShowColors" => p
    let inline showButton (p: System.Boolean) = "ShowButton" => p
    let inline hexText (p: System.String) = "HexText" => p
    let inline redText (p: System.String) = "RedText" => p
    let inline greenText (p: System.String) = "GreenText" => p
    let inline blueText (p: System.String) = "BlueText" => p
    let inline alphaText (p: System.String) = "AlphaText" => p
    let inline buttonText (p: System.String) = "ButtonText" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorBackgroundItem =
    comp<Radzen.Blazor.RadzenHtmlEditorBackgroundItem>

module radzenHtmlEditorBackgroundItemAttrs =
    let inline value (p: System.String) = "Value" => p

let radzenHtmlEditorBold = comp<Radzen.Blazor.RadzenHtmlEditorBold>

module radzenHtmlEditorBoldAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorColor = comp<Radzen.Blazor.RadzenHtmlEditorColor>

module radzenHtmlEditorColorAttrs =
    let inline value (p: System.String) = "Value" => p
    let inline title (p: System.String) = "Title" => p
    let inline showHSV (p: System.Boolean) = "ShowHSV" => p
    let inline showRGBA (p: System.Boolean) = "ShowRGBA" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline showColors (p: System.Boolean) = "ShowColors" => p
    let inline showButton (p: System.Boolean) = "ShowButton" => p
    let inline hexText (p: System.String) = "HexText" => p
    let inline redText (p: System.String) = "RedText" => p
    let inline greenText (p: System.String) = "GreenText" => p
    let inline blueText (p: System.String) = "BlueText" => p
    let inline alphaText (p: System.String) = "AlphaText" => p
    let inline buttonText (p: System.String) = "ButtonText" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorColorItem = comp<Radzen.Blazor.RadzenHtmlEditorColorItem>

module radzenHtmlEditorColorItemAttrs =
    let inline value (p: System.String) = "Value" => p

let radzenHtmlEditorCustomTool = comp<Radzen.Blazor.RadzenHtmlEditorCustomTool>

module radzenHtmlEditorCustomToolAttrs =
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline enabledModes (p: Radzen.HtmlEditorMode) = "EnabledModes" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenHtmlEditor -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline selected (p: System.Boolean) = "Selected" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline commandName (p: System.String) = "CommandName" => p
    let inline title (p: System.String) = "Title" => p

let radzenHtmlEditorFontName = comp<Radzen.Blazor.RadzenHtmlEditorFontName>

module radzenHtmlEditorFontNameAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline title (p: System.String) = "Title" => p

let radzenHtmlEditorFontNameItem = comp<Radzen.Blazor.RadzenHtmlEditorFontNameItem>

module radzenHtmlEditorFontNameItemAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.String) = "Value" => p

let radzenHtmlEditorFontSize = comp<Radzen.Blazor.RadzenHtmlEditorFontSize>

module radzenHtmlEditorFontSizeAttrs =
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline title (p: System.String) = "Title" => p

let radzenHtmlEditorFormatBlock = comp<Radzen.Blazor.RadzenHtmlEditorFormatBlock>

module radzenHtmlEditorFormatBlockAttrs =
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline title (p: System.String) = "Title" => p
    let inline normalText (p: System.String) = "NormalText" => p
    let inline heading1Text (p: System.String) = "Heading1Text" => p
    let inline heading2Text (p: System.String) = "Heading2Text" => p
    let inline heading3Text (p: System.String) = "Heading3Text" => p
    let inline heading4Text (p: System.String) = "Heading4Text" => p
    let inline heading5Text (p: System.String) = "Heading5Text" => p
    let inline heading6Text (p: System.String) = "Heading6Text" => p

let radzenHtmlEditorImage = comp<Radzen.Blazor.RadzenHtmlEditorImage>

module radzenHtmlEditorImageAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline selectText (p: System.String) = "SelectText" => p
    let inline uploadChooseText (p: System.String) = "UploadChooseText" => p
    let inline urlText (p: System.String) = "UrlText" => p
    let inline altText (p: System.String) = "AltText" => p
    let inline okText (p: System.String) = "OkText" => p
    let inline cancelText (p: System.String) = "CancelText" => p
    let inline widthText (p: System.String) = "WidthText" => p
    let inline heightText (p: System.String) = "HeightText" => p
    let inline showWidth (p: System.Boolean) = "ShowWidth" => p
    let inline showHeight (p: System.Boolean) = "ShowHeight" => p
    let inline showSrc (p: System.Boolean) = "ShowSrc" => p
    let inline showAlt (p: System.Boolean) = "ShowAlt" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorIndent = comp<Radzen.Blazor.RadzenHtmlEditorIndent>

module radzenHtmlEditorIndentAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorItalic = comp<Radzen.Blazor.RadzenHtmlEditorItalic>

module radzenHtmlEditorItalicAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorJustify = comp<Radzen.Blazor.RadzenHtmlEditorJustify>

module radzenHtmlEditorJustifyAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorLink = comp<Radzen.Blazor.RadzenHtmlEditorLink>

module radzenHtmlEditorLinkAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline urlText (p: System.String) = "UrlText" => p
    let inline openInNewWindowText (p: System.String) = "OpenInNewWindowText" => p
    let inline linkText (p: System.String) = "LinkText" => p
    let inline okText (p: System.String) = "OkText" => p
    let inline cancelText (p: System.String) = "CancelText" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorOrderedList = comp<Radzen.Blazor.RadzenHtmlEditorOrderedList>

module radzenHtmlEditorOrderedListAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorOutdent = comp<Radzen.Blazor.RadzenHtmlEditorOutdent>

module radzenHtmlEditorOutdentAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorRedo = comp<Radzen.Blazor.RadzenHtmlEditorRedo>

module radzenHtmlEditorRedoAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorRemoveFormat = comp<Radzen.Blazor.RadzenHtmlEditorRemoveFormat>

module radzenHtmlEditorRemoveFormatAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorSeparator = comp<Radzen.Blazor.RadzenHtmlEditorSeparator>
let radzenHtmlEditorSource = comp<Radzen.Blazor.RadzenHtmlEditorSource>

module radzenHtmlEditorSourceAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorStrikeThrough =
    comp<Radzen.Blazor.RadzenHtmlEditorStrikeThrough>

module radzenHtmlEditorStrikeThroughAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorSubscript = comp<Radzen.Blazor.RadzenHtmlEditorSubscript>

module radzenHtmlEditorSubscriptAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorSuperscript = comp<Radzen.Blazor.RadzenHtmlEditorSuperscript>

module radzenHtmlEditorSuperscriptAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorUnderline = comp<Radzen.Blazor.RadzenHtmlEditorUnderline>

module radzenHtmlEditorUnderlineAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorUndo = comp<Radzen.Blazor.RadzenHtmlEditorUndo>

module radzenHtmlEditorUndoAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorUnlink = comp<Radzen.Blazor.RadzenHtmlEditorUnlink>

module radzenHtmlEditorUnlinkAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenHtmlEditorUnorderedList =
    comp<Radzen.Blazor.RadzenHtmlEditorUnorderedList>

module radzenHtmlEditorUnorderedListAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p

let radzenIcon = comp<Radzen.Blazor.RadzenIcon>

module radzenIconAttrs =
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline iconStyle (p: System.Nullable<Radzen.IconStyle>) = "IconStyle" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenImage = comp<Radzen.Blazor.RadzenImage>

module radzenImageAttrs =
    let inline path (p: System.String) = "Path" => p
    let inline alternateText (p: System.String) = "AlternateText" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "Click" p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenLabel = comp<Radzen.Blazor.RadzenLabel>

module radzenLabelAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline text (p: System.String) = "Text" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenLayout = comp<Radzen.Blazor.RadzenLayout>

module radzenLayoutAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenLegend = comp<Radzen.Blazor.RadzenLegend>

module radzenLegendAttrs =
    let inline position (p: Radzen.Blazor.LegendPosition) = "Position" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenLengthValidator = comp<Radzen.Blazor.RadzenLengthValidator>

module radzenLengthValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline min (p: System.Nullable<System.Int32>) = "Min" => p
    let inline max (p: System.Nullable<System.Int32>) = "Max" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenLineSeries<'TItem67> = comp<Radzen.Blazor.RadzenLineSeries<'TItem67>>

module radzenLineSeriesAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline smooth (p: System.Boolean) = "Smooth" => p
    let inline interpolation (p: Radzen.Blazor.Interpolation) = "Interpolation" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem67> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem67 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem67> (p: System.Collections.Generic.IEnumerable<'TItem67>) = "Data" => p

let radzenLink = comp<Radzen.Blazor.RadzenLink>

module radzenLinkAttrs =
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline target (p: System.String) = "Target" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline text (p: System.String) = "Text" => p
    let inline path (p: System.String) = "Path" => p
    let inline ``match`` (p: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenListBox<'TValue68> = comp<Radzen.Blazor.RadzenListBox<'TValue68>>

module radzenListBoxAttrs =
    let inline selectAllText (p: System.String) = "SelectAllText" => p

    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline itemRender<'TValue68> (p: System.Action<Radzen.ListBoxItemRenderEventArgs<'TValue68>>) =
        "ItemRender" => p

    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline virtualizationOverscanCount (p: System.Int32) = "VirtualizationOverscanCount" => p
    let inline count (p: System.Int32) = "Count" => p
    let inline allowVirtualization (p: System.Boolean) = "AllowVirtualization" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline allowFiltering (p: System.Boolean) = "AllowFiltering" => p
    let inline filterAsYouType (p: System.Boolean) = "FilterAsYouType" => p
    let inline allowClear (p: System.Boolean) = "AllowClear" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline allowSelectAll (p: System.Boolean) = "AllowSelectAll" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p
    let inline removeChipTitle (p: System.String) = "RemoveChipTitle" => p
    let inline searchAriaLabel (p: System.String) = "SearchAriaLabel" => p
    let inline emptyAriaLabel (p: System.String) = "EmptyAriaLabel" => p

    let inline onSelectedItemChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "SelectedItemChanged" p

    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline filterDelay (p: System.Int32) = "FilterDelay" => p
    let inline selectedItem (p: System.Object) = "SelectedItem" => p
    let inline separator (p: System.String) = "Separator" => p
    let inline itemComparer (p: System.Collections.Generic.IEqualityComparer<System.Object>) = "ItemComparer" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline filterCaseSensitivity (p: Radzen.FilterCaseSensitivity) = "FilterCaseSensitivity" => p
    let inline filterOperator (p: Radzen.StringFilterOperator) = "FilterOperator" => p
    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Object> "Change" p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoadDataArgs> "LoadData" p

    let inline value (p: System.Object) = "Value" => p

    let inline onValueChanged<'TValue68> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue68> "ValueChanged" p

    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline searchText (p: System.String) = "SearchText" => p

    let inline onSearchTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "SearchTextChanged" p

    let inline valueExpression<'TValue68> (p: System.Linq.Expressions.Expression<System.Func<'TValue68>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenLogin = comp<Radzen.Blazor.RadzenLogin>

module radzenLoginAttrs =
    let inline autoComplete (p: System.Boolean) = "AutoComplete" => p
    let inline userNameAutoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "UserNameAutoCompleteType" => p
    let inline passwordAutoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "PasswordAutoCompleteType" => p
    let inline formFieldVariant (p: System.Nullable<Radzen.Variant>) = "FormFieldVariant" => p
    let inline username (p: System.String) = "Username" => p
    let inline password (p: System.String) = "Password" => p
    let inline rememberMe (p: System.Boolean) = "RememberMe" => p

    let inline onLogin ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LoginArgs> "Login" p

    let inline register (p: Microsoft.AspNetCore.Components.EventCallback) = "Register" => p

    let inline onResetPassword ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ResetPassword" p

    let inline allowRegister (p: System.Boolean) = "AllowRegister" => p
    let inline allowRememberMe (p: System.Boolean) = "AllowRememberMe" => p
    let inline allowResetPassword (p: System.Boolean) = "AllowResetPassword" => p
    let inline showLoginButton (p: System.Boolean) = "ShowLoginButton" => p
    let inline loginText (p: System.String) = "LoginText" => p
    let inline registerText (p: System.String) = "RegisterText" => p
    let inline rememberMeText (p: System.String) = "RememberMeText" => p
    let inline registerMessageText (p: System.String) = "RegisterMessageText" => p
    let inline resetPasswordText (p: System.String) = "ResetPasswordText" => p
    let inline userText (p: System.String) = "UserText" => p
    let inline userRequired (p: System.String) = "UserRequired" => p
    let inline passwordText (p: System.String) = "PasswordText" => p
    let inline passwordRequired (p: System.String) = "PasswordRequired" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenMarkdown = comp<Radzen.Blazor.RadzenMarkdown>

module radzenMarkdownAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline text (p: System.String) = "Text" => p
    let inline autoLinkHeadingDepth (p: System.Int32) = "AutoLinkHeadingDepth" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenMarkers = comp<Radzen.Blazor.RadzenMarkers>

module radzenMarkersAttrs =
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline size (p: System.Double) = "Size" => p
    let inline markerType (p: Radzen.Blazor.MarkerType) = "MarkerType" => p

let radzenMask = comp<Radzen.Blazor.RadzenMask>

module radzenMaskAttrs =
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline maxLength (p: System.Nullable<System.Int64>) = "MaxLength" => p
    let inline mask (p: System.String) = "Mask" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline characterPattern (p: System.String) = "CharacterPattern" => p
    let inline autoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "AutoCompleteType" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenMediaQuery = comp<Radzen.Blazor.RadzenMediaQuery>

module radzenMediaQueryAttrs =
    let inline query (p: System.String) = "Query" => p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "Change" p

let radzenMenu = comp<Radzen.Blazor.RadzenMenu>

module radzenMenuAttrs =
    let inline responsive (p: System.Boolean) = "Responsive" => p
    let inline clickToOpen (p: System.Boolean) = "ClickToOpen" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.MenuItemEventArgs> "Click" p

    let inline toggleAriaLabel (p: System.String) = "ToggleAriaLabel" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenMenuItem = comp<Radzen.Blazor.RadzenMenuItem>

module radzenMenuItemAttrs =
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline target (p: System.String) = "Target" => p
    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.Object) = "Value" => p
    let inline path (p: System.String) = "Path" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline imageStyle (p: System.String) = "ImageStyle" => p
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline ``match`` (p: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => p
    let inline template p = attr.fragment "Template" p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.MenuItemEventArgs> "Click" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenMonthView = comp<Radzen.Blazor.RadzenMonthView>

module radzenMonthViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline maxAppointmentsInSlot (p: System.Nullable<System.Int32>) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p

let radzenMultiDayView = comp<Radzen.Blazor.RadzenMultiDayView>

module radzenMultiDayViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline headerFormat (p: System.String) = "HeaderFormat" => p
    let inline startTime (p: System.TimeSpan) = "StartTime" => p
    let inline endTime (p: System.TimeSpan) = "EndTime" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p
    let inline numberOfDays (p: System.Int32) = "NumberOfDays" => p
    let inline advanceDays (p: System.Int32) = "AdvanceDays" => p

let radzenNumeric<'TValue69> = comp<Radzen.Blazor.RadzenNumeric<'TValue69>>

module radzenNumericAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline value (p: 'TValue69) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline step (p: System.String) = "Step" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline showUpDown (p: System.Boolean) = "ShowUpDown" => p
    let inline textAlign (p: Radzen.TextAlign) = "TextAlign" => p
    let inline convertValue<'TValue69> (p: System.Func<System.String, 'TValue69>) = "ConvertValue" => p
    let inline min (p: System.Nullable<System.Decimal>) = "Min" => p
    let inline max (p: System.Nullable<System.Decimal>) = "Max" => p
    let inline upAriaLabel (p: System.String) = "UpAriaLabel" => p
    let inline downAriaLabel (p: System.String) = "DownAriaLabel" => p
    let inline autoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "AutoCompleteType" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue69> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue69> "ValueChanged" p

    let inline onChange<'TValue69> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TValue69> "Change" p

    let inline valueExpression<'TValue69> (p: System.Linq.Expressions.Expression<System.Func<'TValue69>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenNumericRangeValidator = comp<Radzen.Blazor.RadzenNumericRangeValidator>

module radzenNumericRangeValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline min (p: System.IComparable) = "Min" => p
    let inline max (p: System.IComparable) = "Max" => p
    let inline allowNull (p: System.Boolean) = "AllowNull" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPager = comp<Radzen.Blazor.RadzenPager>

module radzenPagerAttrs =
    let inline firstPageTitle (p: System.String) = "FirstPageTitle" => p
    let inline firstPageAriaLabel (p: System.String) = "FirstPageAriaLabel" => p
    let inline prevPageLabel (p: System.String) = "PrevPageLabel" => p
    let inline prevPageTitle (p: System.String) = "PrevPageTitle" => p
    let inline prevPageAriaLabel (p: System.String) = "PrevPageAriaLabel" => p
    let inline lastPageTitle (p: System.String) = "LastPageTitle" => p
    let inline lastPageAriaLabel (p: System.String) = "LastPageAriaLabel" => p
    let inline nextPageLabel (p: System.String) = "NextPageLabel" => p
    let inline nextPageTitle (p: System.String) = "NextPageTitle" => p
    let inline nextPageAriaLabel (p: System.String) = "NextPageAriaLabel" => p
    let inline pageTitleFormat (p: System.String) = "PageTitleFormat" => p
    let inline pageAriaLabelFormat (p: System.String) = "PageAriaLabelFormat" => p
    let inline horizontalAlign (p: Radzen.HorizontalAlign) = "HorizontalAlign" => p
    let inline density (p: Radzen.Density) = "Density" => p
    let inline pageSize (p: System.Int32) = "PageSize" => p

    let inline onPageSizeChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "PageSizeChanged" p

    let inline pageSizeOptions (p: System.Collections.Generic.IEnumerable<System.Int32>) = "PageSizeOptions" => p
    let inline pageSizeText (p: System.String) = "PageSizeText" => p
    let inline showPagingSummary (p: System.Boolean) = "ShowPagingSummary" => p
    let inline pagingSummaryFormat (p: System.String) = "PagingSummaryFormat" => p
    let inline pageNumbersCount (p: System.Int32) = "PageNumbersCount" => p
    let inline count (p: System.Int32) = "Count" => p
    let inline alwaysVisible (p: System.Boolean) = "AlwaysVisible" => p

    let inline onPageChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.PagerEventArgs> "PageChanged" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPanel = comp<Radzen.Blazor.RadzenPanel>

module radzenPanelAttrs =
    let inline allowCollapse (p: System.Boolean) = "AllowCollapse" => p
    let inline collapsed (p: System.Boolean) = "Collapsed" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline text (p: System.String) = "Text" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline summaryTemplate p = attr.fragment "SummaryTemplate" p
    let inline footerTemplate p = attr.fragment "FooterTemplate" p
    let inline expand (p: Microsoft.AspNetCore.Components.EventCallback) = "Expand" => p
    let inline collapse (p: Microsoft.AspNetCore.Components.EventCallback) = "Collapse" => p
    let inline expandTitle (p: System.String) = "ExpandTitle" => p
    let inline collapseTitle (p: System.String) = "CollapseTitle" => p
    let inline expandAriaLabel (p: System.String) = "ExpandAriaLabel" => p
    let inline collapseAriaLabel (p: System.String) = "CollapseAriaLabel" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPanelMenu = comp<Radzen.Blazor.RadzenPanelMenu>

module radzenPanelMenuAttrs =
    let inline multiple (p: System.Boolean) = "Multiple" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.MenuItemEventArgs> "Click" p

    let inline ``match`` (p: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => p
    let inline displayStyle (p: Radzen.MenuItemDisplayStyle) = "DisplayStyle" => p
    let inline showArrow (p: System.Boolean) = "ShowArrow" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPanelMenuItem = comp<Radzen.Blazor.RadzenPanelMenuItem>

module radzenPanelMenuItemAttrs =
    let inline target (p: System.String) = "Target" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.Object) = "Value" => p
    let inline path (p: System.String) = "Path" => p
    let inline ``match`` (p: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline template p = attr.fragment "Template" p
    let inline expanded (p: System.Boolean) = "Expanded" => p
    let inline selected (p: System.Boolean) = "Selected" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.MenuItemEventArgs> "Click" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPassword = comp<Radzen.Blazor.RadzenPassword>

module radzenPasswordAttrs =
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline autoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "AutoCompleteType" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPickList<'TItem70> = comp<Radzen.Blazor.RadzenPickList<'TItem70>>

module radzenPickListAttrs =
    let inline allowMoveAll (p: System.Boolean) = "AllowMoveAll" => p
    let inline allowMoveAllSourceToTarget (p: System.Boolean) = "AllowMoveAllSourceToTarget" => p
    let inline allowMoveAllTargetToSource (p: System.Boolean) = "AllowMoveAllTargetToSource" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline allowSelectAll (p: System.Boolean) = "AllowSelectAll" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline sourceHeader p = attr.fragment "SourceHeader" p
    let inline targetHeader p = attr.fragment "TargetHeader" p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline sourcePlaceholder (p: System.String) = "SourcePlaceholder" => p
    let inline targetPlaceholder (p: System.String) = "TargetPlaceholder" => p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p

    let inline template<'TItem70> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem70 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline selectAllText (p: System.String) = "SelectAllText" => p
    let inline itemRender<'TItem70> (p: System.Action<Radzen.PickListItemRenderEventArgs<'TItem70>>) = "ItemRender" => p
    let inline allowFiltering (p: System.Boolean) = "AllowFiltering" => p
    let inline showHeader (p: System.Boolean) = "ShowHeader" => p
    let inline buttonGap (p: System.String) = "ButtonGap" => p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline buttonJustifyContent (p: Radzen.JustifyContent) = "ButtonJustifyContent" => p
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline buttonVariant (p: Radzen.Variant) = "ButtonVariant" => p
    let inline buttonShade (p: Radzen.Shade) = "ButtonShade" => p
    let inline buttonSize (p: Radzen.ButtonSize) = "ButtonSize" => p
    let inline sourceToTargetTitle (p: System.String) = "SourceToTargetTitle" => p
    let inline selectedSourceToTargetTitle (p: System.String) = "SelectedSourceToTargetTitle" => p
    let inline targetToSourceTitle (p: System.String) = "TargetToSourceTitle" => p
    let inline selectedTargetToSourceTitle (p: System.String) = "SelectedTargetToSourceTitle" => p
    let inline sourceToTargetIcon (p: System.String) = "SourceToTargetIcon" => p
    let inline selectedSourceToTargetIcon (p: System.String) = "SelectedSourceToTargetIcon" => p
    let inline targetToSourceIcon (p: System.String) = "TargetToSourceIcon" => p
    let inline selectedTargetToSourceIcon (p: System.String) = "SelectedTargetToSourceIcon" => p
    let inline source<'TItem70> (p: System.Collections.Generic.IEnumerable<'TItem70>) = "Source" => p

    let inline onSourceChanged<'TItem70> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<'TItem70>> "SourceChanged" p

    let inline target<'TItem70> (p: System.Collections.Generic.IEnumerable<'TItem70>) = "Target" => p

    let inline onTargetChanged<'TItem70> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<'TItem70>> "TargetChanged" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenPieSeries<'TItem71> = comp<Radzen.Blazor.RadzenPieSeries<'TItem71>>

module radzenPieSeriesAttrs =
    let inline x (p: System.Nullable<System.Double>) = "X" => p
    let inline y (p: System.Nullable<System.Double>) = "Y" => p
    let inline radius (p: System.Nullable<System.Double>) = "Radius" => p
    let inline fills (p: System.Collections.Generic.IEnumerable<System.String>) = "Fills" => p
    let inline strokes (p: System.Collections.Generic.IEnumerable<System.String>) = "Strokes" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline totalAngle (p: System.Double) = "TotalAngle" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem71> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem71 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem71> (p: System.Collections.Generic.IEnumerable<'TItem71>) = "Data" => p

let radzenProfileMenu = comp<Radzen.Blazor.RadzenProfileMenu>

module radzenProfileMenuAttrs =
    let inline template p = attr.fragment "Template" p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.RadzenProfileMenuItem> "Click" p

    let inline showIcon (p: System.Boolean) = "ShowIcon" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenProfileMenuItem = comp<Radzen.Blazor.RadzenProfileMenuItem>

module radzenProfileMenuItemAttrs =
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline target (p: System.String) = "Target" => p
    let inline path (p: System.String) = "Path" => p
    let inline ``match`` (p: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.String) = "Value" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenProgressBar = comp<Radzen.Blazor.RadzenProgressBar>

module radzenProgressBarAttrs =
    let inline template p = attr.fragment "Template" p
    let inline mode (p: Radzen.ProgressBarMode) = "Mode" => p
    let inline unit (p: System.String) = "Unit" => p
    let inline value (p: System.Double) = "Value" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline showValue (p: System.Boolean) = "ShowValue" => p
    let inline valueChanged (p: System.Action<System.Double>) = "ValueChanged" => p
    let inline progressBarStyle (p: Radzen.ProgressBarStyle) = "ProgressBarStyle" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenProgressBarCircular = comp<Radzen.Blazor.RadzenProgressBarCircular>

module radzenProgressBarCircularAttrs =
    let inline size (p: Radzen.ProgressBarCircularSize) = "Size" => p
    let inline template p = attr.fragment "Template" p
    let inline mode (p: Radzen.ProgressBarMode) = "Mode" => p
    let inline unit (p: System.String) = "Unit" => p
    let inline value (p: System.Double) = "Value" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline showValue (p: System.Boolean) = "ShowValue" => p
    let inline valueChanged (p: System.Action<System.Double>) = "ValueChanged" => p
    let inline progressBarStyle (p: Radzen.ProgressBarStyle) = "ProgressBarStyle" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenRadialGaugeScale = comp<Radzen.Blazor.RadzenRadialGaugeScale>

module radzenRadialGaugeScaleAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline tickLength (p: System.Double) = "TickLength" => p
    let inline minorTickLength (p: System.Double) = "MinorTickLength" => p
    let inline tickLabelOffset (p: System.Double) = "TickLabelOffset" => p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline formatter (p: System.Func<System.Double, System.String>) = "Formatter" => p
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline tickPosition (p: Radzen.Blazor.GaugeTickPosition) = "TickPosition" => p
    let inline endAngle (p: System.Double) = "EndAngle" => p
    let inline radius (p: System.Double) = "Radius" => p
    let inline showFirstTick (p: System.Boolean) = "ShowFirstTick" => p
    let inline showLastTick (p: System.Boolean) = "ShowLastTick" => p
    let inline showTickLabels (p: System.Boolean) = "ShowTickLabels" => p
    let inline x (p: System.Double) = "X" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline step (p: System.Double) = "Step" => p
    let inline minorStep (p: System.Double) = "MinorStep" => p
    let inline y (p: System.Double) = "Y" => p
    let inline margin (p: System.Double) = "Margin" => p

let radzenRadialGaugeScalePointer =
    comp<Radzen.Blazor.RadzenRadialGaugeScalePointer>

module radzenRadialGaugeScalePointerAttrs =
    let inline fill (p: System.String) = "Fill" => p
    let inline value (p: System.Double) = "Value" => p
    let inline showValue (p: System.Boolean) = "ShowValue" => p
    let inline radius (p: System.Double) = "Radius" => p
    let inline width (p: System.Nullable<System.Double>) = "Width" => p
    let inline length (p: System.Double) = "Length" => p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p

    let inline template
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenRadialGaugeScalePointer -> Bolero.Node)
        =
        attr.fragmentWith "Template" p

let radzenRadialGaugeScaleRange = comp<Radzen.Blazor.RadzenRadialGaugeScaleRange>

module radzenRadialGaugeScaleRangeAttrs =
    let inline from (p: System.Double) = "From" => p
    let inline ``to`` (p: System.Double) = "To" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline height (p: System.Double) = "Height" => p

let radzenRadioButtonList<'TValue72> =
    comp<Radzen.Blazor.RadzenRadioButtonList<'TValue72>>

module radzenRadioButtonListAttrs =
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline disabledProperty (p: System.String) = "DisabledProperty" => p
    let inline visibleProperty (p: System.String) = "VisibleProperty" => p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline items p = attr.fragment "Items" p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue72> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue72> "ValueChanged" p

    let inline value (p: 'TValue72) = "Value" => p
    let inline onChange<'TValue72> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TValue72> "Change" p

    let inline valueExpression<'TValue72> (p: System.Linq.Expressions.Expression<System.Func<'TValue72>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenRadioButtonListItem<'TValue73> =
    comp<Radzen.Blazor.RadzenRadioButtonListItem<'TValue73>>

module radzenRadioButtonListItemAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline text (p: System.String) = "Text" => p

    let inline template<'TValue73>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenRadioButtonListItem<'TValue73> -> Bolero.Node)
        =
        attr.fragmentWith "Template" p

    let inline value (p: 'TValue73) = "Value" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenRating = comp<Radzen.Blazor.RadzenRating>

module radzenRatingAttrs =
    let inline stars (p: System.Int32) = "Stars" => p
    let inline clearAriaLabel (p: System.String) = "ClearAriaLabel" => p
    let inline rateAriaLabel (p: System.String) = "RateAriaLabel" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "ValueChanged" p

    let inline value (p: System.Int32) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Int32> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.Int32>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenRegexValidator = comp<Radzen.Blazor.RadzenRegexValidator>

module radzenRegexValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenRequiredValidator = comp<Radzen.Blazor.RadzenRequiredValidator>

module radzenRequiredValidatorAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline defaultValue (p: System.Object) = "DefaultValue" => p
    let inline ``component`` (p: System.String) = "Component" => p
    let inline popup (p: System.Boolean) = "Popup" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenRow = comp<Radzen.Blazor.RadzenRow>

module radzenRowAttrs =
    let inline gap (p: System.String) = "Gap" => p
    let inline rowGap (p: System.String) = "RowGap" => p
    let inline justifyContent (p: Radzen.JustifyContent) = "JustifyContent" => p
    let inline alignItems (p: Radzen.AlignItems) = "AlignItems" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenScheduler<'TItem74> = comp<Radzen.Blazor.RadzenScheduler<'TItem74>>

module radzenSchedulerAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline template<'TItem74> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem74 -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline navigationTemplate p = attr.fragment "NavigationTemplate" p
    let inline data<'TItem74> (p: System.Collections.Generic.IEnumerable<'TItem74>) = "Data" => p
    let inline startProperty (p: System.String) = "StartProperty" => p
    let inline endProperty (p: System.String) = "EndProperty" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p
    let inline todayText (p: System.String) = "TodayText" => p
    let inline nextText (p: System.String) = "NextText" => p
    let inline prevText (p: System.String) = "PrevText" => p
    let inline date (p: System.DateTime) = "Date" => p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline showHeader (p: System.Boolean) = "ShowHeader" => p

    let inline onSlotSelect ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerSlotSelectEventArgs> "SlotSelect" p

    let inline onTodaySelect ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerTodaySelectEventArgs> "TodaySelect" p

    let inline onMonthSelect ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerMonthSelectEventArgs> "MonthSelect" p

    let inline onDaySelect ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerDaySelectEventArgs> "DaySelect" p

    let inline onAppointmentSelect<'TItem74> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentSelectEventArgs<'TItem74>> "AppointmentSelect" p

    let inline onAppointmentMouseEnter<'TItem74> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.SchedulerAppointmentMouseEventArgs<'TItem74>> "AppointmentMouseEnter" p

    let inline onAppointmentMouseLeave<'TItem74> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.SchedulerAppointmentMouseEventArgs<'TItem74>> "AppointmentMouseLeave" p

    let inline onMoreSelect ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerMoreSelectEventArgs> "MoreSelect" p

    let inline appointmentRender<'TItem74> (p: System.Action<Radzen.SchedulerAppointmentRenderEventArgs<'TItem74>>) =
        "AppointmentRender" => p

    let inline slotRender (p: System.Action<Radzen.SchedulerSlotRenderEventArgs>) = "SlotRender" => p

    let inline onLoadData ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerLoadDataEventArgs> "LoadData" p

    let inline onAppointmentMove ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentMoveEventArgs> "AppointmentMove" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSecurityCode = comp<Radzen.Blazor.RadzenSecurityCode>

module radzenSecurityCodeAttrs =
    let inline count (p: System.Int32) = "Count" => p
    let inline ``type`` (p: Radzen.SecurityCodeType) = "Type" => p
    let inline gap (p: System.String) = "Gap" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSelectBar<'TValue75> = comp<Radzen.Blazor.RadzenSelectBar<'TValue75>>

module radzenSelectBarAttrs =
    let inline size (p: Radzen.ButtonSize) = "Size" => p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline items p = attr.fragment "Items" p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue75> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue75> "ValueChanged" p

    let inline value (p: 'TValue75) = "Value" => p
    let inline onChange<'TValue75> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TValue75> "Change" p

    let inline valueExpression<'TValue75> (p: System.Linq.Expressions.Expression<System.Func<'TValue75>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSelectBarItem = comp<Radzen.Blazor.RadzenSelectBarItem>

module radzenSelectBarItemAttrs =
    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenSelectBarItem -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline imageStyle (p: System.String) = "ImageStyle" => p
    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.Object) = "Value" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesAnnotation<'TItem76> =
    comp<Radzen.Blazor.RadzenSeriesAnnotation<'TItem76>>

module radzenSeriesAnnotationAttrs =
    let inline data (p: 'TItem76) = "Data" => p
    let inline text (p: System.String) = "Text" => p
    let inline offsetX (p: System.Double) = "OffsetX" => p
    let inline offsetY (p: System.Double) = "OffsetY" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesDataLabels = comp<Radzen.Blazor.RadzenSeriesDataLabels>

module radzenSeriesDataLabelsAttrs =
    let inline offsetX (p: System.Double) = "OffsetX" => p
    let inline offsetY (p: System.Double) = "OffsetY" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesMeanLine = comp<Radzen.Blazor.RadzenSeriesMeanLine>

module radzenSeriesMeanLineAttrs =
    let inline tooltipTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Double -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesMedianLine = comp<Radzen.Blazor.RadzenSeriesMedianLine>

module radzenSeriesMedianLineAttrs =
    let inline tooltipTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Double -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesModeLine = comp<Radzen.Blazor.RadzenSeriesModeLine>

module radzenSeriesModeLineAttrs =
    let inline tooltipTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Double -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesTrendLine = comp<Radzen.Blazor.RadzenSeriesTrendLine>

module radzenSeriesTrendLineAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSidebar = comp<Radzen.Blazor.RadzenSidebar>

module radzenSidebarAttrs =
    let inline style (p: System.String) = "Style" => p
    let inline responsive (p: System.Boolean) = "Responsive" => p
    let inline expanded (p: System.Boolean) = "Expanded" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSidebarToggle = comp<Radzen.Blazor.RadzenSidebarToggle>

module radzenSidebarToggleAttrs =
    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.EventArgs> "Click" p

    let inline icon (p: System.String) = "Icon" => p
    let inline toggleAriaLabel (p: System.String) = "ToggleAriaLabel" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSlider<'TValue77> = comp<Radzen.Blazor.RadzenSlider<'TValue77>>

module radzenSliderAttrs =
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline value (p: 'TValue77) = "Value" => p
    let inline step (p: System.String) = "Step" => p
    let inline range (p: System.Boolean) = "Range" => p
    let inline min (p: System.Decimal) = "Min" => p
    let inline max (p: System.Decimal) = "Max" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged<'TValue77> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue77> "ValueChanged" p

    let inline onChange<'TValue77> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TValue77> "Change" p

    let inline valueExpression<'TValue77> (p: System.Linq.Expressions.Expression<System.Func<'TValue77>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSparkline = comp<Radzen.Blazor.RadzenSparkline>

module radzenSparklineAttrs =
    let inline colorScheme (p: Radzen.Blazor.ColorScheme) = "ColorScheme" => p

    let inline onSeriesClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SeriesClickEventArgs> "SeriesClick" p

    let inline onLegendClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.LegendClickEventArgs> "LegendClick" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline clickTolerance (p: System.Int32) = "ClickTolerance" => p
    let inline tooltipTolerance (p: System.Int32) = "TooltipTolerance" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSpeechToTextButton = comp<Radzen.Blazor.RadzenSpeechToTextButton>

module radzenSpeechToTextButtonAttrs =
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline stopIcon (p: System.String) = "StopIcon" => p
    let inline title (p: System.String) = "Title" => p
    let inline stopTitle (p: System.String) = "StopTitle" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p
    let inline language (p: System.String) = "Language" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSplitButton = comp<Radzen.Blazor.RadzenSplitButton>

module radzenSplitButtonAttrs =
    let inline buttonContent p = attr.fragment "ButtonContent" p
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline text (p: System.String) = "Text" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline shade (p: Radzen.Shade) = "Shade" => p
    let inline size (p: Radzen.ButtonSize) = "Size" => p
    let inline isBusy (p: System.Boolean) = "IsBusy" => p
    let inline busyText (p: System.String) = "BusyText" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline alwaysOpenPopup (p: System.Boolean) = "AlwaysOpenPopup" => p
    let inline openAriaLabel (p: System.String) = "OpenAriaLabel" => p
    let inline dropDownIcon (p: System.String) = "DropDownIcon" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.RadzenSplitButtonItem> "Click" p

    let inline buttonAriaLabel (p: System.String) = "ButtonAriaLabel" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSplitButtonItem = comp<Radzen.Blazor.RadzenSplitButtonItem>

module radzenSplitButtonItemAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline value (p: System.String) = "Value" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSplitter = comp<Radzen.Blazor.RadzenSplitter>

module radzenSplitterAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p

    let inline onCollapse ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.RadzenSplitterEventArgs> "Collapse" p

    let inline onExpand ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.RadzenSplitterEventArgs> "Expand" p

    let inline onResize ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.RadzenSplitterResizeEventArgs> "Resize" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSplitterPane = comp<Radzen.Blazor.RadzenSplitterPane>

module radzenSplitterPaneAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline collapsible (p: System.Boolean) = "Collapsible" => p
    let inline collapsed (p: System.Boolean) = "Collapsed" => p
    let inline resizable (p: System.Boolean) = "Resizable" => p
    let inline max (p: System.String) = "Max" => p
    let inline min (p: System.String) = "Min" => p
    let inline size (p: System.String) = "Size" => p
    let inline barVisible (p: System.Boolean) = "BarVisible" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSSRSViewer = comp<Radzen.Blazor.RadzenSSRSViewer>

module radzenSSRSViewerAttrs =
    let inline useProxy (p: System.Boolean) = "UseProxy" => p
    let inline reportServer (p: System.String) = "ReportServer" => p
    let inline localServer (p: System.String) = "LocalServer" => p
    let inline reportName (p: System.String) = "ReportName" => p
    let inline parameters p = attr.fragment "Parameters" p

    let inline onLoad ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.ProgressEventArgs> "Load" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSSRSViewerParameter = comp<Radzen.Blazor.RadzenSSRSViewerParameter>

module radzenSSRSViewerParameterAttrs =
    let inline parameterName (p: System.String) = "ParameterName" => p
    let inline value (p: System.String) = "Value" => p

let radzenStack = comp<Radzen.Blazor.RadzenStack>

module radzenStackAttrs =
    let inline wrap (p: Radzen.FlexWrap) = "Wrap" => p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline gap (p: System.String) = "Gap" => p
    let inline reverse (p: System.Boolean) = "Reverse" => p
    let inline justifyContent (p: Radzen.JustifyContent) = "JustifyContent" => p
    let inline alignItems (p: Radzen.AlignItems) = "AlignItems" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenStackedAreaSeries<'TItem78> =
    comp<Radzen.Blazor.RadzenStackedAreaSeries<'TItem78>>

module radzenStackedAreaSeriesAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline smooth (p: System.Boolean) = "Smooth" => p
    let inline interpolation (p: Radzen.Blazor.Interpolation) = "Interpolation" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem78> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem78 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem78> (p: System.Collections.Generic.IEnumerable<'TItem78>) = "Data" => p

let radzenStackedBarSeries<'TItem79> =
    comp<Radzen.Blazor.RadzenStackedBarSeries<'TItem79>>

module radzenStackedBarSeriesAttrs =
    let inline fill (p: System.String) = "Fill" => p
    let inline fills (p: System.Collections.Generic.IEnumerable<System.String>) = "Fills" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokes (p: System.Collections.Generic.IEnumerable<System.String>) = "Strokes" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline fillRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "FillRange" => p
    let inline strokeRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "StrokeRange" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem79> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem79 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem79> (p: System.Collections.Generic.IEnumerable<'TItem79>) = "Data" => p

let radzenStackedColumnSeries<'TItem80> =
    comp<Radzen.Blazor.RadzenStackedColumnSeries<'TItem80>>

module radzenStackedColumnSeriesAttrs =
    let inline fill (p: System.String) = "Fill" => p
    let inline fills (p: System.Collections.Generic.IEnumerable<System.String>) = "Fills" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokes (p: System.Collections.Generic.IEnumerable<System.String>) = "Strokes" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline fillRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "FillRange" => p
    let inline strokeRange (p: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = "StrokeRange" => p
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline tooltipTemplate<'TItem80> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TItem80 -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline categoryProperty (p: System.String) = "CategoryProperty" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline valueProperty (p: System.String) = "ValueProperty" => p
    let inline renderingOrder (p: System.Int32) = "RenderingOrder" => p
    let inline data<'TItem80> (p: System.Collections.Generic.IEnumerable<'TItem80>) = "Data" => p

let radzenSteps = comp<Radzen.Blazor.RadzenSteps>

module radzenStepsAttrs =
    let inline showStepsButtons (p: System.Boolean) = "ShowStepsButtons" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Int32> "Change" p

    let inline onCanChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.StepsCanChangeEventArgs> "CanChange" p

    let inline nextText (p: System.String) = "NextText" => p
    let inline previousText (p: System.String) = "PreviousText" => p
    let inline nextTitle (p: System.String) = "NextTitle" => p
    let inline previousTitle (p: System.String) = "PreviousTitle" => p
    let inline steps p = attr.fragment "Steps" p
    let inline allowStepSelect (p: System.Boolean) = "AllowStepSelect" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenStepsItem = comp<Radzen.Blazor.RadzenStepsItem>

module radzenStepsItemAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline nextText (p: System.String) = "NextText" => p
    let inline previousText (p: System.String) = "PreviousText" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenStepsItem -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline selected (p: System.Boolean) = "Selected" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p

let radzenSwitch = comp<Radzen.Blazor.RadzenSwitch>

module radzenSwitchAttrs =
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p

    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ValueChanged" p

    let inline value (p: System.Boolean) = "Value" => p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTable = comp<Radzen.Blazor.RadzenTable>

module radzenTableAttrs =
    let inline gridLines (p: Radzen.DataGridGridLines) = "GridLines" => p
    let inline allowAlternatingRows (p: System.Boolean) = "AllowAlternatingRows" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTableBody = comp<Radzen.Blazor.RadzenTableBody>

module radzenTableBodyAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTableCell = comp<Radzen.Blazor.RadzenTableCell>

module radzenTableCellAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTableHeader = comp<Radzen.Blazor.RadzenTableHeader>

module radzenTableHeaderAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTableHeaderCell = comp<Radzen.Blazor.RadzenTableHeaderCell>

module radzenTableHeaderCellAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTableHeaderRow = comp<Radzen.Blazor.RadzenTableHeaderRow>

module radzenTableHeaderRowAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTableRow = comp<Radzen.Blazor.RadzenTableRow>

module radzenTableRowAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTabs = comp<Radzen.Blazor.RadzenTabs>

module radzenTabsAttrs =
    let inline renderMode (p: Radzen.TabRenderMode) = "RenderMode" => p
    let inline tabPosition (p: Radzen.TabPosition) = "TabPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Int32> "Change" p
    let inline tabs p = attr.fragment "Tabs" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTabsItem = comp<Radzen.Blazor.RadzenTabsItem>

module radzenTabsItemAttrs =
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline text (p: System.String) = "Text" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenTabsItem -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline selected (p: System.Boolean) = "Selected" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p

let radzenTemplateForm<'TItem81> = comp<Radzen.Blazor.RadzenTemplateForm<'TItem81>>

module radzenTemplateFormAttrs =
    let inline data (p: 'TItem81) = "Data" => p

    let inline childContent
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Microsoft.AspNetCore.Components.Forms.EditContext -> Bolero.Node)
        =
        attr.fragmentWith "ChildContent" p

    let inline onSubmit<'TItem81> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'TItem81> "Submit" p

    let inline onOnInvalidSubmit ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.FormInvalidSubmitEventArgs> "OnInvalidSubmit" p

    let inline onInvalidSubmit ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.FormInvalidSubmitEventArgs> "InvalidSubmit" p

    let inline method (p: System.String) = "Method" => p
    let inline action (p: System.String) = "Action" => p
    let inline editContext (p: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenText = comp<Radzen.Blazor.RadzenText>

module radzenTextAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline textStyle (p: Radzen.Blazor.TextStyle) = "TextStyle" => p
    let inline textAlign (p: Radzen.TextAlign) = "TextAlign" => p
    let inline tagName (p: Radzen.Blazor.TagName) = "TagName" => p
    let inline anchor (p: System.String) = "Anchor" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTextArea = comp<Radzen.Blazor.RadzenTextArea>

module radzenTextAreaAttrs =
    let inline maxLength (p: System.Nullable<System.Int64>) = "MaxLength" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline rows (p: System.Int32) = "Rows" => p
    let inline cols (p: System.Int32) = "Cols" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTextBox = comp<Radzen.Blazor.RadzenTextBox>

module radzenTextBoxAttrs =
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline maxLength (p: System.Nullable<System.Int64>) = "MaxLength" => p
    let inline trim (p: System.Boolean) = "Trim" => p
    let inline autoCompleteType (p: Radzen.Blazor.AutoCompleteType) = "AutoCompleteType" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.String>>) =
        "ValueExpression" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTheme = comp<Radzen.Blazor.RadzenTheme>

module radzenThemeAttrs =
    let inline theme (p: System.String) = "Theme" => p
    let inline wcag (p: System.Boolean) = "Wcag" => p

let radzenTicks = comp<Radzen.Blazor.RadzenTicks>

module radzenTicksAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.TickTemplateContext -> Bolero.Node) =
        attr.fragmentWith "Template" p

let radzenTimeline = comp<Radzen.Blazor.RadzenTimeline>

module radzenTimelineAttrs =
    let inline items p = attr.fragment "Items" p
    let inline orientation (p: Radzen.Orientation) = "Orientation" => p
    let inline linePosition (p: Radzen.LinePosition) = "LinePosition" => p
    let inline reverse (p: System.Boolean) = "Reverse" => p
    let inline alignItems (p: Radzen.AlignItems) = "AlignItems" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTimelineItem = comp<Radzen.Blazor.RadzenTimelineItem>

module radzenTimelineItemAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline text (p: System.String) = "Text" => p
    let inline labelContent p = attr.fragment "LabelContent" p
    let inline label (p: System.String) = "Label" => p
    let inline pointContent p = attr.fragment "PointContent" p
    let inline pointSize (p: Radzen.PointSize) = "PointSize" => p
    let inline pointStyle (p: Radzen.PointStyle) = "PointStyle" => p
    let inline pointVariant (p: Radzen.Variant) = "PointVariant" => p
    let inline pointShadow (p: System.Int32) = "PointShadow" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTimeSpanPicker<'TValue82> =
    comp<Radzen.Blazor.RadzenTimeSpanPicker<'TValue82>>

module radzenTimeSpanPickerAttrs =
    let inline value (p: 'TValue82) = "Value" => p
    let inline min (p: System.TimeSpan) = "Min" => p
    let inline max (p: System.TimeSpan) = "Max" => p
    let inline allowClear (p: System.Boolean) = "AllowClear" => p
    let inline allowInput (p: System.Boolean) = "AllowInput" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline showPopupButton (p: System.Boolean) = "ShowPopupButton" => p
    let inline popupButtonClass (p: System.String) = "PopupButtonClass" => p

    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline inputClass (p: System.String) = "InputClass" => p
    let inline name (p: System.String) = "Name" => p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline timeSpanFormat (p: System.String) = "TimeSpanFormat" => p
    let inline parseInput (p: System.Func<System.String, System.Nullable<System.TimeSpan>>) = "ParseInput" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline togglePopupAriaLabel (p: System.String) = "TogglePopupAriaLabel" => p
    let inline popupRenderMode (p: Radzen.PopupRenderMode) = "PopupRenderMode" => p
    let inline ``inline`` (p: System.Boolean) = "Inline" => p
    let inline showConfirmationButton (p: System.Boolean) = "ShowConfirmationButton" => p
    let inline padTimeValues (p: System.Boolean) = "PadTimeValues" => p
    let inline fieldPrecision (p: Radzen.TimeSpanUnit) = "FieldPrecision" => p
    let inline daysStep (p: System.String) = "DaysStep" => p
    let inline hoursStep (p: System.String) = "HoursStep" => p
    let inline minutesStep (p: System.String) = "MinutesStep" => p
    let inline secondsStep (p: System.String) = "SecondsStep" => p
    let inline millisecondsStep (p: System.String) = "MillisecondsStep" => p
    let inline microsecondsStep (p: System.String) = "MicrosecondsStep" => p
    let inline confirmationButtonText (p: System.String) = "ConfirmationButtonText" => p
    let inline positiveButtonText (p: System.String) = "PositiveButtonText" => p
    let inline negativeButtonText (p: System.String) = "NegativeButtonText" => p
    let inline positiveValueText (p: System.String) = "PositiveValueText" => p
    let inline negativeValueText (p: System.String) = "NegativeValueText" => p
    let inline daysUnitText (p: System.String) = "DaysUnitText" => p
    let inline hoursUnitText (p: System.String) = "HoursUnitText" => p
    let inline minutesUnitText (p: System.String) = "MinutesUnitText" => p
    let inline secondsUnitText (p: System.String) = "SecondsUnitText" => p
    let inline millisecondsUnitText (p: System.String) = "MillisecondsUnitText" => p
    let inline microsecondsUnitText (p: System.String) = "MicrosecondsUnitText" => p

    let inline valueExpression<'TValue82> (p: System.Linq.Expressions.Expression<System.Func<'TValue82>>) =
        "ValueExpression" => p

    let inline onValueChanged<'TValue82> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'TValue82> "ValueChanged" p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.TimeSpan>> "Change" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenToggleButton = comp<Radzen.Blazor.RadzenToggleButton>

module radzenToggleButtonAttrs =
    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline name (p: System.String) = "Name" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline toggleIcon (p: System.String) = "ToggleIcon" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ValueChanged" p

    let inline value (p: System.Boolean) = "Value" => p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "Change" p

    let inline valueExpression (p: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) =
        "ValueExpression" => p

    let inline toggleButtonStyle (p: Radzen.ButtonStyle) = "ToggleButtonStyle" => p
    let inline toggleShade (p: Radzen.Shade) = "ToggleShade" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline tabIndex (p: System.Int32) = "TabIndex" => p
    let inline text (p: System.String) = "Text" => p
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline image (p: System.String) = "Image" => p
    let inline buttonStyle (p: Radzen.ButtonStyle) = "ButtonStyle" => p
    let inline buttonType (p: Radzen.ButtonType) = "ButtonType" => p
    let inline variant (p: Radzen.Variant) = "Variant" => p
    let inline shade (p: Radzen.Shade) = "Shade" => p
    let inline size (p: Radzen.ButtonSize) = "Size" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "Click" p

    let inline isBusy (p: System.Boolean) = "IsBusy" => p
    let inline busyText (p: System.String) = "BusyText" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTree = comp<Radzen.Blazor.RadzenTree>

module radzenTreeAttrs =
    let inline selectItemAriaLabel (p: System.String) = "SelectItemAriaLabel" => p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.TreeEventArgs> "Change" p

    let inline onExpand ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.TreeExpandEventArgs> "Expand" p

    let inline onCollapse ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.TreeEventArgs> "Collapse" p

    let inline itemRender (p: System.Action<Radzen.TreeItemRenderEventArgs>) = "ItemRender" => p

    let inline onItemContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.TreeItemContextMenuEventArgs> "ItemContextMenu" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline value (p: System.Object) = "Value" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "ValueChanged" p

    let inline allowCheckBoxes (p: System.Boolean) = "AllowCheckBoxes" => p
    let inline allowCheckChildren (p: System.Boolean) = "AllowCheckChildren" => p
    let inline allowCheckParents (p: System.Boolean) = "AllowCheckParents" => p
    let inline singleExpand (p: System.Boolean) = "SingleExpand" => p
    let inline checkedValues (p: System.Collections.Generic.IEnumerable<System.Object>) = "CheckedValues" => p
    let inline itemContentCssClass (p: System.String) = "ItemContentCssClass" => p
    let inline itemIconCssClass (p: System.String) = "ItemIconCssClass" => p
    let inline itemLabelCssClass (p: System.String) = "ItemLabelCssClass" => p

    let inline onCheckedValuesChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<System.Object>> "CheckedValuesChanged" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTreeItem = comp<Radzen.Blazor.RadzenTreeItem>

module radzenTreeItemAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenTreeItem -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline text (p: System.String) = "Text" => p
    let inline checkable (p: System.Boolean) = "Checkable" => p
    let inline expanded (p: System.Boolean) = "Expanded" => p
    let inline value (p: System.Object) = "Value" => p
    let inline hasChildren (p: System.Boolean) = "HasChildren" => p
    let inline selected (p: System.Boolean) = "Selected" => p
    let inline data (p: System.Collections.IEnumerable) = "Data" => p
    let inline contentCssClass (p: System.String) = "ContentCssClass" => p
    let inline iconCssClass (p: System.String) = "IconCssClass" => p
    let inline labelCssClass (p: System.String) = "LabelCssClass" => p

let radzenTreeLevel = comp<Radzen.Blazor.RadzenTreeLevel>

module radzenTreeLevelAttrs =
    let inline textProperty (p: System.String) = "TextProperty" => p
    let inline checkableProperty (p: System.String) = "CheckableProperty" => p
    let inline childrenProperty (p: System.String) = "ChildrenProperty" => p
    let inline hasChildren (p: System.Func<System.Object, System.Boolean>) = "HasChildren" => p
    let inline expanded (p: System.Func<System.Object, System.Boolean>) = "Expanded" => p
    let inline selected (p: System.Func<System.Object, System.Boolean>) = "Selected" => p
    let inline text (p: System.Func<System.Object, System.String>) = "Text" => p
    let inline checkable (p: System.Func<System.Object, System.Boolean>) = "Checkable" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenTreeItem -> Bolero.Node) =
        attr.fragmentWith "Template" p

let radzenUpload = comp<Radzen.Blazor.RadzenUpload>

module radzenUploadAttrs =
    let inline imageAlternateText (p: System.String) = "ImageAlternateText" => p

    let inline inputAttributes (p: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) =
        "InputAttributes" => p

    let inline name (p: System.String) = "Name" => p
    let inline auto (p: System.Boolean) = "Auto" => p
    let inline chooseText (p: System.String) = "ChooseText" => p
    let inline deleteText (p: System.String) = "DeleteText" => p
    let inline url (p: System.String) = "Url" => p
    let inline parameterName (p: System.String) = "ParameterName" => p
    let inline accept (p: System.String) = "Accept" => p
    let inline multiple (p: System.Boolean) = "Multiple" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline maxFileCount (p: System.Int32) = "MaxFileCount" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadChangeEventArgs> "Change" p

    let inline onProgress ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadProgressArgs> "Progress" p

    let inline onComplete ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadCompleteEventArgs> "Complete" p

    let inline onError ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.UploadErrorEventArgs> "Error" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenWeekView = comp<Radzen.Blazor.RadzenWeekView>

module radzenWeekViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline headerFormat (p: System.String) = "HeaderFormat" => p
    let inline startTime (p: System.TimeSpan) = "StartTime" => p
    let inline endTime (p: System.TimeSpan) = "EndTime" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p

let radzenYearPlannerView = comp<Radzen.Blazor.RadzenYearPlannerView>

module radzenYearPlannerViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline maxAppointmentsInSlot (p: System.Nullable<System.Int32>) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p
    let inline startMonth (p: Radzen.Month) = "StartMonth" => p

let radzenYearTimelineView = comp<Radzen.Blazor.RadzenYearTimelineView>

module radzenYearTimelineViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline maxAppointmentsInSlot (p: System.Nullable<System.Int32>) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p
    let inline startMonth (p: Radzen.Month) = "StartMonth" => p

let radzenYearView = comp<Radzen.Blazor.RadzenYearView>

module radzenYearViewAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline moreText (p: System.String) = "MoreText" => p
    let inline noDayEventsText (p: System.String) = "NoDayEventsText" => p
    let inline startMonth (p: Radzen.Month) = "StartMonth" => p

let radzenArcGauge = comp<Radzen.Blazor.RadzenArcGauge>

module radzenArcGaugeAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenCategoryAxis = comp<Radzen.Blazor.RadzenCategoryAxis>

module radzenCategoryAxisAttrs =
    let inline padding (p: System.Double) = "Padding" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline formatter (p: System.Func<System.Object, System.String>) = "Formatter" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline tickDistance (p: System.Int32) = "TickDistance" => p
    let inline min (p: System.Object) = "Min" => p
    let inline max (p: System.Object) = "Max" => p
    let inline step (p: System.Object) = "Step" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline labelRotation (p: System.Nullable<System.Double>) = "LabelRotation" => p
    let inline labelAutoRotation (p: System.Nullable<System.Double>) = "LabelAutoRotation" => p

let radzenChartTooltip = comp<Radzen.Blazor.RadzenChartTooltip>
let radzenComponents = comp<Radzen.Blazor.RadzenComponents>

let radzenDataFilterItem<'TItem83> =
    comp<Radzen.Blazor.RadzenDataFilterItem<'TItem83>>

module radzenDataFilterItemAttrs =
    let inline dataFilter<'TItem83> (p: Radzen.Blazor.RadzenDataFilter<'TItem83>) = "DataFilter" => p
    let inline parent<'TItem83> (p: Radzen.Blazor.RadzenDataFilterItem<'TItem83>) = "Parent" => p
    let inline filter (p: Radzen.CompositeFilterDescriptor) = "Filter" => p

let radzenDataGridFilterMenu<'TItem84> =
    comp<Radzen.Blazor.RadzenDataGridFilterMenu<'TItem84>>

module radzenDataGridFilterMenuAttrs =
    let inline column<'TItem84> (p: Radzen.Blazor.RadzenDataGridColumn<'TItem84>) = "Column" => p
    let inline grid<'TItem84> (p: Radzen.Blazor.RadzenDataGrid<'TItem84>) = "Grid" => p

let radzenDataGridFooterCell<'TItem85> =
    comp<Radzen.Blazor.RadzenDataGridFooterCell<'TItem85>>

module radzenDataGridFooterCellAttrs =
    let inline column<'TItem85> (p: Radzen.Blazor.RadzenDataGridColumn<'TItem85>) = "Column" => p
    let inline rowIndex (p: System.Int32) = "RowIndex" => p
    let inline grid<'TItem85> (p: Radzen.Blazor.RadzenDataGrid<'TItem85>) = "Grid" => p
    let inline cssClass (p: System.String) = "CssClass" => p
    let inline style (p: System.String) = "Style" => p

let radzenDataGridGroupFooterCell<'TItem86> =
    comp<Radzen.Blazor.RadzenDataGridGroupFooterCell<'TItem86>>

module radzenDataGridGroupFooterCellAttrs =
    let inline group (p: Radzen.Group) = "Group" => p
    let inline column<'TItem86> (p: Radzen.Blazor.RadzenDataGridColumn<'TItem86>) = "Column" => p
    let inline rowIndex (p: System.Int32) = "RowIndex" => p
    let inline grid<'TItem86> (p: Radzen.Blazor.RadzenDataGrid<'TItem86>) = "Grid" => p
    let inline cssClass (p: System.String) = "CssClass" => p
    let inline style (p: System.String) = "Style" => p

let radzenDataGridGroupFooterRow<'TItem87> =
    comp<Radzen.Blazor.RadzenDataGridGroupFooterRow<'TItem87>>

module radzenDataGridGroupFooterRowAttrs =
    let inline columns<'TItem87> (p: System.Collections.Generic.IList<Radzen.Blazor.RadzenDataGridColumn<'TItem87>>) =
        "Columns" => p

    let inline groupResult (p: Radzen.GroupResult) = "GroupResult" => p
    let inline grid<'TItem87> (p: Radzen.Blazor.RadzenDataGrid<'TItem87>) = "Grid" => p
    let inline parent<'TItem87> (p: Radzen.Blazor.RadzenDataGridGroupRow<'TItem87>) = "Parent" => p
    let inline builder (p: Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder) = "Builder" => p

let radzenDataGridGroupRow<'TItem88> =
    comp<Radzen.Blazor.RadzenDataGridGroupRow<'TItem88>>

module radzenDataGridGroupRowAttrs =
    let inline columns<'TItem88> (p: System.Collections.Generic.IList<Radzen.Blazor.RadzenDataGridColumn<'TItem88>>) =
        "Columns" => p

    let inline groupResult (p: Radzen.GroupResult) = "GroupResult" => p
    let inline grid<'TItem88> (p: Radzen.Blazor.RadzenDataGrid<'TItem88>) = "Grid" => p
    let inline parent<'TItem88> (p: Radzen.Blazor.RadzenDataGridGroupRow<'TItem88>) = "Parent" => p
    let inline builder (p: Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder) = "Builder" => p

let radzenDataGridHeaderCell<'TItem89> =
    comp<Radzen.Blazor.RadzenDataGridHeaderCell<'TItem89>>

module radzenDataGridHeaderCellAttrs =
    let inline column<'TItem89> (p: Radzen.Blazor.RadzenDataGridColumn<'TItem89>) = "Column" => p
    let inline columnIndex (p: System.Int32) = "ColumnIndex" => p
    let inline rowIndex (p: System.Int32) = "RowIndex" => p
    let inline grid<'TItem89> (p: Radzen.Blazor.RadzenDataGrid<'TItem89>) = "Grid" => p
    let inline cssClass (p: System.String) = "CssClass" => p
    let inline style (p: System.String) = "Style" => p

let radzenDataListRow<'TItem90> = comp<Radzen.Blazor.RadzenDataListRow<'TItem90>>

module radzenDataListRowAttrs =
    let inline dataList<'TItem90> (p: Radzen.Blazor.RadzenDataList<'TItem90>) = "DataList" => p
    let inline item (p: 'TItem90) = "Item" => p

let radzenDialog = comp<Radzen.Blazor.RadzenDialog>

module radzenDialogAttrs =
    let inline closeSideDialogAriaLabel (p: System.String) = "CloseSideDialogAriaLabel" => p

let radzenDropDownDataGridColumn = comp<Radzen.Blazor.RadzenDropDownDataGridColumn>

module radzenDropDownDataGridColumnAttrs =
    let inline columns p = attr.fragment "Columns" p
    let inline allowCheckBoxListVirtualization (p: System.Boolean) = "AllowCheckBoxListVirtualization" => p
    let inline filterMode (p: System.Nullable<Radzen.FilterMode>) = "FilterMode" => p
    let inline uniqueID (p: System.String) = "UniqueID" => p
    let inline orderIndex (p: System.Nullable<System.Int32>) = "OrderIndex" => p
    let inline sortOrder (p: System.Nullable<Radzen.SortOrder>) = "SortOrder" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline headerTooltip (p: System.String) = "HeaderTooltip" => p
    let inline title (p: System.String) = "Title" => p
    let inline columnPickerTitle (p: System.String) = "ColumnPickerTitle" => p
    let inline property (p: System.String) = "Property" => p
    let inline sortProperty (p: System.String) = "SortProperty" => p
    let inline groupProperty (p: System.String) = "GroupProperty" => p
    let inline filterProperty (p: System.String) = "FilterProperty" => p
    let inline filterValue (p: System.Object) = "FilterValue" => p
    let inline filterPlaceholder (p: System.String) = "FilterPlaceholder" => p
    let inline customFilterExpression (p: System.String) = "CustomFilterExpression" => p
    let inline secondFilterValue (p: System.Object) = "SecondFilterValue" => p
    let inline width (p: System.String) = "Width" => p
    let inline minWidth (p: System.String) = "MinWidth" => p
    let inline maxWidth (p: System.String) = "MaxWidth" => p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline cssClass (p: System.String) = "CssClass" => p

    let inline calculatedCssClass
        (p: System.Func<Radzen.Blazor.RadzenDataGridColumn<System.Object>, System.Object, System.String>)
        =
        "CalculatedCssClass" => p

    let inline headerCssClass (p: System.String) = "HeaderCssClass" => p
    let inline footerCssClass (p: System.String) = "FooterCssClass" => p
    let inline groupFooterCssClass (p: System.String) = "GroupFooterCssClass" => p
    let inline headerWhiteSpace (p: Radzen.Blazor.WhiteSpace) = "HeaderWhiteSpace" => p
    let inline whiteSpace (p: Radzen.Blazor.WhiteSpace) = "WhiteSpace" => p
    let inline filterable (p: System.Boolean) = "Filterable" => p
    let inline sortable (p: System.Boolean) = "Sortable" => p
    let inline frozen (p: System.Boolean) = "Frozen" => p
    let inline frozenPosition (p: Radzen.FrozenColumnPosition) = "FrozenPosition" => p
    let inline resizable (p: System.Boolean) = "Resizable" => p
    let inline reorderable (p: System.Boolean) = "Reorderable" => p
    let inline groupable (p: System.Boolean) = "Groupable" => p
    let inline pickable (p: System.Boolean) = "Pickable" => p
    let inline textAlign (p: Radzen.TextAlign) = "TextAlign" => p

    let inline template ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "Template" p

    let inline editTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Object -> Bolero.Node) =
        attr.fragmentWith "EditTemplate" p

    let inline isInEditMode (p: System.Func<System.String, System.Object, System.Boolean>) = "IsInEditMode" => p
    let inline headerTemplate p = attr.fragment "HeaderTemplate" p
    let inline footerTemplate p = attr.fragment "FooterTemplate" p

    let inline groupFooterTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Group -> Bolero.Node) =
        attr.fragmentWith "GroupFooterTemplate" p

    let inline filterTemplate
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenDataGridColumn<System.Object> -> Bolero.Node)
        =
        attr.fragmentWith "FilterTemplate" p

    let inline filterValueTemplate
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenDataGridColumn<System.Object> -> Bolero.Node)
        =
        attr.fragmentWith "FilterValueTemplate" p

    let inline secondFilterValueTemplate
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.RadzenDataGridColumn<System.Object> -> Bolero.Node)
        =
        attr.fragmentWith "SecondFilterValueTemplate" p

    let inline logicalFilterOperator (p: Radzen.LogicalFilterOperator) = "LogicalFilterOperator" => p
    let inline ``type`` (p: System.Type) = "Type" => p
    let inline formatProvider (p: System.IFormatProvider) = "FormatProvider" => p
    let inline filterOperator (p: Radzen.FilterOperator) = "FilterOperator" => p

    let inline filterOperators (p: System.Collections.Generic.IEnumerable<Radzen.FilterOperator>) =
        "FilterOperators" => p

    let inline secondFilterOperator (p: Radzen.FilterOperator) = "SecondFilterOperator" => p

let radzenDropDownItem<'TValue91> =
    comp<Radzen.Blazor.RadzenDropDownItem<'TValue91>>

module radzenDropDownItemAttrs =
    let inline dropDown<'TValue91> (p: Radzen.Blazor.RadzenDropDown<'TValue91>) = "DropDown" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline item (p: System.Object) = "Item" => p

let radzenGridRow = comp<Radzen.Blazor.RadzenGridRow>

module radzenGridRowAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline cssClass (p: System.String) = "CssClass" => p
    let inline inEditMode (p: System.Boolean) = "InEditMode" => p

let radzenListBoxItem<'TValue92> = comp<Radzen.Blazor.RadzenListBoxItem<'TValue92>>

module radzenListBoxItemAttrs =
    let inline listBox<'TValue92> (p: Radzen.Blazor.RadzenListBox<'TValue92>) = "ListBox" => p
    let inline item (p: System.Object) = "Item" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

let radzenMenuItemWrapper = comp<Radzen.Blazor.RadzenMenuItemWrapper>

module radzenMenuItemWrapperAttrs =
    let inline item (p: Radzen.Blazor.RadzenMenuItem) = "Item" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenNotification = comp<Radzen.Blazor.RadzenNotification>

module radzenNotificationAttrs =
    let inline style (p: System.String) = "Style" => p

let radzenNotificationMessage = comp<Radzen.Blazor.RadzenNotificationMessage>

module radzenNotificationMessageAttrs =
    let inline message (p: Radzen.NotificationMessage) = "Message" => p
    let inline style (p: System.String) = "Style" => p

let radzenRadialGauge = comp<Radzen.Blazor.RadzenRadialGauge>

module radzenRadialGaugeAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenSeriesValueLine = comp<Radzen.Blazor.RadzenSeriesValueLine>

module radzenSeriesValueLineAttrs =
    let inline value (p: System.Double) = "Value" => p

    let inline tooltipTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Double -> Bolero.Node) =
        attr.fragmentWith "TooltipTemplate" p

    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let radzenTooltip = comp<Radzen.Blazor.RadzenTooltip>
let radzenUploadHeader = comp<Radzen.Blazor.RadzenUploadHeader>

module radzenUploadHeaderAttrs =
    let inline name (p: System.String) = "Name" => p
    let inline value (p: System.String) = "Value" => p

let radzenValueAxis = comp<Radzen.Blazor.RadzenValueAxis>

module radzenValueAxisAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline formatter (p: System.Func<System.Object, System.String>) = "Formatter" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline tickDistance (p: System.Int32) = "TickDistance" => p
    let inline min (p: System.Object) = "Min" => p
    let inline max (p: System.Object) = "Max" => p
    let inline step (p: System.Object) = "Step" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline labelRotation (p: System.Nullable<System.Double>) = "LabelRotation" => p
    let inline labelAutoRotation (p: System.Nullable<System.Double>) = "LabelAutoRotation" => p

let appointment = comp<Radzen.Blazor.Rendering.Appointment>

module appointmentAttrs =
    let inline cssClass (p: System.String) = "CssClass" => p
    let inline top (p: System.Nullable<System.Double>) = "Top" => p
    let inline left (p: System.Nullable<System.Double>) = "Left" => p
    let inline width (p: System.Nullable<System.Double>) = "Width" => p
    let inline height (p: System.Nullable<System.Double>) = "Height" => p

    let inline onClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.AppointmentData> "Click" p

    let inline onDragStart ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.AppointmentData> "DragStart" p

    let inline data (p: Radzen.Blazor.AppointmentData) = "Data" => p
    let inline showAppointmentContent (p: System.Boolean) = "ShowAppointmentContent" => p

let categoryAxis = comp<Radzen.Blazor.Rendering.CategoryAxis>
let categoryAxisTick = comp<Radzen.Blazor.Rendering.CategoryAxisTick>

module categoryAxisTickAttrs =
    let inline rotate (p: System.Nullable<System.Double>) = "Rotate" => p
    let inline x (p: System.Double) = "X" => p
    let inline y (p: System.Double) = "Y" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline text (p: System.String) = "Text" => p

let categoryAxisTitle = comp<Radzen.Blazor.Rendering.CategoryAxisTitle>

module categoryAxisTitleAttrs =
    let inline x (p: System.Double) = "X" => p
    let inline y (p: System.Double) = "Y" => p
    let inline text (p: System.String) = "Text" => p

let chartSharedTooltip = comp<Radzen.Blazor.Rendering.ChartSharedTooltip>

module chartSharedTooltipAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline title (p: System.String) = "Title" => p

let chartSharedTooltipItem = comp<Radzen.Blazor.Rendering.ChartSharedTooltipItem>

module chartSharedTooltipItemAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline value (p: System.String) = "Value" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline legendItem p = attr.fragment "LegendItem" p

let chartTooltip = comp<Radzen.Blazor.Rendering.ChartTooltip>

module chartTooltipAttrs =
    let inline style (p: System.String) = "Style" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline title (p: System.String) = "Title" => p
    let inline value (p: System.String) = "Value" => p
    let inline label (p: System.String) = "Label" => p
    let inline ``class`` (p: System.String) = "Class" => p

let clipPath = comp<Radzen.Blazor.Rendering.ClipPath>
let daySlotEvents = comp<Radzen.Blazor.Rendering.DaySlotEvents>

module daySlotEventsAttrs =
    let inline currentAppointment (p: System.Int32) = "CurrentAppointment" => p
    let inline currentDate (p: System.DateTime) = "CurrentDate" => p
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p

    let inline onAppointmentDragStart ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.AppointmentData> "AppointmentDragStart" p

    let inline appointments (p: System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>) = "Appointments" => p

let dayView = comp<Radzen.Blazor.Rendering.DayView>

module dayViewAttrs =
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline startTime (p: System.TimeSpan) = "StartTime" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline endTime (p: System.TimeSpan) = "EndTime" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p
    let inline appointments (p: System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>) = "Appointments" => p

    let inline onAppointmentMove ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentMoveEventArgs> "AppointmentMove" p

let dialogContainer = comp<Radzen.Blazor.Rendering.DialogContainer>

module dialogContainerAttrs =
    let inline dialog (p: Radzen.Dialog) = "Dialog" => p
    let inline showMask (p: System.Boolean) = "ShowMask" => p

let draggable = comp<Radzen.Blazor.Rendering.Draggable>

module draggableAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onDragStart ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.Rendering.DraggableEventArgs> "DragStart" p

    let inline onDragEnd ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.Rendering.DraggableEventArgs> "DragEnd" p

    let inline onDrag ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.Blazor.Rendering.DraggableEventArgs> "Drag" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let editorButton = comp<Radzen.Blazor.Rendering.EditorButton>

module editorButtonAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline shortcut (p: System.String) = "Shortcut" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline preventBlur (p: System.Boolean) = "PreventBlur" => p
    let inline selected (p: System.Boolean) = "Selected" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline enabledModes (p: Radzen.HtmlEditorMode) = "EnabledModes" => p
    let inline click (p: Microsoft.AspNetCore.Components.EventCallback) = "Click" => p

let editorColorPicker = comp<Radzen.Blazor.Rendering.EditorColorPicker>

module editorColorPickerAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline title (p: System.String) = "Title" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: System.String) = "IconColor" => p
    let inline value (p: System.String) = "Value" => p
    let inline enabledModes (p: Radzen.HtmlEditorMode) = "EnabledModes" => p
    let inline showHSV (p: System.Boolean) = "ShowHSV" => p
    let inline showRGBA (p: System.Boolean) = "ShowRGBA" => p
    let inline showColors (p: System.Boolean) = "ShowColors" => p
    let inline showButton (p: System.Boolean) = "ShowButton" => p
    let inline hexText (p: System.String) = "HexText" => p
    let inline redText (p: System.String) = "RedText" => p
    let inline greenText (p: System.String) = "GreenText" => p
    let inline blueText (p: System.String) = "BlueText" => p
    let inline alphaText (p: System.String) = "AlphaText" => p
    let inline buttonText (p: System.String) = "ButtonText" => p
    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

let editorDropDown = comp<Radzen.Blazor.Rendering.EditorDropDown>

module editorDropDownAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline popupStyle (p: System.String) = "PopupStyle" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline enabledModes (p: Radzen.HtmlEditorMode) = "EnabledModes" => p
    let inline value (p: System.String) = "Value" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline onChange ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.String> "Change" p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let editorDropDownItem = comp<Radzen.Blazor.Rendering.EditorDropDownItem>

module editorDropDownItemAttrs =
    let inline childContent
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Radzen.Blazor.Rendering.EditorDropDownItem -> Bolero.Node)
        =
        attr.fragmentWith "ChildContent" p

    let inline text (p: System.String) = "Text" => p
    let inline value (p: System.String) = "Value" => p

let gaugeBand = comp<Radzen.Blazor.Rendering.GaugeBand>

module gaugeBandAttrs =
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline endAngle (p: System.Double) = "EndAngle" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline from (p: System.Double) = "From" => p
    let inline ``to`` (p: System.Double) = "To" => p
    let inline radius (p: System.Double) = "Radius" => p
    let inline center (p: Radzen.Blazor.Point) = "Center" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline size (p: System.Double) = "Size" => p

let gaugePointer = comp<Radzen.Blazor.Rendering.GaugePointer>

module gaugePointerAttrs =
    let inline stroke (p: System.String) = "Stroke" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline radius (p: System.Double) = "Radius" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline endAngle (p: System.Double) = "EndAngle" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline width (p: System.Double) = "Width" => p
    let inline length (p: System.Double) = "Length" => p
    let inline center (p: Radzen.Blazor.Point) = "Center" => p
    let inline value (p: System.Double) = "Value" => p

let gaugeScale = comp<Radzen.Blazor.Rendering.GaugeScale>

module gaugeScaleAttrs =
    let inline startAngle (p: System.Double) = "StartAngle" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline tickLength (p: System.Double) = "TickLength" => p
    let inline minorTickLength (p: System.Double) = "MinorTickLength" => p
    let inline tickLabelOffset (p: System.Double) = "TickLabelOffset" => p
    let inline endAngle (p: System.Double) = "EndAngle" => p
    let inline radius (p: System.Double) = "Radius" => p
    let inline center (p: Radzen.Blazor.Point) = "Center" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline showFirstTick (p: System.Boolean) = "ShowFirstTick" => p
    let inline showLastTick (p: System.Boolean) = "ShowLastTick" => p
    let inline showTickLabels (p: System.Boolean) = "ShowTickLabels" => p
    let inline tickPosition (p: Radzen.Blazor.GaugeTickPosition) = "TickPosition" => p
    let inline formatString (p: System.String) = "FormatString" => p
    let inline formatter (p: System.Func<System.Double, System.String>) = "Formatter" => p
    let inline step (p: System.Double) = "Step" => p
    let inline minorStep (p: System.Double) = "MinorStep" => p

let hours = comp<Radzen.Blazor.Rendering.Hours>

module hoursAttrs =
    let inline start (p: System.TimeSpan) = "Start" => p
    let inline ``end`` (p: System.TimeSpan) = "End" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p

let legend = comp<Radzen.Blazor.Rendering.Legend>
let legendItem = comp<Radzen.Blazor.Rendering.LegendItem>

module legendItemAttrs =
    let inline color (p: System.String) = "Color" => p
    let inline text (p: System.String) = "Text" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline markerType (p: Radzen.Blazor.MarkerType) = "MarkerType" => p
    let inline markerSize (p: System.Double) = "MarkerSize" => p
    let inline click (p: Microsoft.AspNetCore.Components.EventCallback) = "Click" => p
    let inline clickable (p: System.Boolean) = "Clickable" => p
    let inline index (p: System.Int32) = "Index" => p

let line = comp<Radzen.Blazor.Rendering.Line>

module lineAttrs =
    let inline style (p: System.String) = "Style" => p
    let inline x1 (p: System.Double) = "X1" => p
    let inline x2 (p: System.Double) = "X2" => p
    let inline y1 (p: System.Double) = "Y1" => p
    let inline y2 (p: System.Double) = "Y2" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline ``class`` (p: System.String) = "Class" => p

let marker = comp<Radzen.Blazor.Rendering.Marker>

module markerAttrs =
    let inline x (p: System.Double) = "X" => p
    let inline ``type`` (p: Radzen.Blazor.MarkerType) = "Type" => p
    let inline y (p: System.Double) = "Y" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline size (p: System.Double) = "Size" => p
    let inline click (p: Microsoft.AspNetCore.Components.EventCallback) = "Click" => p

let markers<'TItem93> = comp<Radzen.Blazor.Rendering.Markers<'TItem93>>

module markersAttrs =
    let inline series (p: Radzen.Blazor.IChartSeries) = "Series" => p
    let inline data<'TItem93> (p: System.Collections.Generic.IEnumerable<Radzen.Blazor.Point<'TItem93>>) = "Data" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline markerType (p: Radzen.Blazor.MarkerType) = "MarkerType" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline size (p: System.Double) = "Size" => p

let monthView = comp<Radzen.Blazor.Rendering.MonthView>

module monthViewAttrs =
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline maxAppointmentsInSlot (p: System.Int32) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p

    let inline appointments (p: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) =
        "Appointments" => p

    let inline onAppointmentMove ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentMoveEventArgs> "AppointmentMove" p

let path = comp<Radzen.Blazor.Rendering.Path>

module pathAttrs =
    let inline style (p: System.String) = "Style" => p
    let inline d (p: System.String) = "D" => p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline fill (p: System.String) = "Fill" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline ``class`` (p: System.String) = "Class" => p

let popup = comp<Radzen.Blazor.Rendering.Popup>

module popupAttrs =
    let inline ``lazy`` (p: System.Boolean) = "Lazy" => p
    let inline autoFocusFirstElement (p: System.Boolean) = "AutoFocusFirstElement" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline preventDefault (p: System.Boolean) = "PreventDefault" => p
    let inline ``open`` (p: Microsoft.AspNetCore.Components.EventCallback) = "Open" => p
    let inline close (p: Microsoft.AspNetCore.Components.EventCallback) = "Close" => p

    let inline onMouseEnter ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseEnter" p

    let inline onMouseLeave ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "MouseLeave" p

    let inline onContextMenu ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "ContextMenu" p

    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline style (p: System.String) = "Style" => p
    let inline visible (p: System.Boolean) = "Visible" => p

let text = comp<Radzen.Blazor.Rendering.Text>

module textAttrs =
    let inline ``class`` (p: System.String) = "Class" => p
    let inline value (p: System.String) = "Value" => p
    let inline position (p: Radzen.Blazor.Point) = "Position" => p
    let inline textAnchor (p: System.String) = "TextAnchor" => p
    let inline fill (p: System.String) = "Fill" => p

let valueAxis = comp<Radzen.Blazor.Rendering.ValueAxis>
let valueAxisTick = comp<Radzen.Blazor.Rendering.ValueAxisTick>

module valueAxisTickAttrs =
    let inline x (p: System.Double) = "X" => p
    let inline y (p: System.Double) = "Y" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline stroke (p: System.String) = "Stroke" => p
    let inline strokeWidth (p: System.Double) = "StrokeWidth" => p
    let inline lineType (p: Radzen.Blazor.LineType) = "LineType" => p
    let inline text (p: System.String) = "Text" => p

let valueAxisTitle = comp<Radzen.Blazor.Rendering.ValueAxisTitle>

module valueAxisTitleAttrs =
    let inline x (p: System.Double) = "X" => p
    let inline y (p: System.Double) = "Y" => p
    let inline text (p: System.String) = "Text" => p

let weekView = comp<Radzen.Blazor.Rendering.WeekView>

module weekViewAttrs =
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline startTime (p: System.TimeSpan) = "StartTime" => p
    let inline endTime (p: System.TimeSpan) = "EndTime" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline headerFormat (p: System.String) = "HeaderFormat" => p
    let inline minutesPerSlot (p: System.Int32) = "MinutesPerSlot" => p
    let inline appointments (p: System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>) = "Appointments" => p

    let inline onAppointmentMove ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentMoveEventArgs> "AppointmentMove" p

let yearPlannerView = comp<Radzen.Blazor.Rendering.YearPlannerView>

module yearPlannerViewAttrs =
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline startMonth (p: Radzen.Month) = "StartMonth" => p
    let inline maxAppointmentsInSlot (p: System.Int32) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p

    let inline appointments (p: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) =
        "Appointments" => p

    let inline onAppointmentMove ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentMoveEventArgs> "AppointmentMove" p

let yearTimelineView = comp<Radzen.Blazor.Rendering.YearTimelineView>

module yearTimelineViewAttrs =
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline startMonth (p: Radzen.Month) = "StartMonth" => p
    let inline maxAppointmentsInSlot (p: System.Int32) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p

    let inline appointments (p: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) =
        "Appointments" => p

    let inline onAppointmentMove ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Radzen.SchedulerAppointmentMoveEventArgs> "AppointmentMove" p

let yearView = comp<Radzen.Blazor.Rendering.YearView>

module yearViewAttrs =
    let inline startDate (p: System.DateTime) = "StartDate" => p
    let inline endDate (p: System.DateTime) = "EndDate" => p
    let inline startMonth (p: Radzen.Month) = "StartMonth" => p
    let inline maxAppointmentsInSlot (p: System.Int32) = "MaxAppointmentsInSlot" => p
    let inline moreText (p: System.String) = "MoreText" => p
    let inline noDayEventsText (p: System.String) = "NoDayEventsText" => p

    let inline appointments (p: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) =
        "Appointments" => p
