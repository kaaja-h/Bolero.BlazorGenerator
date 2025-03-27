[<Microsoft.FSharp.Core.AutoOpen>]
module Bolero.BlazorGenerator.GeneratedComponentTest.Mudblazor

open Bolero.Html
let componentBaseWithState = comp<MudBlazor.ComponentBaseWithState>
let mudBooleanInput<'T1> = comp<MudBlazor.MudBooleanInput<'T1>>

module mudBooleanInputAttrs =
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline value (p: 'T1) = "Value" => p
    let inline stopClickPropagation (p: System.Boolean) = "StopClickPropagation" => p
    let inline labelPlacement (p: MudBlazor.Placement) = "LabelPlacement" => p
    let inline label (p: System.String) = "Label" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onValueChanged<'T1> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T1> "ValueChanged" p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T1> (p: MudBlazor.Converter<'T1, System.Nullable<System.Boolean>>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T1> (p: System.Linq.Expressions.Expression<System.Func<'T1>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudAlert = comp<MudBlazor.MudAlert>

module mudAlertAttrs =
    let inline contentAlignment (p: MudBlazor.HorizontalAlignment) = "ContentAlignment" => p

    let inline onCloseIconClicked ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.MudAlert> "CloseIconClicked" p

    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline showCloseIcon (p: System.Boolean) = "ShowCloseIcon" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline noIcon (p: System.Boolean) = "NoIcon" => p
    let inline severity (p: MudBlazor.Severity) = "Severity" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline icon (p: System.String) = "Icon" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudAppBar = comp<MudBlazor.MudAppBar>

module mudAppBarAttrs =
    let inline bottom (p: System.Boolean) = "Bottom" => p
    let inline contextual (p: System.Boolean) = "Contextual" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline ``fixed`` (p: System.Boolean) = "Fixed" => p
    let inline wrapContent (p: System.Boolean) = "WrapContent" => p
    let inline toolBarClass (p: System.String) = "ToolBarClass" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudContextualActionBar = comp<MudBlazor.MudContextualActionBar>

module mudContextualActionBarAttrs =
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline bottom (p: System.Boolean) = "Bottom" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline ``fixed`` (p: System.Boolean) = "Fixed" => p
    let inline wrapContent (p: System.Boolean) = "WrapContent" => p
    let inline toolBarClass (p: System.String) = "ToolBarClass" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudAutocomplete<'T2> = comp<MudBlazor.MudAutocomplete<'T2>>

module mudAutocompleteAttrs =
    let inline inputClass (p: System.String) = "InputClass" => p
    let inline popoverClass (p: System.String) = "PopoverClass" => p
    let inline listClass (p: System.String) = "ListClass" => p
    let inline listItemClass (p: System.String) = "ListItemClass" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline openIcon (p: System.String) = "OpenIcon" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline maxHeight (p: System.Int32) = "MaxHeight" => p
    let inline toStringFunc<'T2> (p: System.Func<'T2, System.String>) = "ToStringFunc" => p
    let inline showProgressIndicator (p: System.Boolean) = "ShowProgressIndicator" => p
    let inline progressIndicatorColor (p: MudBlazor.Color) = "ProgressIndicatorColor" => p

    let inline searchFunc<'T2>
        (p:
            System.Func<
                System.String,
                System.Threading.CancellationToken,
                System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T2>>
             >)
        =
        "SearchFunc" => p

    let inline maxItems (p: System.Nullable<System.Int32>) = "MaxItems" => p
    let inline minCharacters (p: System.Int32) = "MinCharacters" => p
    let inline resetValueOnEmptyText (p: System.Boolean) = "ResetValueOnEmptyText" => p
    let inline selectOnActivation (p: System.Boolean) = "SelectOnActivation" => p
    let inline strict (p: System.Boolean) = "Strict" => p
    let inline debounceInterval (p: System.Int32) = "DebounceInterval" => p

    let inline itemTemplate<'T2> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T2 -> Bolero.Node) =
        attr.fragmentWith "ItemTemplate" p

    let inline itemSelectedTemplate<'T2> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T2 -> Bolero.Node) =
        attr.fragmentWith "ItemSelectedTemplate" p

    let inline itemDisabledTemplate<'T2> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T2 -> Bolero.Node) =
        attr.fragmentWith "ItemDisabledTemplate" p

    let inline moreItemsTemplate p = attr.fragment "MoreItemsTemplate" p
    let inline noItemsTemplate p = attr.fragment "NoItemsTemplate" p
    let inline beforeItemsTemplate p = attr.fragment "BeforeItemsTemplate" p
    let inline afterItemsTemplate p = attr.fragment "AfterItemsTemplate" p

    let inline progressIndicatorTemplate p =
        attr.fragment "ProgressIndicatorTemplate" p

    let inline progressIndicatorInPopoverTemplate p =
        attr.fragment "ProgressIndicatorInPopoverTemplate" p

    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline coerceText (p: System.Boolean) = "CoerceText" => p
    let inline coerceValue (p: System.Boolean) = "CoerceValue" => p
    let inline dropdownSettings (p: MudBlazor.DropdownSettings) = "DropdownSettings" => p
    let inline itemDisabledFunc<'T2> (p: System.Func<'T2, System.Boolean>) = "ItemDisabledFunc" => p

    let inline onOpenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "OpenChanged" p

    let inline selectValueOnTab (p: System.Boolean) = "SelectValueOnTab" => p
    let inline openOnFocus (p: System.Boolean) = "OpenOnFocus" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline clearIcon (p: System.String) = "ClearIcon" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline onReturnedItemsCountChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "ReturnedItemsCountChanged" p

    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p
    let inline onValueChanged<'T2> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T2> "ValueChanged" p
    let inline value (p: 'T2) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T2> (p: MudBlazor.Converter<'T2, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T2> (p: System.Linq.Expressions.Expression<System.Func<'T2>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudAvatar = comp<MudBlazor.MudAvatar>

module mudAvatarAttrs =
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudAvatarGroup = comp<MudBlazor.MudAvatarGroup>

module mudAvatarGroupAttrs =
    let inline spacing (p: System.Int32) = "Spacing" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline outlineColor (p: MudBlazor.Color) = "OutlineColor" => p
    let inline maxElevation (p: System.Int32) = "MaxElevation" => p
    let inline maxSquare (p: System.Boolean) = "MaxSquare" => p
    let inline maxRounded (p: System.Boolean) = "MaxRounded" => p
    let inline maxColor (p: MudBlazor.Color) = "MaxColor" => p
    let inline maxSize (p: MudBlazor.Size) = "MaxSize" => p
    let inline maxVariant (p: MudBlazor.Variant) = "MaxVariant" => p
    let inline max (p: System.Int32) = "Max" => p
    let inline maxAvatarClass (p: System.String) = "MaxAvatarClass" => p

    let inline maxAvatarsTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Int32 -> Bolero.Node) =
        attr.fragmentWith "MaxAvatarsTemplate" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudBadge = comp<MudBlazor.MudBadge>

module mudBadgeAttrs =
    let inline origin (p: MudBlazor.Origin) = "Origin" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline dot (p: System.Boolean) = "Dot" => p
    let inline overlap (p: System.Boolean) = "Overlap" => p
    let inline bordered (p: System.Boolean) = "Bordered" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline max (p: System.Int32) = "Max" => p
    let inline content (p: System.Object) = "Content" => p
    let inline badgeClass (p: System.String) = "BadgeClass" => p
    let inline badgeAriaLabel (p: System.String) = "BadgeAriaLabel" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let breadcrumbLink = comp<MudBlazor.BreadcrumbLink>

module breadcrumbLinkAttrs =
    let inline item (p: MudBlazor.BreadcrumbItem) = "Item" => p

let breadcrumbSeparator = comp<MudBlazor.BreadcrumbSeparator>
let mudBreadcrumbs = comp<MudBlazor.MudBreadcrumbs>

module mudBreadcrumbsAttrs =
    let inline items (p: System.Collections.Generic.IReadOnlyList<MudBlazor.BreadcrumbItem>) = "Items" => p
    let inline separator (p: System.String) = "Separator" => p
    let inline separatorTemplate p = attr.fragment "SeparatorTemplate" p

    let inline itemTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.BreadcrumbItem -> Bolero.Node) =
        attr.fragmentWith "ItemTemplate" p

    let inline maxItems (p: System.Nullable<System.Byte>) = "MaxItems" => p
    let inline expanderIcon (p: System.String) = "ExpanderIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudBreakpointProvider = comp<MudBlazor.MudBreakpointProvider>

module mudBreakpointProviderAttrs =
    let inline onOnBreakpointChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.Breakpoint> "OnBreakpointChanged" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudButton = comp<MudBlazor.MudButton>

module mudButtonAttrs =
    let inline startIcon (p: System.String) = "StartIcon" => p
    let inline endIcon (p: System.String) = "EndIcon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline iconSize (p: System.Nullable<MudBlazor.Size>) = "IconSize" => p
    let inline iconClass (p: System.String) = "IconClass" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline htmlTag (p: System.String) = "HtmlTag" => p
    let inline buttonType (p: MudBlazor.ButtonType) = "ButtonType" => p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline rel (p: System.String) = "Rel" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline clickPropagation (p: System.Boolean) = "ClickPropagation" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudFab = comp<MudBlazor.MudFab>

module mudFabAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline startIcon (p: System.String) = "StartIcon" => p
    let inline endIcon (p: System.String) = "EndIcon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline label (p: System.String) = "Label" => p
    let inline htmlTag (p: System.String) = "HtmlTag" => p
    let inline buttonType (p: MudBlazor.ButtonType) = "ButtonType" => p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline rel (p: System.String) = "Rel" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline clickPropagation (p: System.Boolean) = "ClickPropagation" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudIconButton = comp<MudBlazor.MudIconButton>

module mudIconButtonAttrs =
    let inline icon (p: System.String) = "Icon" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline edge (p: MudBlazor.Edge) = "Edge" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline htmlTag (p: System.String) = "HtmlTag" => p
    let inline buttonType (p: MudBlazor.ButtonType) = "ButtonType" => p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline rel (p: System.String) = "Rel" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline clickPropagation (p: System.Boolean) = "ClickPropagation" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudToggleIconButton = comp<MudBlazor.MudToggleIconButton>

module mudToggleIconButtonAttrs =
    let inline toggled (p: System.Boolean) = "Toggled" => p

    let inline onToggledChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ToggledChanged" p

    let inline icon (p: System.String) = "Icon" => p
    let inline toggledIcon (p: System.String) = "ToggledIcon" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline toggledColor (p: System.Nullable<MudBlazor.Color>) = "ToggledColor" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline toggledSize (p: System.Nullable<MudBlazor.Size>) = "ToggledSize" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline toggledVariant (p: System.Nullable<MudBlazor.Variant>) = "ToggledVariant" => p
    let inline edge (p: MudBlazor.Edge) = "Edge" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline clickPropagation (p: System.Boolean) = "ClickPropagation" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudButtonGroup = comp<MudBlazor.MudButtonGroup>

module mudButtonGroupAttrs =
    let inline overrideStyles (p: System.Boolean) = "OverrideStyles" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline vertical (p: System.Boolean) = "Vertical" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCard = comp<MudBlazor.MudCard>

module mudCardAttrs =
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCardActions = comp<MudBlazor.MudCardActions>

module mudCardActionsAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCardContent = comp<MudBlazor.MudCardContent>

module mudCardContentAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCardHeader = comp<MudBlazor.MudCardHeader>

module mudCardHeaderAttrs =
    let inline cardHeaderAvatar p = attr.fragment "CardHeaderAvatar" p
    let inline cardHeaderContent p = attr.fragment "CardHeaderContent" p
    let inline cardHeaderActions p = attr.fragment "CardHeaderActions" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCardMedia = comp<MudBlazor.MudCardMedia>

module mudCardMediaAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline image (p: System.String) = "Image" => p
    let inline height (p: System.Int32) = "Height" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCarousel<'TData3> = comp<MudBlazor.MudCarousel<'TData3>>

module mudCarouselAttrs =
    let inline showArrows (p: System.Boolean) = "ShowArrows" => p
    let inline arrowsPosition (p: MudBlazor.Position) = "ArrowsPosition" => p
    let inline showBullets (p: System.Boolean) = "ShowBullets" => p
    let inline bulletsPosition (p: MudBlazor.Position) = "BulletsPosition" => p
    let inline bulletsColor (p: System.Nullable<MudBlazor.Color>) = "BulletsColor" => p
    let inline autoCycle (p: System.Boolean) = "AutoCycle" => p
    let inline autoCycleTime (p: System.TimeSpan) = "AutoCycleTime" => p
    let inline navigationButtonsClass (p: System.String) = "NavigationButtonsClass" => p
    let inline bulletsClass (p: System.String) = "BulletsClass" => p
    let inline previousIcon (p: System.String) = "PreviousIcon" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline uncheckedIcon (p: System.String) = "UncheckedIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline nextButtonTemplate p = attr.fragment "NextButtonTemplate" p

    let inline previousButtonTemplate p =
        attr.fragment "PreviousButtonTemplate" p

    let inline bulletTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Boolean -> Bolero.Node) =
        attr.fragmentWith "BulletTemplate" p

    let inline enableSwipeGesture (p: System.Boolean) = "EnableSwipeGesture" => p
    let inline itemsSource<'TData3> (p: System.Collections.Generic.IEnumerable<'TData3>) = "ItemsSource" => p

    let inline itemTemplate<'TData3> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'TData3 -> Bolero.Node) =
        attr.fragmentWith "ItemTemplate" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCarouselItem = comp<MudBlazor.MudCarouselItem>

module mudCarouselItemAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline transition (p: MudBlazor.Transition) = "Transition" => p
    let inline customTransitionEnter (p: System.String) = "CustomTransitionEnter" => p
    let inline customTransitionExit (p: System.String) = "CustomTransitionExit" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChart = comp<MudBlazor.MudChart>

module mudChartAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudHeatMapCell = comp<MudBlazor.MudHeatMapCell>

module mudHeatMapCellAttrs =
    let inline row (p: System.Int32) = "Row" => p
    let inline column (p: System.Int32) = "Column" => p
    let inline value (p: System.Nullable<System.Double>) = "Value" => p
    let inline mudColor (p: MudBlazor.Utilities.MudColor) = "MudColor" => p
    let inline width (p: System.Nullable<System.Int32>) = "Width" => p
    let inline height (p: System.Nullable<System.Int32>) = "Height" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChat = comp<MudBlazor.MudChat>

module mudChatAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline chatPosition (p: MudBlazor.ChatBubblePosition) = "ChatPosition" => p
    let inline arrowPosition (p: MudBlazor.ChatArrowPosition) = "ArrowPosition" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChatBubble = comp<MudBlazor.MudChatBubble>

module mudChatBubbleAttrs =
    let inline color (p: System.Nullable<MudBlazor.Color>) = "Color" => p
    let inline variant (p: System.Nullable<MudBlazor.Variant>) = "Variant" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline onOnContextClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnContextClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChatFooter = comp<MudBlazor.MudChatFooter>

module mudChatFooterAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChatHeader = comp<MudBlazor.MudChatHeader>

module mudChatHeaderAttrs =
    let inline name (p: System.String) = "Name" => p
    let inline time (p: System.String) = "Time" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCheckBox<'T4> = comp<MudBlazor.MudCheckBox<'T4>>

module mudCheckBoxAttrs =
    let inline uncheckedColor (p: System.Nullable<MudBlazor.Color>) = "UncheckedColor" => p
    let inline keyboardEnabled (p: System.Boolean) = "KeyboardEnabled" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline uncheckedIcon (p: System.String) = "UncheckedIcon" => p
    let inline indeterminateIcon (p: System.String) = "IndeterminateIcon" => p
    let inline triState (p: System.Boolean) = "TriState" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline value (p: 'T4) = "Value" => p
    let inline stopClickPropagation (p: System.Boolean) = "StopClickPropagation" => p
    let inline labelPlacement (p: MudBlazor.Placement) = "LabelPlacement" => p
    let inline label (p: System.String) = "Label" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onValueChanged<'T4> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T4> "ValueChanged" p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T4> (p: MudBlazor.Converter<'T4, System.Nullable<System.Boolean>>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T4> (p: System.Linq.Expressions.Expression<System.Func<'T4>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChip<'T5> = comp<MudBlazor.MudChip<'T5>>

module mudChipAttrs =
    let inline color (p: System.Nullable<MudBlazor.Color>) = "Color" => p
    let inline selectedColor (p: System.Nullable<MudBlazor.Color>) = "SelectedColor" => p
    let inline size (p: System.Nullable<MudBlazor.Size>) = "Size" => p
    let inline variant (p: System.Nullable<MudBlazor.Variant>) = "Variant" => p
    let inline avatarContent p = attr.fragment "AvatarContent" p
    let inline label (p: System.Nullable<System.Boolean>) = "Label" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline iconColor (p: System.Nullable<MudBlazor.Color>) = "IconColor" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline ripple (p: System.Nullable<System.Boolean>) = "Ripple" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline rel (p: System.String) = "Rel" => p
    let inline text (p: System.String) = "Text" => p
    let inline value (p: 'T5) = "Value" => p
    let inline ``default`` (p: System.Nullable<System.Boolean>) = "Default" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline onOnClose<'T5> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.MudChip<'T5>> "OnClose" p

    let inline selected (p: System.Boolean) = "Selected" => p

    let inline onSelectedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "SelectedChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudChipSet<'T6> = comp<MudBlazor.MudChipSet<'T6>>

module mudChipSetAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline selectionMode (p: MudBlazor.SelectionMode) = "SelectionMode" => p
    let inline allClosable (p: System.Boolean) = "AllClosable" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline selectedColor (p: MudBlazor.Color) = "SelectedColor" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline checkMark (p: System.Boolean) = "CheckMark" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline label (p: System.Boolean) = "Label" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline comparer<'T6> (p: System.Collections.Generic.IEqualityComparer<'T6>) = "Comparer" => p
    let inline selectedValue (p: 'T6) = "SelectedValue" => p

    let inline onSelectedValueChanged<'T6> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T6> "SelectedValueChanged" p

    let inline selectedValues<'T6> (p: System.Collections.Generic.IReadOnlyCollection<'T6>) = "SelectedValues" => p

    let inline onSelectedValuesChanged<'T6> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IReadOnlyCollection<'T6>> "SelectedValuesChanged" p

    let inline onOnClose<'T6> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.MudChip<'T6>> "OnClose" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudCollapse = comp<MudBlazor.MudCollapse>

module mudCollapseAttrs =
    let inline expanded (p: System.Boolean) = "Expanded" => p
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onAnimationEnd (p: Microsoft.AspNetCore.Components.EventCallback) = "OnAnimationEnd" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudColorPicker = comp<MudBlazor.MudColorPicker>

module mudColorPickerAttrs =
    let inline showAlpha (p: System.Boolean) = "ShowAlpha" => p
    let inline showColorField (p: System.Boolean) = "ShowColorField" => p
    let inline showModeSwitch (p: System.Boolean) = "ShowModeSwitch" => p
    let inline showInputs (p: System.Boolean) = "ShowInputs" => p
    let inline showSliders (p: System.Boolean) = "ShowSliders" => p
    let inline showPreview (p: System.Boolean) = "ShowPreview" => p
    let inline colorPickerMode (p: MudBlazor.ColorPickerMode) = "ColorPickerMode" => p
    let inline colorPickerView (p: MudBlazor.ColorPickerView) = "ColorPickerView" => p
    let inline updateBindingIfOnlyHSLChanged (p: System.Boolean) = "UpdateBindingIfOnlyHSLChanged" => p
    let inline value (p: MudBlazor.Utilities.MudColor) = "Value" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.Utilities.MudColor> "ValueChanged" p

    let inline palette (p: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = "Palette" => p
    let inline dragEffect (p: System.Boolean) = "DragEffect" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline spectrumIcon (p: System.String) = "SpectrumIcon" => p
    let inline gridIcon (p: System.String) = "GridIcon" => p
    let inline paletteIcon (p: System.String) = "PaletteIcon" => p
    let inline importExportIcon (p: System.String) = "ImportExportIcon" => p
    let inline throttleInterval (p: System.Int32) = "ThrottleInterval" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline pickerOpened (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => p
    let inline pickerClosed (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => p
    let inline elevation (p: System.Nullable<System.Int32>) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline label (p: System.String) = "Label" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline editable (p: System.Boolean) = "Editable" => p
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline toolbarClass (p: System.String) = "ToolbarClass" => p
    let inline pickerVariant (p: MudBlazor.PickerVariant) = "PickerVariant" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline orientation (p: MudBlazor.Orientation) = "Orientation" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline color (p: MudBlazor.Color) = "Color" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline immediateText (p: System.Boolean) = "ImmediateText" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline text (p: System.String) = "Text" => p
    let inline actionsClass (p: System.String) = "ActionsClass" => p

    let inline pickerActions
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudPicker<MudBlazor.Utilities.MudColor> -> Bolero.Node)
        =
        attr.fragmentWith "PickerActions" p

    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline overflowBehavior (p: MudBlazor.OverflowBehavior) = "OverflowBehavior" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter (p: MudBlazor.Converter<MudBlazor.Utilities.MudColor, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for`` (p: System.Linq.Expressions.Expression<System.Func<MudBlazor.Utilities.MudColor>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let filterHeaderCell<'T7> = comp<MudBlazor.FilterHeaderCell<'T7>>

module filterHeaderCellAttrs =
    let inline column<'T7> (p: MudBlazor.Column<'T7>) = "Column" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let footerCell<'T8> = comp<MudBlazor.FooterCell<'T8>>

module footerCellAttrs =
    let inline column<'T8> (p: MudBlazor.Column<'T8>) = "Column" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline currentItems<'T8> (p: System.Collections.Generic.IEnumerable<'T8>) = "CurrentItems" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let headerCell<'T9> = comp<MudBlazor.HeaderCell<'T9>>

module headerCellAttrs =
    let inline column<'T9> (p: MudBlazor.Column<'T9>) = "Column" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline sortDirection (p: MudBlazor.SortDirection) = "SortDirection" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let hierarchyColumn<'T10> = comp<MudBlazor.HierarchyColumn<'T10>>

module hierarchyColumnAttrs =
    let inline closedIcon (p: System.String) = "ClosedIcon" => p
    let inline openIcon (p: System.String) = "OpenIcon" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline buttonDisabledFunc<'T10> (p: System.Func<'T10, System.Boolean>) = "ButtonDisabledFunc" => p
    let inline dragAndDropEnabled (p: System.Nullable<System.Boolean>) = "DragAndDropEnabled" => p
    let inline hideable (p: System.Nullable<System.Boolean>) = "Hideable" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p

    let inline onHiddenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "HiddenChanged" p

    let inline initiallyExpandedFunc<'T10> (p: System.Func<'T10, System.Boolean>) = "InitiallyExpandedFunc" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDataGrid<'T11> = comp<MudBlazor.MudDataGrid<'T11>>

module mudDataGridAttrs =
    let inline onSelectedItemChanged<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T11> "SelectedItemChanged" p

    let inline onSelectedItemsChanged<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.HashSet<'T11>> "SelectedItemsChanged" p

    let inline onRowClick<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.DataGridRowClickEventArgs<'T11>> "RowClick" p

    let inline onRowContextMenuClick<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.DataGridRowClickEventArgs<'T11>> "RowContextMenuClick" p

    let inline onStartedEditingItem<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T11> "StartedEditingItem" p

    let inline onCanceledEditingItem<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T11> "CanceledEditingItem" p

    let inline onCommittedItemChanges<'T11> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T11> "CommittedItemChanges" p

    let inline onFormFieldChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.Utilities.FormFieldChangedEventArgs> "FormFieldChanged" p

    let inline columnsPanelReordering (p: System.Boolean) = "ColumnsPanelReordering" => p
    let inline dragDropColumnReordering (p: System.Boolean) = "DragDropColumnReordering" => p
    let inline dragIndicatorIcon (p: System.String) = "DragIndicatorIcon" => p
    let inline dragIndicatorSize (p: MudBlazor.Size) = "DragIndicatorSize" => p
    let inline dropAllowedClass (p: System.String) = "DropAllowedClass" => p
    let inline dropNotAllowedClass (p: System.String) = "DropNotAllowedClass" => p
    let inline applyDropClassesOnDragStarted (p: System.Boolean) = "ApplyDropClassesOnDragStarted" => p
    let inline sortMode (p: MudBlazor.SortMode) = "SortMode" => p
    let inline filterable (p: System.Boolean) = "Filterable" => p
    let inline hideable (p: System.Boolean) = "Hideable" => p
    let inline showColumnOptions (p: System.Boolean) = "ShowColumnOptions" => p
    let inline breakpoint (p: MudBlazor.Breakpoint) = "Breakpoint" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline bordered (p: System.Boolean) = "Bordered" => p
    let inline colGroup p = attr.fragment "ColGroup" p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline hover (p: System.Boolean) = "Hover" => p
    let inline striped (p: System.Boolean) = "Striped" => p
    let inline fixedHeader (p: System.Boolean) = "FixedHeader" => p
    let inline fixedFooter (p: System.Boolean) = "FixedFooter" => p
    let inline showFilterIcons (p: System.Boolean) = "ShowFilterIcons" => p
    let inline filterMode (p: MudBlazor.DataGridFilterMode) = "FilterMode" => p
    let inline filterCaseSensitivity (p: MudBlazor.DataGridFilterCaseSensitivity) = "FilterCaseSensitivity" => p

    let inline filterTemplate<'T11>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudDataGrid<'T11> -> Bolero.Node)
        =
        attr.fragmentWith "FilterTemplate" p

    let inline filterDefinitions<'T11> (p: System.Collections.Generic.List<MudBlazor.IFilterDefinition<'T11>>) =
        "FilterDefinitions" => p

    let inline sortDefinitions<'T11>
        (p: System.Collections.Generic.Dictionary<System.String, MudBlazor.SortDefinition<'T11>>)
        =
        "SortDefinitions" => p

    let inline virtualize (p: System.Boolean) = "Virtualize" => p
    let inline rowLoadingContent p = attr.fragment "RowLoadingContent" p
    let inline overscanCount (p: System.Int32) = "OverscanCount" => p
    let inline itemSize (p: System.Single) = "ItemSize" => p
    let inline rowClass (p: System.String) = "RowClass" => p
    let inline rowStyle (p: System.String) = "RowStyle" => p
    let inline rowClassFunc<'T11> (p: System.Func<'T11, System.Int32, System.String>) = "RowClassFunc" => p
    let inline rowStyleFunc<'T11> (p: System.Func<'T11, System.Int32, System.String>) = "RowStyleFunc" => p
    let inline multiSelection (p: System.Boolean) = "MultiSelection" => p
    let inline selectOnRowClick (p: System.Boolean) = "SelectOnRowClick" => p
    let inline editMode (p: System.Nullable<MudBlazor.DataGridEditMode>) = "EditMode" => p
    let inline editTrigger (p: System.Nullable<MudBlazor.DataGridEditTrigger>) = "EditTrigger" => p
    let inline editDialogOptions (p: MudBlazor.DialogOptions) = "EditDialogOptions" => p
    let inline cloneStrategy<'T11> (p: MudBlazor.Utilities.Clone.ICloneStrategy<'T11>) = "CloneStrategy" => p
    let inline items<'T11> (p: System.Collections.Generic.IEnumerable<'T11>) = "Items" => p
    let inline loading (p: System.Boolean) = "Loading" => p
    let inline canCancelEdit (p: System.Boolean) = "CanCancelEdit" => p
    let inline loadingProgressColor (p: MudBlazor.Color) = "LoadingProgressColor" => p
    let inline toolBarContent p = attr.fragment "ToolBarContent" p
    let inline horizontalScrollbar (p: System.Boolean) = "HorizontalScrollbar" => p
    let inline columnResizeMode (p: MudBlazor.ResizeMode) = "ColumnResizeMode" => p
    let inline headerClass (p: System.String) = "HeaderClass" => p
    let inline height (p: System.String) = "Height" => p
    let inline footerClass (p: System.String) = "FooterClass" => p
    let inline quickFilter<'T11> (p: System.Func<'T11, System.Boolean>) = "QuickFilter" => p
    let inline header p = attr.fragment "Header" p
    let inline columns p = attr.fragment "Columns" p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p

    let inline childRowContent<'T11>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.CellContext<'T11> -> Bolero.Node)
        =
        attr.fragmentWith "ChildRowContent" p

    let inline noRecordsContent p = attr.fragment "NoRecordsContent" p
    let inline loadingContent p = attr.fragment "LoadingContent" p
    let inline pagerContent p = attr.fragment "PagerContent" p

    let inline serverData<'T11>
        (p: System.Func<MudBlazor.GridState<'T11>, System.Threading.Tasks.Task<MudBlazor.GridData<'T11>>>)
        =
        "ServerData" => p

    let inline virtualizeServerData<'T11>
        (p:
            System.Func<
                MudBlazor.GridStateVirtualize<'T11>,
                System.Threading.CancellationToken,
                System.Threading.Tasks.Task<MudBlazor.GridData<'T11>>
             >)
        =
        "VirtualizeServerData" => p

    let inline rowsPerPage (p: System.Int32) = "RowsPerPage" => p

    let inline onRowsPerPageChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "RowsPerPageChanged" p

    let inline currentPage (p: System.Int32) = "CurrentPage" => p

    let inline onCurrentPageChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "CurrentPageChanged" p

    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline selectedItems<'T11> (p: System.Collections.Generic.HashSet<'T11>) = "SelectedItems" => p
    let inline selectedItem (p: 'T11) = "SelectedItem" => p
    let inline groupable (p: System.Boolean) = "Groupable" => p
    let inline groupExpanded (p: System.Boolean) = "GroupExpanded" => p
    let inline groupClass (p: System.String) = "GroupClass" => p
    let inline groupStyle (p: System.String) = "GroupStyle" => p

    let inline groupClassFunc<'T11> (p: System.Func<MudBlazor.GroupDefinition<'T11>, System.String>) =
        "GroupClassFunc" => p

    let inline groupStyleFunc<'T11> (p: System.Func<MudBlazor.GroupDefinition<'T11>, System.String>) =
        "GroupStyleFunc" => p

    let inline showMenuIcon (p: System.Boolean) = "ShowMenuIcon" => p
    let inline comparer<'T11> (p: System.Collections.Generic.IEqualityComparer<'T11>) = "Comparer" => p
    let inline validator (p: MudBlazor.Interfaces.IForm) = "Validator" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDataGridPager<'T12> = comp<MudBlazor.MudDataGridPager<'T12>>

module mudDataGridPagerAttrs =
    let inline pageSizeSelector (p: System.Boolean) = "PageSizeSelector" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline pageSizeOptions (p: System.Int32[]) = "PageSizeOptions" => p
    let inline infoFormat (p: System.String) = "InfoFormat" => p
    let inline rowsPerPageString (p: System.String) = "RowsPerPageString" => p
    let inline showNavigation (p: System.Boolean) = "ShowNavigation" => p
    let inline showPageNumber (p: System.Boolean) = "ShowPageNumber" => p
    let inline allItemsText (p: System.String) = "AllItemsText" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let propertyColumn<'T13, 'TProperty14> =
    comp<MudBlazor.PropertyColumn<'T13, 'TProperty14>>

module propertyColumnAttrs =
    let inline property<'T13, 'TProperty14> (p: System.Linq.Expressions.Expression<System.Func<'T13, 'TProperty14>>) =
        "Property" => p

    let inline format (p: System.String) = "Format" => p
    let inline value (p: 'T13) = "Value" => p
    let inline onValueChanged<'T13> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T13> "ValueChanged" p
    let inline title (p: System.String) = "Title" => p
    let inline hideSmall (p: System.Boolean) = "HideSmall" => p
    let inline footerColSpan (p: System.Int32) = "FooterColSpan" => p
    let inline headerColSpan (p: System.Int32) = "HeaderColSpan" => p

    let inline headerTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.HeaderContext<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "HeaderTemplate" p

    let inline cellTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.CellContext<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "CellTemplate" p

    let inline footerTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.FooterContext<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "FooterTemplate" p

    let inline groupTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.GroupDefinition<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "GroupTemplate" p

    let inline aggregateTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Collections.Generic.IEnumerable<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "AggregateTemplate" p

    let inline groupBy<'T13> (p: System.Func<'T13, System.Object>) = "GroupBy" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline headerClass (p: System.String) = "HeaderClass" => p

    let inline headerClassFunc<'T13> (p: System.Func<System.Collections.Generic.IEnumerable<'T13>, System.String>) =
        "HeaderClassFunc" => p

    let inline headerStyle (p: System.String) = "HeaderStyle" => p

    let inline headerStyleFunc<'T13> (p: System.Func<System.Collections.Generic.IEnumerable<'T13>, System.String>) =
        "HeaderStyleFunc" => p

    let inline sortable (p: System.Nullable<System.Boolean>) = "Sortable" => p
    let inline resizable (p: System.Nullable<System.Boolean>) = "Resizable" => p
    let inline dragAndDropEnabled (p: System.Nullable<System.Boolean>) = "DragAndDropEnabled" => p
    let inline filterable (p: System.Nullable<System.Boolean>) = "Filterable" => p
    let inline showFilterIcon (p: System.Nullable<System.Boolean>) = "ShowFilterIcon" => p
    let inline hideable (p: System.Nullable<System.Boolean>) = "Hideable" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p

    let inline onHiddenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "HiddenChanged" p

    let inline showColumnOptions (p: System.Nullable<System.Boolean>) = "ShowColumnOptions" => p
    let inline comparer (p: System.Collections.Generic.IComparer<System.Object>) = "Comparer" => p
    let inline sortBy<'T13> (p: System.Func<'T13, System.Object>) = "SortBy" => p
    let inline initialDirection (p: MudBlazor.SortDirection) = "InitialDirection" => p
    let inline sortIcon (p: System.String) = "SortIcon" => p
    let inline groupable (p: System.Nullable<System.Boolean>) = "Groupable" => p
    let inline grouping (p: System.Boolean) = "Grouping" => p

    let inline onGroupingChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "GroupingChanged" p

    let inline stickyLeft (p: System.Boolean) = "StickyLeft" => p
    let inline stickyRight (p: System.Boolean) = "StickyRight" => p

    let inline filterTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.FilterContext<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "FilterTemplate" p

    let inline filterOperators (p: System.Collections.Generic.HashSet<System.String>) = "FilterOperators" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline cellClass (p: System.String) = "CellClass" => p
    let inline cellClassFunc<'T13> (p: System.Func<'T13, System.String>) = "CellClassFunc" => p
    let inline cellStyle (p: System.String) = "CellStyle" => p
    let inline cellStyleFunc<'T13> (p: System.Func<'T13, System.String>) = "CellStyleFunc" => p
    let inline editable (p: System.Boolean) = "Editable" => p

    let inline editTemplate<'T13>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.CellContext<'T13> -> Bolero.Node)
        =
        attr.fragmentWith "EditTemplate" p

    let inline footerClass (p: System.String) = "FooterClass" => p

    let inline footerClassFunc<'T13> (p: System.Func<System.Collections.Generic.IEnumerable<'T13>, System.String>) =
        "FooterClassFunc" => p

    let inline footerStyle (p: System.String) = "FooterStyle" => p

    let inline footerStyleFunc<'T13> (p: System.Func<System.Collections.Generic.IEnumerable<'T13>, System.String>) =
        "FooterStyleFunc" => p

    let inline enableFooterSelection (p: System.Boolean) = "EnableFooterSelection" => p
    let inline aggregateDefinition<'T13> (p: MudBlazor.AggregateDefinition<'T13>) = "AggregateDefinition" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let selectColumn<'T15> = comp<MudBlazor.SelectColumn<'T15>>

module selectColumnAttrs =
    let inline showInHeader (p: System.Boolean) = "ShowInHeader" => p
    let inline showInFooter (p: System.Boolean) = "ShowInFooter" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline dragAndDropEnabled (p: System.Nullable<System.Boolean>) = "DragAndDropEnabled" => p
    let inline hideable (p: System.Nullable<System.Boolean>) = "Hideable" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p

    let inline onHiddenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "HiddenChanged" p

let templateColumn<'T16> = comp<MudBlazor.TemplateColumn<'T16>>

module templateColumnAttrs =
    let inline filterable (p: System.Nullable<System.Boolean>) = "Filterable" => p
    let inline sortable (p: System.Nullable<System.Boolean>) = "Sortable" => p
    let inline dragAndDropEnabled (p: System.Nullable<System.Boolean>) = "DragAndDropEnabled" => p
    let inline resizable (p: System.Nullable<System.Boolean>) = "Resizable" => p
    let inline showColumnOptions (p: System.Nullable<System.Boolean>) = "ShowColumnOptions" => p
    let inline value (p: 'T16) = "Value" => p
    let inline onValueChanged<'T16> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T16> "ValueChanged" p
    let inline title (p: System.String) = "Title" => p
    let inline hideSmall (p: System.Boolean) = "HideSmall" => p
    let inline footerColSpan (p: System.Int32) = "FooterColSpan" => p
    let inline headerColSpan (p: System.Int32) = "HeaderColSpan" => p

    let inline headerTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.HeaderContext<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "HeaderTemplate" p

    let inline cellTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.CellContext<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "CellTemplate" p

    let inline footerTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.FooterContext<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "FooterTemplate" p

    let inline groupTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.GroupDefinition<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "GroupTemplate" p

    let inline aggregateTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Collections.Generic.IEnumerable<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "AggregateTemplate" p

    let inline groupBy<'T16> (p: System.Func<'T16, System.Object>) = "GroupBy" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline headerClass (p: System.String) = "HeaderClass" => p

    let inline headerClassFunc<'T16> (p: System.Func<System.Collections.Generic.IEnumerable<'T16>, System.String>) =
        "HeaderClassFunc" => p

    let inline headerStyle (p: System.String) = "HeaderStyle" => p

    let inline headerStyleFunc<'T16> (p: System.Func<System.Collections.Generic.IEnumerable<'T16>, System.String>) =
        "HeaderStyleFunc" => p

    let inline showFilterIcon (p: System.Nullable<System.Boolean>) = "ShowFilterIcon" => p
    let inline hideable (p: System.Nullable<System.Boolean>) = "Hideable" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p

    let inline onHiddenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "HiddenChanged" p

    let inline comparer (p: System.Collections.Generic.IComparer<System.Object>) = "Comparer" => p
    let inline sortBy<'T16> (p: System.Func<'T16, System.Object>) = "SortBy" => p
    let inline initialDirection (p: MudBlazor.SortDirection) = "InitialDirection" => p
    let inline sortIcon (p: System.String) = "SortIcon" => p
    let inline groupable (p: System.Nullable<System.Boolean>) = "Groupable" => p
    let inline grouping (p: System.Boolean) = "Grouping" => p

    let inline onGroupingChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "GroupingChanged" p

    let inline stickyLeft (p: System.Boolean) = "StickyLeft" => p
    let inline stickyRight (p: System.Boolean) = "StickyRight" => p

    let inline filterTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.FilterContext<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "FilterTemplate" p

    let inline filterOperators (p: System.Collections.Generic.HashSet<System.String>) = "FilterOperators" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline cellClass (p: System.String) = "CellClass" => p
    let inline cellClassFunc<'T16> (p: System.Func<'T16, System.String>) = "CellClassFunc" => p
    let inline cellStyle (p: System.String) = "CellStyle" => p
    let inline cellStyleFunc<'T16> (p: System.Func<'T16, System.String>) = "CellStyleFunc" => p
    let inline editable (p: System.Boolean) = "Editable" => p

    let inline editTemplate<'T16>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.CellContext<'T16> -> Bolero.Node)
        =
        attr.fragmentWith "EditTemplate" p

    let inline footerClass (p: System.String) = "FooterClass" => p

    let inline footerClassFunc<'T16> (p: System.Func<System.Collections.Generic.IEnumerable<'T16>, System.String>) =
        "FooterClassFunc" => p

    let inline footerStyle (p: System.String) = "FooterStyle" => p

    let inline footerStyleFunc<'T16> (p: System.Func<System.Collections.Generic.IEnumerable<'T16>, System.String>) =
        "FooterStyleFunc" => p

    let inline enableFooterSelection (p: System.Boolean) = "EnableFooterSelection" => p
    let inline aggregateDefinition<'T16> (p: MudBlazor.AggregateDefinition<'T16>) = "AggregateDefinition" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDatePicker = comp<MudBlazor.MudDatePicker>

module mudDatePickerAttrs =
    let inline onDateChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.DateTime>> "DateChanged" p

    let inline date (p: System.Nullable<System.DateTime>) = "Date" => p
    let inline maxDate (p: System.Nullable<System.DateTime>) = "MaxDate" => p
    let inline minDate (p: System.Nullable<System.DateTime>) = "MinDate" => p
    let inline openTo (p: MudBlazor.OpenTo) = "OpenTo" => p
    let inline dateFormat (p: System.String) = "DateFormat" => p
    let inline firstDayOfWeek (p: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => p
    let inline pickerMonth (p: System.Nullable<System.DateTime>) = "PickerMonth" => p

    let inline onPickerMonthChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" p

    let inline closingDelay (p: System.Int32) = "ClosingDelay" => p
    let inline displayMonths (p: System.Int32) = "DisplayMonths" => p
    let inline maxMonthColumns (p: System.Nullable<System.Int32>) = "MaxMonthColumns" => p
    let inline startMonth (p: System.Nullable<System.DateTime>) = "StartMonth" => p
    let inline showWeekNumbers (p: System.Boolean) = "ShowWeekNumbers" => p
    let inline titleDateFormat (p: System.String) = "TitleDateFormat" => p
    let inline autoClose (p: System.Boolean) = "AutoClose" => p
    let inline isDateDisabledFunc (p: System.Func<System.DateTime, System.Boolean>) = "IsDateDisabledFunc" => p

    let inline additionalDateClassesFunc (p: System.Func<System.DateTime, System.String>) =
        "AdditionalDateClassesFunc" => p

    let inline previousIcon (p: System.String) = "PreviousIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline fixYear (p: System.Nullable<System.Int32>) = "FixYear" => p
    let inline fixMonth (p: System.Nullable<System.Int32>) = "FixMonth" => p
    let inline fixDay (p: System.Nullable<System.Int32>) = "FixDay" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline pickerOpened (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => p
    let inline pickerClosed (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => p
    let inline elevation (p: System.Nullable<System.Int32>) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline label (p: System.String) = "Label" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline editable (p: System.Boolean) = "Editable" => p
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline toolbarClass (p: System.String) = "ToolbarClass" => p
    let inline pickerVariant (p: MudBlazor.PickerVariant) = "PickerVariant" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline orientation (p: MudBlazor.Orientation) = "Orientation" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline color (p: MudBlazor.Color) = "Color" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline immediateText (p: System.Boolean) = "ImmediateText" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline text (p: System.String) = "Text" => p
    let inline actionsClass (p: System.String) = "ActionsClass" => p

    let inline pickerActions
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p:
            MudBlazor.MudPicker<System.Nullable<System.DateTime>> -> Bolero.Node)
        =
        attr.fragmentWith "PickerActions" p

    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline overflowBehavior (p: MudBlazor.OverflowBehavior) = "OverflowBehavior" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter (p: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p

    let inline ``for`` (p: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) =
        "For" => p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDateRangePicker = comp<MudBlazor.MudDateRangePicker>

module mudDateRangePickerAttrs =
    let inline placeholderStart (p: System.String) = "PlaceholderStart" => p
    let inline placeholderEnd (p: System.String) = "PlaceholderEnd" => p
    let inline separatorIcon (p: System.String) = "SeparatorIcon" => p

    let inline onDateRangeChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.DateRange> "DateRangeChanged" p

    let inline dateRange (p: MudBlazor.DateRange) = "DateRange" => p
    let inline allowDisabledDatesInRange (p: System.Boolean) = "AllowDisabledDatesInRange" => p
    let inline maxDate (p: System.Nullable<System.DateTime>) = "MaxDate" => p
    let inline minDate (p: System.Nullable<System.DateTime>) = "MinDate" => p
    let inline openTo (p: MudBlazor.OpenTo) = "OpenTo" => p
    let inline dateFormat (p: System.String) = "DateFormat" => p
    let inline firstDayOfWeek (p: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => p
    let inline pickerMonth (p: System.Nullable<System.DateTime>) = "PickerMonth" => p

    let inline onPickerMonthChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" p

    let inline closingDelay (p: System.Int32) = "ClosingDelay" => p
    let inline displayMonths (p: System.Int32) = "DisplayMonths" => p
    let inline maxMonthColumns (p: System.Nullable<System.Int32>) = "MaxMonthColumns" => p
    let inline startMonth (p: System.Nullable<System.DateTime>) = "StartMonth" => p
    let inline showWeekNumbers (p: System.Boolean) = "ShowWeekNumbers" => p
    let inline titleDateFormat (p: System.String) = "TitleDateFormat" => p
    let inline autoClose (p: System.Boolean) = "AutoClose" => p
    let inline isDateDisabledFunc (p: System.Func<System.DateTime, System.Boolean>) = "IsDateDisabledFunc" => p

    let inline additionalDateClassesFunc (p: System.Func<System.DateTime, System.String>) =
        "AdditionalDateClassesFunc" => p

    let inline previousIcon (p: System.String) = "PreviousIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline fixYear (p: System.Nullable<System.Int32>) = "FixYear" => p
    let inline fixMonth (p: System.Nullable<System.Int32>) = "FixMonth" => p
    let inline fixDay (p: System.Nullable<System.Int32>) = "FixDay" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline pickerOpened (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => p
    let inline pickerClosed (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => p
    let inline elevation (p: System.Nullable<System.Int32>) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline label (p: System.String) = "Label" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline editable (p: System.Boolean) = "Editable" => p
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline toolbarClass (p: System.String) = "ToolbarClass" => p
    let inline pickerVariant (p: MudBlazor.PickerVariant) = "PickerVariant" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline orientation (p: MudBlazor.Orientation) = "Orientation" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline color (p: MudBlazor.Color) = "Color" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline immediateText (p: System.Boolean) = "ImmediateText" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline text (p: System.String) = "Text" => p
    let inline actionsClass (p: System.String) = "ActionsClass" => p

    let inline pickerActions
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p:
            MudBlazor.MudPicker<System.Nullable<System.DateTime>> -> Bolero.Node)
        =
        attr.fragmentWith "PickerActions" p

    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline overflowBehavior (p: MudBlazor.OverflowBehavior) = "OverflowBehavior" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter (p: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p

    let inline ``for`` (p: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) =
        "For" => p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDialog = comp<MudBlazor.MudDialog>

module mudDialogAttrs =
    let inline titleContent p = attr.fragment "TitleContent" p
    let inline dialogContent p = attr.fragment "DialogContent" p
    let inline dialogActions p = attr.fragment "DialogActions" p
    let inline options (p: MudBlazor.DialogOptions) = "Options" => p

    let inline onOnBackdropClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnBackdropClick" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline titleClass (p: System.String) = "TitleClass" => p
    let inline contentClass (p: System.String) = "ContentClass" => p
    let inline actionsClass (p: System.String) = "ActionsClass" => p
    let inline contentStyle (p: System.String) = "ContentStyle" => p
    let inline visible (p: System.Boolean) = "Visible" => p

    let inline onVisibleChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "VisibleChanged" p

    let inline defaultFocus (p: MudBlazor.DefaultFocus) = "DefaultFocus" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDialogContainer = comp<MudBlazor.MudDialogContainer>

module mudDialogContainerAttrs =
    let inline options (p: MudBlazor.DialogOptions) = "Options" => p
    let inline title (p: System.String) = "Title" => p
    let inline titleContent p = attr.fragment "TitleContent" p
    let inline content p = attr.fragment "Content" p
    let inline id (p: System.Guid) = "Id" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDialogProvider = comp<MudBlazor.MudDialogProvider>

module mudDialogProviderAttrs =
    let inline noHeader (p: System.Nullable<System.Boolean>) = "NoHeader" => p
    let inline closeButton (p: System.Nullable<System.Boolean>) = "CloseButton" => p
    let inline backdropClick (p: System.Nullable<System.Boolean>) = "BackdropClick" => p
    let inline closeOnEscapeKey (p: System.Nullable<System.Boolean>) = "CloseOnEscapeKey" => p
    let inline fullWidth (p: System.Nullable<System.Boolean>) = "FullWidth" => p
    let inline position (p: System.Nullable<MudBlazor.DialogPosition>) = "Position" => p
    let inline maxWidth (p: System.Nullable<MudBlazor.MaxWidth>) = "MaxWidth" => p
    let inline backgroundClass (p: System.String) = "BackgroundClass" => p

let mudDivider = comp<MudBlazor.MudDivider>

module mudDividerAttrs =
    let inline absolute (p: System.Boolean) = "Absolute" => p
    let inline flexItem (p: System.Boolean) = "FlexItem" => p
    let inline light (p: System.Boolean) = "Light" => p
    let inline vertical (p: System.Boolean) = "Vertical" => p
    let inline dividerType (p: MudBlazor.DividerType) = "DividerType" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDrawer = comp<MudBlazor.MudDrawer>

module mudDrawerAttrs =
    let inline ``fixed`` (p: System.Boolean) = "Fixed" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline anchor (p: MudBlazor.Anchor) = "Anchor" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline variant (p: MudBlazor.DrawerVariant) = "Variant" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline overlay (p: System.Boolean) = "Overlay" => p
    let inline overlayAutoClose (p: System.Boolean) = "OverlayAutoClose" => p
    let inline openMiniOnHover (p: System.Boolean) = "OpenMiniOnHover" => p
    let inline breakpoint (p: MudBlazor.Breakpoint) = "Breakpoint" => p
    let inline ``open`` (p: System.Boolean) = "Open" => p

    let inline onOpenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "OpenChanged" p

    let inline width (p: System.String) = "Width" => p
    let inline miniWidth (p: System.String) = "MiniWidth" => p
    let inline height (p: System.String) = "Height" => p
    let inline clipMode (p: MudBlazor.DrawerClipMode) = "ClipMode" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDrawerContainer = comp<MudBlazor.MudDrawerContainer>

module mudDrawerContainerAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDrawerHeader = comp<MudBlazor.MudDrawerHeader>

module mudDrawerHeaderAttrs =
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline linkToIndex (p: System.Boolean) = "LinkToIndex" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDropContainer<'T17> = comp<MudBlazor.MudDropContainer<'T17>>

module mudDropContainerAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline items<'T17> (p: System.Collections.Generic.IEnumerable<'T17>) = "Items" => p

    let inline itemRenderer<'T17> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T17 -> Bolero.Node) =
        attr.fragmentWith "ItemRenderer" p

    let inline itemsSelector<'T17> (p: System.Func<'T17, System.String, System.Boolean>) = "ItemsSelector" => p

    let inline onItemDropped<'T17> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.MudItemDropInfo<'T17>> "ItemDropped" p

    let inline onItemPicked<'T17> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.MudDragAndDropItemTransaction<'T17>> "ItemPicked" p

    let inline canDrop<'T17> (p: System.Func<'T17, System.String, System.Boolean>) = "CanDrop" => p
    let inline canDropClass (p: System.String) = "CanDropClass" => p
    let inline noDropClass (p: System.String) = "NoDropClass" => p
    let inline applyDropClassesOnDragStarted (p: System.Boolean) = "ApplyDropClassesOnDragStarted" => p
    let inline itemDisabled<'T17> (p: System.Func<'T17, System.Boolean>) = "ItemDisabled" => p
    let inline disabledClass (p: System.String) = "DisabledClass" => p
    let inline draggingClass (p: System.String) = "DraggingClass" => p
    let inline itemDraggingClass (p: System.String) = "ItemDraggingClass" => p
    let inline itemsClassSelector<'T17> (p: System.Func<'T17, System.String, System.String>) = "ItemsClassSelector" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDropZone<'T18> = comp<MudBlazor.MudDropZone<'T18>>

module mudDropZoneAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline identifier (p: System.String) = "Identifier" => p

    let inline itemRenderer<'T18> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T18 -> Bolero.Node) =
        attr.fragmentWith "ItemRenderer" p

    let inline itemsSelector<'T18> (p: System.Func<'T18, System.Boolean>) = "ItemsSelector" => p
    let inline canDrop<'T18> (p: System.Func<'T18, System.Boolean>) = "CanDrop" => p
    let inline canDropClass (p: System.String) = "CanDropClass" => p
    let inline noDropClass (p: System.String) = "NoDropClass" => p
    let inline applyDropClassesOnDragStarted (p: System.Nullable<System.Boolean>) = "ApplyDropClassesOnDragStarted" => p
    let inline itemDisabled<'T18> (p: System.Func<'T18, System.Boolean>) = "ItemDisabled" => p
    let inline disabledClass (p: System.String) = "DisabledClass" => p
    let inline draggingClass (p: System.String) = "DraggingClass" => p
    let inline itemDraggingClass (p: System.String) = "ItemDraggingClass" => p
    let inline itemsClassSelector<'T18> (p: System.Func<'T18, System.String>) = "ItemsClassSelector" => p
    let inline allowReorder (p: System.Boolean) = "AllowReorder" => p
    let inline onlyZone (p: System.Boolean) = "OnlyZone" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDynamicDropItem<'T19> = comp<MudBlazor.MudDynamicDropItem<'T19>>

module mudDynamicDropItemAttrs =
    let inline zoneIdentifier (p: System.String) = "ZoneIdentifier" => p
    let inline item (p: 'T19) = "Item" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline draggingClass (p: System.String) = "DraggingClass" => p

    let inline onOnDragStarted<'T19> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T19> "OnDragStarted" p

    let inline onOnDragEnded<'T19> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T19> "OnDragEnded" p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline disabledClass (p: System.String) = "DisabledClass" => p
    let inline index (p: System.Int32) = "Index" => p
    let inline hideContent (p: System.Boolean) = "HideContent" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudElement = comp<MudBlazor.MudElement>

module mudElementAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline htmlTag (p: System.String) = "HtmlTag" => p
    let inline ref (p: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "Ref" => p

    let inline onRefChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" p

    let inline clickPropagation (p: System.Boolean) = "ClickPropagation" => p
    let inline preventDefault (p: System.Boolean) = "PreventDefault" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudExpansionPanel = comp<MudBlazor.MudExpansionPanel>

module mudExpansionPanelAttrs =
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline headerClass (p: System.String) = "HeaderClass" => p
    let inline titleContent p = attr.fragment "TitleContent" p
    let inline text (p: System.String) = "Text" => p
    let inline hideIcon (p: System.Boolean) = "HideIcon" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline expanded (p: System.Boolean) = "Expanded" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudExpansionPanels = comp<MudBlazor.MudExpansionPanels>

module mudExpansionPanelsAttrs =
    let inline square (p: System.Boolean) = "Square" => p
    let inline multiExpansion (p: System.Boolean) = "MultiExpansion" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudField = comp<MudBlazor.MudField>

module mudFieldAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline label (p: System.String) = "Label" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline innerPadding (p: System.Boolean) = "InnerPadding" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudFileUpload<'T20> = comp<MudBlazor.MudFileUpload<'T20>>

module mudFileUploadAttrs =
    let inline files (p: 'T20) = "Files" => p
    let inline onFilesChanged<'T20> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T20> "FilesChanged" p

    let inline onOnFilesChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnFilesChanged" p

    let inline appendMultipleFiles (p: System.Boolean) = "AppendMultipleFiles" => p
    let inline activatorContent p = attr.fragment "ActivatorContent" p

    let inline selectedTemplate<'T20> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T20 -> Bolero.Node) =
        attr.fragmentWith "SelectedTemplate" p

    let inline suppressOnChangeWhenInvalid (p: System.Boolean) = "SuppressOnChangeWhenInvalid" => p
    let inline accept (p: System.String) = "Accept" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p
    let inline inputClass (p: System.String) = "InputClass" => p
    let inline inputStyle (p: System.String) = "InputStyle" => p
    let inline maximumFileCount (p: System.Int32) = "MaximumFileCount" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T20> (p: MudBlazor.Converter<'T20, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T20> (p: System.Linq.Expressions.Expression<System.Func<'T20>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudFocusTrap = comp<MudBlazor.MudFocusTrap>

module mudFocusTrapAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline defaultFocus (p: MudBlazor.DefaultFocus) = "DefaultFocus" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudForm = comp<MudBlazor.MudForm>

module mudFormAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline isValid (p: System.Boolean) = "IsValid" => p
    let inline isTouched (p: System.Boolean) = "IsTouched" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline validationDelay (p: System.Int32) = "ValidationDelay" => p
    let inline suppressRenderingOnValidation (p: System.Boolean) = "SuppressRenderingOnValidation" => p
    let inline suppressImplicitSubmission (p: System.Boolean) = "SuppressImplicitSubmission" => p
    let inline spacing (p: System.Int32) = "Spacing" => p

    let inline onIsValidChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "IsValidChanged" p

    let inline onIsTouchedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "IsTouchedChanged" p

    let inline onFieldChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.Utilities.FormFieldChangedEventArgs> "FieldChanged" p

    let inline validation (p: System.Object) = "Validation" => p
    let inline overrideFieldValidation (p: System.Nullable<System.Boolean>) = "OverrideFieldValidation" => p
    let inline errors (p: System.String[]) = "Errors" => p

    let inline onErrorsChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String[]> "ErrorsChanged" p

    let inline model (p: System.Object) = "Model" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudFlexBreak = comp<MudBlazor.MudFlexBreak>

module mudFlexBreakAttrs =
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudGrid = comp<MudBlazor.MudGrid>

module mudGridAttrs =
    let inline spacing (p: System.Int32) = "Spacing" => p
    let inline justify (p: MudBlazor.Justify) = "Justify" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudItem = comp<MudBlazor.MudItem>

module mudItemAttrs =
    let inline xs (p: System.Int32) = "xs" => p
    let inline sm (p: System.Int32) = "sm" => p
    let inline md (p: System.Int32) = "md" => p
    let inline lg (p: System.Int32) = "lg" => p
    let inline xl (p: System.Int32) = "xl" => p
    let inline xxl (p: System.Int32) = "xxl" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudHidden = comp<MudBlazor.MudHidden>

module mudHiddenAttrs =
    let inline breakpoint (p: MudBlazor.Breakpoint) = "Breakpoint" => p
    let inline invert (p: System.Boolean) = "Invert" => p
    let inline hidden (p: System.Boolean) = "Hidden" => p

    let inline onHiddenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "HiddenChanged" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudHighlighter = comp<MudBlazor.MudHighlighter>

module mudHighlighterAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline highlightedText (p: System.String) = "HighlightedText" => p
    let inline highlightedTexts (p: System.Collections.Generic.IEnumerable<System.String>) = "HighlightedTexts" => p
    let inline caseSensitive (p: System.Boolean) = "CaseSensitive" => p
    let inline untilNextBoundary (p: System.Boolean) = "UntilNextBoundary" => p
    let inline markup (p: System.Boolean) = "Markup" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudIcon = comp<MudBlazor.MudIcon>

module mudIconAttrs =
    let inline icon (p: System.String) = "Icon" => p
    let inline title (p: System.String) = "Title" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline viewBox (p: System.String) = "ViewBox" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudImage = comp<MudBlazor.MudImage>

module mudImageAttrs =
    let inline fluid (p: System.Boolean) = "Fluid" => p
    let inline src (p: System.String) = "Src" => p
    let inline fallbackSrc (p: System.String) = "FallbackSrc" => p
    let inline alt (p: System.String) = "Alt" => p
    let inline height (p: System.Nullable<System.Int32>) = "Height" => p
    let inline width (p: System.Nullable<System.Int32>) = "Width" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline objectFit (p: MudBlazor.ObjectFit) = "ObjectFit" => p
    let inline objectPosition (p: MudBlazor.ObjectPosition) = "ObjectPosition" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudInput<'T21> = comp<MudBlazor.MudInput<'T21>>

module mudInputAttrs =
    let inline inputType (p: MudBlazor.InputType) = "InputType" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onIncrement (p: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => p
    let inline onDecrement (p: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => p
    let inline hideSpinButtons (p: System.Boolean) = "HideSpinButtons" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline onOnMouseWheel ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.WheelEventArgs> "OnMouseWheel" p

    let inline clearIcon (p: System.String) = "ClearIcon" => p
    let inline numericUpIcon (p: System.String) = "NumericUpIcon" => p
    let inline numericDownIcon (p: System.String) = "NumericDownIcon" => p
    let inline autoGrow (p: System.Boolean) = "AutoGrow" => p
    let inline maxLines (p: System.Int32) = "MaxLines" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p
    let inline onValueChanged<'T21> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T21> "ValueChanged" p
    let inline value (p: 'T21) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T21> (p: MudBlazor.Converter<'T21, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T21> (p: System.Linq.Expressions.Expression<System.Func<'T21>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudInputString = comp<MudBlazor.MudInputString>

module mudInputStringAttrs =
    let inline inputType (p: MudBlazor.InputType) = "InputType" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onIncrement (p: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => p
    let inline onDecrement (p: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => p
    let inline hideSpinButtons (p: System.Boolean) = "HideSpinButtons" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline onOnMouseWheel ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.WheelEventArgs> "OnMouseWheel" p

    let inline clearIcon (p: System.String) = "ClearIcon" => p
    let inline numericUpIcon (p: System.String) = "NumericUpIcon" => p
    let inline numericDownIcon (p: System.String) = "NumericDownIcon" => p
    let inline autoGrow (p: System.Boolean) = "AutoGrow" => p
    let inline maxLines (p: System.Int32) = "MaxLines" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter (p: MudBlazor.Converter<System.String, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for`` (p: System.Linq.Expressions.Expression<System.Func<System.String>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudInputLabel = comp<MudBlazor.MudInputLabel>

module mudInputLabelAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline forId (p: System.String) = "ForId" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRangeInput<'T22> = comp<MudBlazor.MudRangeInput<'T22>>

module mudRangeInputAttrs =
    let inline inputType (p: MudBlazor.InputType) = "InputType" => p
    let inline placeholderStart (p: System.String) = "PlaceholderStart" => p
    let inline placeholderEnd (p: System.String) = "PlaceholderEnd" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline separatorIcon (p: System.String) = "SeparatorIcon" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p

    let inline onValueChanged<'T22> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.Range<'T22>> "ValueChanged" p

    let inline value<'T22> (p: MudBlazor.Range<'T22>) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T22> (p: MudBlazor.Converter<MudBlazor.Range<'T22>, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T22> (p: System.Linq.Expressions.Expression<System.Func<MudBlazor.Range<'T22>>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudInputControl = comp<MudBlazor.MudInputControl>

module mudInputControlAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline inputContent p = attr.fragment "InputContent" p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline counterText (p: System.String) = "CounterText" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline label (p: System.String) = "Label" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline forId (p: System.String) = "ForId" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudLayout = comp<MudBlazor.MudLayout>

module mudLayoutAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudLink = comp<MudBlazor.MudLink>

module mudLinkAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline underline (p: MudBlazor.Underline) = "Underline" => p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudList<'T23> = comp<MudBlazor.MudList<'T23>>

module mudListAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline checkBoxColor (p: MudBlazor.Color) = "CheckBoxColor" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline padding (p: System.Boolean) = "Padding" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline selectionMode (p: MudBlazor.SelectionMode) = "SelectionMode" => p
    let inline selectedValue (p: 'T23) = "SelectedValue" => p

    let inline onSelectedValueChanged<'T23> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T23> "SelectedValueChanged" p

    let inline selectedValues<'T23> (p: System.Collections.Generic.IReadOnlyCollection<'T23>) = "SelectedValues" => p

    let inline onSelectedValuesChanged<'T23> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IReadOnlyCollection<'T23>> "SelectedValuesChanged" p

    let inline comparer<'T23> (p: System.Collections.Generic.IEqualityComparer<'T23>) = "Comparer" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline uncheckedIcon (p: System.String) = "UncheckedIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudListItem<'T24> = comp<MudBlazor.MudListItem<'T24>>

module mudListItemAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline secondaryText (p: System.String) = "SecondaryText" => p
    let inline value (p: 'T24) = "Value" => p
    let inline avatarContent p = attr.fragment "AvatarContent" p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline forceLoad (p: System.Boolean) = "ForceLoad" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline expandIconColor (p: MudBlazor.Color) = "ExpandIconColor" => p
    let inline expandLessIcon (p: System.String) = "ExpandLessIcon" => p
    let inline expandMoreIcon (p: System.String) = "ExpandMoreIcon" => p
    let inline inset (p: System.Boolean) = "Inset" => p
    let inline dense (p: System.Nullable<System.Boolean>) = "Dense" => p
    let inline gutters (p: System.Nullable<System.Boolean>) = "Gutters" => p
    let inline expanded (p: System.Boolean) = "Expanded" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline onClickPreventDefault (p: System.Boolean) = "OnClickPreventDefault" => p
    let inline nestedList p = attr.fragment "NestedList" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudListSubheader = comp<MudBlazor.MudListSubheader>

module mudListSubheaderAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline inset (p: System.Boolean) = "Inset" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudMainContent = comp<MudBlazor.MudMainContent>

module mudMainContentAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudMask = comp<MudBlazor.MudMask>

module mudMaskAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline inputType (p: MudBlazor.InputType) = "InputType" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline clearIcon (p: System.String) = "ClearIcon" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p

    let inline onValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "ValueChanged" p

    let inline value (p: System.String) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter (p: MudBlazor.Converter<System.String, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for`` (p: System.Linq.Expressions.Expression<System.Func<System.String>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudMenu = comp<MudBlazor.MudMenu>

module mudMenuAttrs =
    let inline label (p: System.String) = "Label" => p
    let inline ariaLabel (p: System.String) = "AriaLabel" => p
    let inline listClass (p: System.String) = "ListClass" => p
    let inline popoverClass (p: System.String) = "PopoverClass" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline startIcon (p: System.String) = "StartIcon" => p
    let inline endIcon (p: System.String) = "EndIcon" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline positionAtCursor (p: System.Boolean) = "PositionAtCursor" => p
    let inline activatorContent p = attr.fragment "ActivatorContent" p
    let inline activationEvent (p: MudBlazor.MouseEvent) = "ActivationEvent" => p
    let inline anchorOrigin (p: System.Nullable<MudBlazor.Origin>) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline dropdownSettings (p: MudBlazor.DropdownSettings) = "DropdownSettings" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline lockScroll (p: System.Boolean) = "LockScroll" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``open`` (p: System.Boolean) = "Open" => p

    let inline onOpenChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "OpenChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudMenuItem = comp<MudBlazor.MudMenuItem>

module mudMenuItemAttrs =
    let inline label (p: System.String) = "Label" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline href (p: System.String) = "Href" => p
    let inline target (p: System.String) = "Target" => p
    let inline forceLoad (p: System.Boolean) = "ForceLoad" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline autoClose (p: System.Boolean) = "AutoClose" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudMessageBox = comp<MudBlazor.MudMessageBox>

module mudMessageBoxAttrs =
    let inline title (p: System.String) = "Title" => p
    let inline titleContent p = attr.fragment "TitleContent" p
    let inline message (p: System.String) = "Message" => p
    let inline markupMessage (p: Microsoft.AspNetCore.Components.MarkupString) = "MarkupMessage" => p
    let inline messageContent p = attr.fragment "MessageContent" p
    let inline cancelText (p: System.String) = "CancelText" => p
    let inline cancelButton p = attr.fragment "CancelButton" p
    let inline noText (p: System.String) = "NoText" => p
    let inline noButton p = attr.fragment "NoButton" p
    let inline yesText (p: System.String) = "YesText" => p
    let inline yesButton p = attr.fragment "YesButton" p
    let inline onOnYes ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Boolean> "OnYes" p
    let inline onOnNo ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<System.Boolean> "OnNo" p

    let inline onOnCancel ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "OnCancel" p

    let inline visible (p: System.Boolean) = "Visible" => p

    let inline onVisibleChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "VisibleChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudNavGroup = comp<MudBlazor.MudNavGroup>

module mudNavGroupAttrs =
    let inline headerClass (p: System.String) = "HeaderClass" => p
    let inline titleContent p = attr.fragment "TitleContent" p
    let inline title (p: System.String) = "Title" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline expanded (p: System.Boolean) = "Expanded" => p
    let inline hideExpandIcon (p: System.Boolean) = "HideExpandIcon" => p
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline expandIcon (p: System.String) = "ExpandIcon" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudNavLink = comp<MudBlazor.MudNavLink>

module mudNavLinkAttrs =
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline ``match`` (p: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => p
    let inline target (p: System.String) = "Target" => p
    let inline activeClass (p: System.String) = "ActiveClass" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline href (p: System.String) = "Href" => p
    let inline forceLoad (p: System.Boolean) = "ForceLoad" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudNavMenu = comp<MudBlazor.MudNavMenu>

module mudNavMenuAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline bordered (p: System.Boolean) = "Bordered" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudNumericField<'T25> = comp<MudBlazor.MudNumericField<'T25>>

module mudNumericFieldAttrs =
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline clearIcon (p: System.String) = "ClearIcon" => p
    let inline invertMouseWheel (p: System.Boolean) = "InvertMouseWheel" => p
    let inline min (p: 'T25) = "Min" => p
    let inline max (p: 'T25) = "Max" => p
    let inline step (p: 'T25) = "Step" => p
    let inline hideSpinButtons (p: System.Boolean) = "HideSpinButtons" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline debounceInterval (p: System.Double) = "DebounceInterval" => p

    let inline onOnDebounceIntervalElapsed ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "OnDebounceIntervalElapsed" p

    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p
    let inline onValueChanged<'T25> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T25> "ValueChanged" p
    let inline value (p: 'T25) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T25> (p: MudBlazor.Converter<'T25, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T25> (p: System.Linq.Expressions.Expression<System.Func<'T25>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudOverlay = comp<MudBlazor.MudOverlay>

module mudOverlayAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline visible (p: System.Boolean) = "Visible" => p

    let inline onVisibleChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "VisibleChanged" p

    let inline autoClose (p: System.Boolean) = "AutoClose" => p
    let inline lockScroll (p: System.Boolean) = "LockScroll" => p
    let inline lockScrollClass (p: System.String) = "LockScrollClass" => p
    let inline darkBackground (p: System.Boolean) = "DarkBackground" => p
    let inline lightBackground (p: System.Boolean) = "LightBackground" => p
    let inline absolute (p: System.Boolean) = "Absolute" => p
    let inline zIndex (p: System.Int32) = "ZIndex" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline onClosed (p: Microsoft.AspNetCore.Components.EventCallback) = "OnClosed" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPageContentNavigation = comp<MudBlazor.MudPageContentNavigation>

module mudPageContentNavigationAttrs =
    let inline headline (p: System.String) = "Headline" => p
    let inline scrollContainerSelector (p: System.String) = "ScrollContainerSelector" => p
    let inline sectionClassSelector (p: System.String) = "SectionClassSelector" => p

    let inline hierarchyMapper (p: System.Collections.Generic.IDictionary<System.String, System.Int32>) =
        "HierarchyMapper" => p

    let inline expandBehaviour (p: MudBlazor.ContentNavigationExpandBehaviour) = "ExpandBehaviour" => p
    let inline activateFirstSectionAsDefault (p: System.Boolean) = "ActivateFirstSectionAsDefault" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPagination = comp<MudBlazor.MudPagination>

module mudPaginationAttrs =
    let inline count (p: System.Int32) = "Count" => p
    let inline boundaryCount (p: System.Int32) = "BoundaryCount" => p
    let inline middleCount (p: System.Int32) = "MiddleCount" => p
    let inline selected (p: System.Int32) = "Selected" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline rectangular (p: System.Boolean) = "Rectangular" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline showFirstButton (p: System.Boolean) = "ShowFirstButton" => p
    let inline showLastButton (p: System.Boolean) = "ShowLastButton" => p
    let inline showPreviousButton (p: System.Boolean) = "ShowPreviousButton" => p
    let inline showNextButton (p: System.Boolean) = "ShowNextButton" => p
    let inline showPageButtons (p: System.Boolean) = "ShowPageButtons" => p

    let inline onControlButtonClicked ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.Page> "ControlButtonClicked" p

    let inline onSelectedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedChanged" p

    let inline firstIcon (p: System.String) = "FirstIcon" => p
    let inline beforeIcon (p: System.String) = "BeforeIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline lastIcon (p: System.String) = "LastIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPaper = comp<MudBlazor.MudPaper>

module mudPaperAttrs =
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline height (p: System.String) = "Height" => p
    let inline width (p: System.String) = "Width" => p
    let inline maxHeight (p: System.String) = "MaxHeight" => p
    let inline maxWidth (p: System.String) = "MaxWidth" => p
    let inline minHeight (p: System.String) = "MinHeight" => p
    let inline minWidth (p: System.String) = "MinWidth" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPicker<'T26> = comp<MudBlazor.MudPicker<'T26>>

module mudPickerAttrs =
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline pickerOpened (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => p
    let inline pickerClosed (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => p
    let inline elevation (p: System.Nullable<System.Int32>) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline label (p: System.String) = "Label" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline editable (p: System.Boolean) = "Editable" => p
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline toolbarClass (p: System.String) = "ToolbarClass" => p
    let inline pickerVariant (p: MudBlazor.PickerVariant) = "PickerVariant" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline orientation (p: MudBlazor.Orientation) = "Orientation" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline color (p: MudBlazor.Color) = "Color" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline immediateText (p: System.Boolean) = "ImmediateText" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline text (p: System.String) = "Text" => p
    let inline actionsClass (p: System.String) = "ActionsClass" => p

    let inline pickerActions<'T26>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudPicker<'T26> -> Bolero.Node)
        =
        attr.fragmentWith "PickerActions" p

    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline overflowBehavior (p: MudBlazor.OverflowBehavior) = "OverflowBehavior" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T26> (p: MudBlazor.Converter<'T26, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T26> (p: System.Linq.Expressions.Expression<System.Func<'T26>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPickerContent = comp<MudBlazor.MudPickerContent>

module mudPickerContentAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPickerToolbar = comp<MudBlazor.MudPickerToolbar>

module mudPickerToolbarAttrs =
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline orientation (p: MudBlazor.Orientation) = "Orientation" => p
    let inline pickerVariant (p: MudBlazor.PickerVariant) = "PickerVariant" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPopover = comp<MudBlazor.MudPopover>

module mudPopoverAttrs =
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline paper (p: System.Boolean) = "Paper" => p
    let inline dropShadow (p: System.Boolean) = "DropShadow" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline ``fixed`` (p: System.Boolean) = "Fixed" => p
    let inline duration (p: System.Double) = "Duration" => p
    let inline delay (p: System.Double) = "Delay" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline overflowBehavior (p: MudBlazor.OverflowBehavior) = "OverflowBehavior" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline ``open`` (p: System.Boolean) = "Open" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudPopoverProvider = comp<MudBlazor.MudPopoverProvider>
let mudProgressCircular = comp<MudBlazor.MudProgressCircular>

module mudProgressCircularAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline indeterminate (p: System.Boolean) = "Indeterminate" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline value (p: System.Double) = "Value" => p
    let inline strokeWidth (p: System.Int32) = "StrokeWidth" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudProgressLinear = comp<MudBlazor.MudProgressLinear>

module mudProgressLinearAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline indeterminate (p: System.Boolean) = "Indeterminate" => p
    let inline buffer (p: System.Boolean) = "Buffer" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline striped (p: System.Boolean) = "Striped" => p
    let inline vertical (p: System.Boolean) = "Vertical" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline min (p: System.Double) = "Min" => p
    let inline max (p: System.Double) = "Max" => p
    let inline value (p: System.Double) = "Value" => p
    let inline bufferValue (p: System.Double) = "BufferValue" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRadio<'T27> = comp<MudBlazor.MudRadio<'T27>>

module mudRadioAttrs =
    let inline uncheckedColor (p: System.Nullable<MudBlazor.Color>) = "UncheckedColor" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline uncheckedIcon (p: System.String) = "UncheckedIcon" => p
    let inline indeterminateIcon (p: System.String) = "IndeterminateIcon" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline value (p: 'T27) = "Value" => p
    let inline stopClickPropagation (p: System.Boolean) = "StopClickPropagation" => p
    let inline labelPlacement (p: MudBlazor.Placement) = "LabelPlacement" => p
    let inline label (p: System.String) = "Label" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onValueChanged<'T27> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T27> "ValueChanged" p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T27> (p: MudBlazor.Converter<'T27, System.Nullable<System.Boolean>>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T27> (p: System.Linq.Expressions.Expression<System.Func<'T27>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRadioGroup<'T28> = comp<MudBlazor.MudRadioGroup<'T28>>

module mudRadioGroupAttrs =
    let inline inputClass (p: System.String) = "InputClass" => p
    let inline inputStyle (p: System.String) = "InputStyle" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline name (p: System.String) = "Name" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline value (p: 'T28) = "Value" => p
    let inline onValueChanged<'T28> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T28> "ValueChanged" p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T28> (p: MudBlazor.Converter<'T28, 'T28>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T28> (p: System.Linq.Expressions.Expression<System.Func<'T28>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRating = comp<MudBlazor.MudRating>

module mudRatingAttrs =
    let inline ratingItemsClass (p: System.String) = "RatingItemsClass" => p
    let inline ratingItemsStyle (p: System.String) = "RatingItemsStyle" => p
    let inline name (p: System.String) = "Name" => p
    let inline maxValue (p: System.Int32) = "MaxValue" => p
    let inline fullIcon (p: System.String) = "FullIcon" => p
    let inline emptyIcon (p: System.String) = "EmptyIcon" => p
    let inline fullIconColor (p: System.Nullable<MudBlazor.Color>) = "FullIconColor" => p
    let inline emptyIconColor (p: System.Nullable<MudBlazor.Color>) = "EmptyIconColor" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p

    let inline onSelectedValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedValueChanged" p

    let inline selectedValue (p: System.Int32) = "SelectedValue" => p

    let inline onHoveredValueChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.Int32>> "HoveredValueChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRatingItem = comp<MudBlazor.MudRatingItem>

module mudRatingItemAttrs =
    let inline itemValue (p: System.Int32) = "ItemValue" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p

    let inline onItemClicked ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "ItemClicked" p

    let inline onItemHovered ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.Int32>> "ItemHovered" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRTLProvider = comp<MudBlazor.MudRTLProvider>

module mudRTLProviderAttrs =
    let inline rightToLeft (p: System.Boolean) = "RightToLeft" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudScrollToTop = comp<MudBlazor.MudScrollToTop>

module mudScrollToTopAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline selector (p: System.String) = "Selector" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline visibleCssClass (p: System.String) = "VisibleCssClass" => p
    let inline hiddenCssClass (p: System.String) = "HiddenCssClass" => p
    let inline topOffset (p: System.Int32) = "TopOffset" => p
    let inline scrollBehavior (p: MudBlazor.ScrollBehavior) = "ScrollBehavior" => p

    let inline onOnScroll ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.ScrollEventArgs> "OnScroll" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSelect<'T29> = comp<MudBlazor.MudSelect<'T29>>

module mudSelectAttrs =
    let inline dropdownSettings (p: MudBlazor.DropdownSettings) = "DropdownSettings" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline outerClass (p: System.String) = "OuterClass" => p
    let inline inputClass (p: System.String) = "InputClass" => p
    let inline onOpen (p: Microsoft.AspNetCore.Components.EventCallback) = "OnOpen" => p
    let inline onClose (p: Microsoft.AspNetCore.Components.EventCallback) = "OnClose" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline popoverClass (p: System.String) = "PopoverClass" => p
    let inline listClass (p: System.String) = "ListClass" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline openIcon (p: System.String) = "OpenIcon" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline selectAll (p: System.Boolean) = "SelectAll" => p
    let inline selectAllText (p: System.String) = "SelectAllText" => p

    let inline onSelectedValuesChanged<'T29> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<'T29>> "SelectedValuesChanged" p

    let inline multiSelectionTextFunc (p: System.Func<System.Collections.Generic.List<System.String>, System.String>) =
        "MultiSelectionTextFunc" => p

    let inline delimiter (p: System.String) = "Delimiter" => p
    let inline quickSearchInterval (p: System.TimeSpan) = "QuickSearchInterval" => p
    let inline selectedValues<'T29> (p: System.Collections.Generic.IEnumerable<'T29>) = "SelectedValues" => p
    let inline comparer<'T29> (p: System.Collections.Generic.IEqualityComparer<'T29>) = "Comparer" => p
    let inline toStringFunc<'T29> (p: System.Func<'T29, System.String>) = "ToStringFunc" => p
    let inline multiSelection (p: System.Boolean) = "MultiSelection" => p
    let inline maxHeight (p: System.Int32) = "MaxHeight" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline strict (p: System.Boolean) = "Strict" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline clearIcon (p: System.String) = "ClearIcon" => p
    let inline lockScroll (p: System.Boolean) = "LockScroll" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline uncheckedIcon (p: System.String) = "UncheckedIcon" => p
    let inline indeterminateIcon (p: System.String) = "IndeterminateIcon" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p
    let inline onValueChanged<'T29> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T29> "ValueChanged" p
    let inline value (p: 'T29) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T29> (p: MudBlazor.Converter<'T29, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T29> (p: System.Linq.Expressions.Expression<System.Func<'T29>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSelectItem<'T30> = comp<MudBlazor.MudSelectItem<'T30>>

module mudSelectItemAttrs =
    let inline value (p: 'T30) = "Value" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSkeleton = comp<MudBlazor.MudSkeleton>

module mudSkeletonAttrs =
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline skeletonType (p: MudBlazor.SkeletonType) = "SkeletonType" => p
    let inline animation (p: MudBlazor.Animation) = "Animation" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSlider<'T31
    when 'T31: struct
    and 'T31: (new: unit -> 'T31)
    and 'T31 :> System.Numerics.INumber<'T31>
    and 'T31 :> System.ValueType> =
    comp<MudBlazor.MudSlider<'T31>>

module mudSliderAttrs =
    let inline min (p: 'T31) = "Min" => p
    let inline max (p: 'T31) = "Max" => p
    let inline step (p: 'T31) = "Step" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onValueChanged<'T31
        when 'T31: struct
        and 'T31: (new: unit -> 'T31)
        and 'T31 :> System.Numerics.INumber<'T31>
        and 'T31 :> System.ValueType>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p)
        =
        attr.callback<'T31> "ValueChanged" p

    let inline onNullableValueChanged<'T31
        when 'T31: struct
        and 'T31: (new: unit -> 'T31)
        and 'T31 :> System.Numerics.INumber<'T31>
        and 'T31 :> System.ValueType>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p)
        =
        attr.callback<System.Nullable<'T31>> "NullableValueChanged" p

    let inline value (p: 'T31) = "Value" => p

    let inline nullableValue<'T31
        when 'T31: struct
        and 'T31: (new: unit -> 'T31)
        and 'T31 :> System.Numerics.INumber<'T31>
        and 'T31 :> System.ValueType>
        (p: System.Nullable<'T31>)
        =
        "NullableValue" => p

    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline vertical (p: System.Boolean) = "Vertical" => p
    let inline tickMarks (p: System.Boolean) = "TickMarks" => p
    let inline tickMarkLabels (p: System.String[]) = "TickMarkLabels" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline valueLabel (p: System.Boolean) = "ValueLabel" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline valueLabelFormat (p: System.String) = "ValueLabelFormat" => p

    let inline valueLabelContent<'T31
        when 'T31: struct
        and 'T31: (new: unit -> 'T31)
        and 'T31 :> System.Numerics.INumber<'T31>
        and 'T31 :> System.ValueType>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.SliderContext<'T31> -> Bolero.Node)
        =
        attr.fragmentWith "ValueLabelContent" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSnackbarElement = comp<MudBlazor.MudSnackbarElement>

module mudSnackbarElementAttrs =
    let inline snackbar (p: MudBlazor.Snackbar) = "Snackbar" => p
    let inline closeIcon (p: System.String) = "CloseIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSnackbarProvider = comp<MudBlazor.MudSnackbarProvider>

module mudSnackbarProviderAttrs =
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudStack = comp<MudBlazor.MudStack>

module mudStackAttrs =
    let inline row (p: System.Boolean) = "Row" => p
    let inline reverse (p: System.Boolean) = "Reverse" => p
    let inline spacing (p: System.Int32) = "Spacing" => p
    let inline justify (p: System.Nullable<MudBlazor.Justify>) = "Justify" => p
    let inline alignItems (p: System.Nullable<MudBlazor.AlignItems>) = "AlignItems" => p
    let inline stretchItems (p: System.Nullable<MudBlazor.StretchItems>) = "StretchItems" => p
    let inline wrap (p: System.Nullable<MudBlazor.Wrap>) = "Wrap" => p
    let inline breakpoint (p: MudBlazor.Breakpoint) = "Breakpoint" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudStep = comp<MudBlazor.MudStep>

module mudStepAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline title (p: System.String) = "Title" => p
    let inline secondaryText (p: System.String) = "SecondaryText" => p
    let inline completedStepColor (p: System.Nullable<MudBlazor.Color>) = "CompletedStepColor" => p
    let inline errorStepColor (p: System.Nullable<MudBlazor.Color>) = "ErrorStepColor" => p
    let inline skippable (p: System.Boolean) = "Skippable" => p
    let inline completed (p: System.Boolean) = "Completed" => p

    let inline onCompletedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "CompletedChanged" p

    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline onDisabledChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "DisabledChanged" p

    let inline hasError (p: System.Boolean) = "HasError" => p

    let inline onHasErrorChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "HasErrorChanged" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudStepper = comp<MudBlazor.MudStepper>

module mudStepperAttrs =
    let inline activeIndex (p: System.Int32) = "ActiveIndex" => p

    let inline onActiveIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "ActiveIndexChanged" p

    let inline completedStepColor (p: MudBlazor.Color) = "CompletedStepColor" => p
    let inline currentStepColor (p: MudBlazor.Color) = "CurrentStepColor" => p
    let inline errorStepColor (p: MudBlazor.Color) = "ErrorStepColor" => p
    let inline stepCompleteIcon (p: System.String) = "StepCompleteIcon" => p
    let inline stepErrorIcon (p: System.String) = "StepErrorIcon" => p
    let inline resetButtonIcon (p: System.String) = "ResetButtonIcon" => p
    let inline previousButtonIcon (p: System.String) = "PreviousButtonIcon" => p
    let inline skipButtonIcon (p: System.String) = "SkipButtonIcon" => p
    let inline nextButtonIcon (p: System.String) = "NextButtonIcon" => p
    let inline completeButtonIcon (p: System.String) = "CompleteButtonIcon" => p
    let inline navClass (p: System.String) = "NavClass" => p
    let inline nonLinear (p: System.Boolean) = "NonLinear" => p
    let inline showResetButton (p: System.Boolean) = "ShowResetButton" => p
    let inline vertical (p: System.Boolean) = "Vertical" => p
    let inline stepClass (p: System.String) = "StepClass" => p
    let inline stepStyle (p: System.String) = "StepStyle" => p
    let inline centerLabels (p: System.Boolean) = "CenterLabels" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline scrollableNavigation (p: System.Boolean) = "ScrollableNavigation" => p

    let inline onPreviewInteraction
        (p: System.Func<MudBlazor.StepperInteractionEventArgs, System.Threading.Tasks.Task>)
        =
        "OnPreviewInteraction" => p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline titleTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudStep -> Bolero.Node) =
        attr.fragmentWith "TitleTemplate" p

    let inline labelTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudStep -> Bolero.Node) =
        attr.fragmentWith "LabelTemplate" p

    let inline connectorTemplate ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudStep -> Bolero.Node) =
        attr.fragmentWith "ConnectorTemplate" p

    let inline completedContent p = attr.fragment "CompletedContent" p

    let inline actionContent ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudStepper -> Bolero.Node) =
        attr.fragmentWith "ActionContent" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSwipeArea = comp<MudBlazor.MudSwipeArea>

module mudSwipeAreaAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

    let inline onOnSwipeEnd ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.SwipeEventArgs> "OnSwipeEnd" p

    let inline sensitivity (p: System.Int32) = "Sensitivity" => p
    let inline preventDefault (p: System.Boolean) = "PreventDefault" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSwitch<'T32> = comp<MudBlazor.MudSwitch<'T32>>

module mudSwitchAttrs =
    let inline uncheckedColor (p: MudBlazor.Color) = "UncheckedColor" => p
    let inline thumbIcon (p: System.String) = "ThumbIcon" => p
    let inline thumbIconColor (p: MudBlazor.Color) = "ThumbIconColor" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline value (p: 'T32) = "Value" => p
    let inline stopClickPropagation (p: System.Boolean) = "StopClickPropagation" => p
    let inline labelPlacement (p: MudBlazor.Placement) = "LabelPlacement" => p
    let inline label (p: System.String) = "Label" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline onValueChanged<'T32> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T32> "ValueChanged" p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T32> (p: MudBlazor.Converter<'T32, System.Nullable<System.Boolean>>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T32> (p: System.Linq.Expressions.Expression<System.Func<'T32>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTable<'T33> = comp<MudBlazor.MudTable<'T33>>

module mudTableAttrs =
    let inline rowTemplate<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T33 -> Bolero.Node) =
        attr.fragmentWith "RowTemplate" p

    let inline childRowContent<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T33 -> Bolero.Node) =
        attr.fragmentWith "ChildRowContent" p

    let inline rowEditingTemplate<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T33 -> Bolero.Node) =
        attr.fragmentWith "RowEditingTemplate" p

    let inline rowEditableFunc<'T33> (p: System.Func<'T33, System.Boolean>) = "RowEditableFunc" => p

    let inline columns<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T33 -> Bolero.Node) =
        attr.fragmentWith "Columns" p

    let inline noRecordsContent p = attr.fragment "NoRecordsContent" p
    let inline loadingContent p = attr.fragment "LoadingContent" p
    let inline horizontalScrollbar (p: System.Boolean) = "HorizontalScrollbar" => p
    let inline items<'T33> (p: System.Collections.Generic.IEnumerable<'T33>) = "Items" => p
    let inline filter<'T33> (p: System.Func<'T33, System.Boolean>) = "Filter" => p

    let inline onOnRowClick<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.TableRowClickEventArgs<'T33>> "OnRowClick" p

    let inline onOnRowMouseEnter<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.TableRowHoverEventArgs<'T33>> "OnRowMouseEnter" p

    let inline onOnRowMouseLeave<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.TableRowHoverEventArgs<'T33>> "OnRowMouseLeave" p

    let inline rowClassFunc<'T33> (p: System.Func<'T33, System.Int32, System.String>) = "RowClassFunc" => p
    let inline rowStyleFunc<'T33> (p: System.Func<'T33, System.Int32, System.String>) = "RowStyleFunc" => p
    let inline selectedItem (p: 'T33) = "SelectedItem" => p

    let inline onSelectedItemChanged<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T33> "SelectedItemChanged" p

    let inline selectedItems<'T33> (p: System.Collections.Generic.HashSet<'T33>) = "SelectedItems" => p
    let inline comparer<'T33> (p: System.Collections.Generic.IEqualityComparer<'T33>) = "Comparer" => p

    let inline onSelectedItemsChanged<'T33> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.HashSet<'T33>> "SelectedItemsChanged" p

    let inline groupBy<'T33> (p: MudBlazor.TableGroupDefinition<'T33>) = "GroupBy" => p

    let inline groupHeaderTemplate<'T33>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.TableGroupData<System.Object, 'T33> -> Bolero.Node)
        =
        attr.fragmentWith "GroupHeaderTemplate" p

    let inline groupHeaderClass (p: System.String) = "GroupHeaderClass" => p
    let inline groupHeaderStyle (p: System.String) = "GroupHeaderStyle" => p
    let inline groupFooterClass (p: System.String) = "GroupFooterClass" => p
    let inline groupFooterStyle (p: System.String) = "GroupFooterStyle" => p

    let inline groupFooterTemplate<'T33>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.TableGroupData<System.Object, 'T33> -> Bolero.Node)
        =
        attr.fragmentWith "GroupFooterTemplate" p

    let inline serverData<'T33>
        (p:
            System.Func<
                MudBlazor.TableState,
                System.Threading.CancellationToken,
                System.Threading.Tasks.Task<MudBlazor.TableData<'T33>>
             >)
        =
        "ServerData" => p

    let inline isEditRowSwitchingBlocked (p: System.Boolean) = "IsEditRowSwitchingBlocked" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline bordered (p: System.Boolean) = "Bordered" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline hover (p: System.Boolean) = "Hover" => p
    let inline striped (p: System.Boolean) = "Striped" => p
    let inline breakpoint (p: MudBlazor.Breakpoint) = "Breakpoint" => p
    let inline fixedHeader (p: System.Boolean) = "FixedHeader" => p
    let inline fixedFooter (p: System.Boolean) = "FixedFooter" => p
    let inline height (p: System.String) = "Height" => p
    let inline sortLabel (p: System.String) = "SortLabel" => p
    let inline allowUnsorted (p: System.Boolean) = "AllowUnsorted" => p
    let inline rowsPerPage (p: System.Int32) = "RowsPerPage" => p

    let inline onRowsPerPageChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "RowsPerPageChanged" p

    let inline currentPage (p: System.Int32) = "CurrentPage" => p

    let inline onCurrentPageChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "CurrentPageChanged" p

    let inline multiSelection (p: System.Boolean) = "MultiSelection" => p
    let inline selectionChangeable (p: System.Boolean) = "SelectionChangeable" => p
    let inline selectOnRowClick (p: System.Boolean) = "SelectOnRowClick" => p
    let inline toolBarContent p = attr.fragment "ToolBarContent" p
    let inline loading (p: System.Boolean) = "Loading" => p
    let inline loadingProgressColor (p: MudBlazor.Color) = "LoadingProgressColor" => p
    let inline headerContent p = attr.fragment "HeaderContent" p
    let inline customHeader (p: System.Boolean) = "CustomHeader" => p
    let inline headerClass (p: System.String) = "HeaderClass" => p
    let inline containerStyle (p: System.String) = "ContainerStyle" => p
    let inline containerClass (p: System.String) = "ContainerClass" => p
    let inline footerContent p = attr.fragment "FooterContent" p
    let inline customFooter (p: System.Boolean) = "CustomFooter" => p
    let inline footerClass (p: System.String) = "FooterClass" => p
    let inline colGroup p = attr.fragment "ColGroup" p
    let inline pagerContent p = attr.fragment "PagerContent" p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p

    let inline onOnCommitEditClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" p

    let inline onOnCancelEditClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" p

    let inline onOnPreviewEditClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Object> "OnPreviewEditClick" p

    let inline commitEditTooltip (p: System.String) = "CommitEditTooltip" => p
    let inline cancelEditTooltip (p: System.String) = "CancelEditTooltip" => p
    let inline commitEditIcon (p: System.String) = "CommitEditIcon" => p
    let inline cancelEditIcon (p: System.String) = "CancelEditIcon" => p
    let inline canCancelEdit (p: System.Boolean) = "CanCancelEdit" => p
    let inline applyButtonPosition (p: MudBlazor.TableApplyButtonPosition) = "ApplyButtonPosition" => p
    let inline editButtonPosition (p: MudBlazor.TableEditButtonPosition) = "EditButtonPosition" => p
    let inline editTrigger (p: MudBlazor.TableEditTrigger) = "EditTrigger" => p

    let inline editButtonContent
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.EditButtonContext -> Bolero.Node)
        =
        attr.fragmentWith "EditButtonContent" p

    let inline rowEditPreview (p: System.Action<System.Object>) = "RowEditPreview" => p
    let inline rowEditCommit (p: System.Action<System.Object>) = "RowEditCommit" => p
    let inline rowEditCancel (p: System.Action<System.Object>) = "RowEditCancel" => p
    let inline totalItems (p: System.Int32) = "TotalItems" => p
    let inline rowClass (p: System.String) = "RowClass" => p
    let inline rowStyle (p: System.String) = "RowStyle" => p
    let inline virtualize (p: System.Boolean) = "Virtualize" => p
    let inline overscanCount (p: System.Int32) = "OverscanCount" => p
    let inline itemSize (p: System.Single) = "ItemSize" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTableGroupRow<'T34> = comp<MudBlazor.MudTableGroupRow<'T34>>

module mudTableGroupRowAttrs =
    let inline groupDefinition<'T34> (p: MudBlazor.TableGroupDefinition<'T34>) = "GroupDefinition" => p
    let inline items<'T34> (p: System.Linq.IGrouping<System.Object, 'T34>) = "Items" => p

    let inline headerTemplate<'T34>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.TableGroupData<System.Object, 'T34> -> Bolero.Node)
        =
        attr.fragmentWith "HeaderTemplate" p

    let inline footerTemplate<'T34>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.TableGroupData<System.Object, 'T34> -> Bolero.Node)
        =
        attr.fragmentWith "FooterTemplate" p

    let inline checkable (p: System.Boolean) = "Checkable" => p
    let inline selectionChangeable (p: System.Boolean) = "SelectionChangeable" => p
    let inline headerClass (p: System.String) = "HeaderClass" => p
    let inline footerClass (p: System.String) = "FooterClass" => p
    let inline headerStyle (p: System.String) = "HeaderStyle" => p
    let inline footerStyle (p: System.String) = "FooterStyle" => p
    let inline expandIcon (p: System.String) = "ExpandIcon" => p
    let inline collapseIcon (p: System.String) = "CollapseIcon" => p

    let inline onOnRowClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTablePager = comp<MudBlazor.MudTablePager>

module mudTablePagerAttrs =
    let inline hideRowsPerPage (p: System.Boolean) = "HideRowsPerPage" => p
    let inline hidePageNumber (p: System.Boolean) = "HidePageNumber" => p
    let inline hidePagination (p: System.Boolean) = "HidePagination" => p
    let inline horizontalAlignment (p: MudBlazor.HorizontalAlignment) = "HorizontalAlignment" => p
    let inline pageSizeOptions (p: System.Int32[]) = "PageSizeOptions" => p
    let inline infoFormat (p: System.String) = "InfoFormat" => p
    let inline allItemsText (p: System.String) = "AllItemsText" => p
    let inline rowsPerPageString (p: System.String) = "RowsPerPageString" => p
    let inline firstIcon (p: System.String) = "FirstIcon" => p
    let inline beforeIcon (p: System.String) = "BeforeIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline lastIcon (p: System.String) = "LastIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTableSortLabel<'T35> = comp<MudBlazor.MudTableSortLabel<'T35>>

module mudTableSortLabelAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline initialDirection (p: MudBlazor.SortDirection) = "InitialDirection" => p
    let inline enabled (p: System.Boolean) = "Enabled" => p
    let inline sortIcon (p: System.String) = "SortIcon" => p
    let inline appendIcon (p: System.Boolean) = "AppendIcon" => p
    let inline sortDirection (p: MudBlazor.SortDirection) = "SortDirection" => p

    let inline onSortDirectionChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.SortDirection> "SortDirectionChanged" p

    let inline sortBy<'T35> (p: System.Func<'T35, System.Object>) = "SortBy" => p
    let inline sortLabel (p: System.String) = "SortLabel" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTd = comp<MudBlazor.MudTd>

module mudTdAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline dataLabel (p: System.String) = "DataLabel" => p
    let inline hideSmall (p: System.Boolean) = "HideSmall" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTFootRow = comp<MudBlazor.MudTFootRow>

module mudTFootRowAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline checkable (p: System.Boolean) = "Checkable" => p
    let inline selectionChangeable (p: System.Boolean) = "SelectionChangeable" => p
    let inline ignoreCheckbox (p: System.Boolean) = "IgnoreCheckbox" => p
    let inline ignoreEditable (p: System.Boolean) = "IgnoreEditable" => p
    let inline expandable (p: System.Boolean) = "Expandable" => p

    let inline onOnRowClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTh = comp<MudBlazor.MudTh>

module mudThAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTHeadRow = comp<MudBlazor.MudTHeadRow>

module mudTHeadRowAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline checkable (p: System.Boolean) = "Checkable" => p
    let inline selectionChangeable (p: System.Boolean) = "SelectionChangeable" => p
    let inline ignoreCheckbox (p: System.Boolean) = "IgnoreCheckbox" => p
    let inline ignoreEditable (p: System.Boolean) = "IgnoreEditable" => p
    let inline expandable (p: System.Boolean) = "Expandable" => p

    let inline onOnRowClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTr = comp<MudBlazor.MudTr>

module mudTrAttrs =
    let inline childContent p = attr.fragment "ChildContent" p
    let inline item (p: System.Object) = "Item" => p
    let inline checkable (p: System.Boolean) = "Checkable" => p
    let inline selectionChangeable (p: System.Boolean) = "SelectionChangeable" => p
    let inline editable (p: System.Boolean) = "Editable" => p
    let inline expandable (p: System.Boolean) = "Expandable" => p

    let inline onCheckedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "CheckedChanged" p

    let inline ``checked`` (p: System.Boolean) = "Checked" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudSimpleTable = comp<MudBlazor.MudSimpleTable>

module mudSimpleTableAttrs =
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline hover (p: System.Boolean) = "Hover" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline bordered (p: System.Boolean) = "Bordered" => p
    let inline striped (p: System.Boolean) = "Striped" => p
    let inline fixedHeader (p: System.Boolean) = "FixedHeader" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudDynamicTabs = comp<MudBlazor.MudDynamicTabs>

module mudDynamicTabsAttrs =
    let inline addTabIcon (p: System.String) = "AddTabIcon" => p
    let inline closeTabIcon (p: System.String) = "CloseTabIcon" => p
    let inline addTab (p: Microsoft.AspNetCore.Components.EventCallback) = "AddTab" => p

    let inline onCloseTab ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<MudBlazor.MudTabPanel> "CloseTab" p

    let inline addIconClass (p: System.String) = "AddIconClass" => p
    let inline addIconStyle (p: System.String) = "AddIconStyle" => p
    let inline closeIconClass (p: System.String) = "CloseIconClass" => p
    let inline closeIconStyle (p: System.String) = "CloseIconStyle" => p
    let inline addIconToolTip (p: System.String) = "AddIconToolTip" => p
    let inline closeIconToolTip (p: System.String) = "CloseIconToolTip" => p
    let inline keepPanelsAlive (p: System.Boolean) = "KeepPanelsAlive" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline border (p: System.Boolean) = "Border" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline centered (p: System.Boolean) = "Centered" => p
    let inline hideSlider (p: System.Boolean) = "HideSlider" => p
    let inline prevIcon (p: System.String) = "PrevIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline alwaysShowScrollButtons (p: System.Boolean) = "AlwaysShowScrollButtons" => p
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline minimumTabWidth (p: System.String) = "MinimumTabWidth" => p
    let inline position (p: MudBlazor.Position) = "Position" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline sliderColor (p: MudBlazor.Color) = "SliderColor" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline scrollIconColor (p: MudBlazor.Color) = "ScrollIconColor" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline applyEffectsToContainer (p: System.Boolean) = "ApplyEffectsToContainer" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline sliderAnimation (p: System.Boolean) = "SliderAnimation" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline prePanelContent ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTabPanel -> Bolero.Node) =
        attr.fragmentWith "PrePanelContent" p

    let inline tabPanelClass (p: System.String) = "TabPanelClass" => p
    let inline tabHeaderClass (p: System.String) = "TabHeaderClass" => p
    let inline activeTabClass (p: System.String) = "ActiveTabClass" => p
    let inline panelClass (p: System.String) = "PanelClass" => p
    let inline activePanelIndex (p: System.Int32) = "ActivePanelIndex" => p

    let inline onActivePanelIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "ActivePanelIndexChanged" p

    let inline header ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTabs -> Bolero.Node) =
        attr.fragmentWith "Header" p

    let inline headerPosition (p: MudBlazor.TabHeaderPosition) = "HeaderPosition" => p

    let inline tabPanelHeader ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTabPanel -> Bolero.Node) =
        attr.fragmentWith "TabPanelHeader" p

    let inline tabPanelHeaderPosition (p: MudBlazor.TabHeaderPosition) = "TabPanelHeaderPosition" => p

    let inline onPreviewInteraction (p: System.Func<MudBlazor.TabInteractionEventArgs, System.Threading.Tasks.Task>) =
        "OnPreviewInteraction" => p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTabPanel = comp<MudBlazor.MudTabPanel>

module mudTabPanelAttrs =
    let inline text (p: System.String) = "Text" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline showCloseIcon (p: System.Boolean) = "ShowCloseIcon" => p
    let inline badgeData (p: System.Object) = "BadgeData" => p
    let inline badgeIcon (p: System.String) = "BadgeIcon" => p
    let inline badgeDot (p: System.Boolean) = "BadgeDot" => p
    let inline badgeColor (p: MudBlazor.Color) = "BadgeColor" => p
    let inline iD (p: System.Object) = "ID" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline childContent p = attr.fragment "ChildContent" p
    let inline tabContent p = attr.fragment "TabContent" p

    let inline tabWrapperContent
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: Microsoft.AspNetCore.Components.RenderFragment -> Bolero.Node)
        =
        attr.fragmentWith "TabWrapperContent" p

    let inline toolTip (p: System.String) = "ToolTip" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTabs = comp<MudBlazor.MudTabs>

module mudTabsAttrs =
    let inline keepPanelsAlive (p: System.Boolean) = "KeepPanelsAlive" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline border (p: System.Boolean) = "Border" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline centered (p: System.Boolean) = "Centered" => p
    let inline hideSlider (p: System.Boolean) = "HideSlider" => p
    let inline prevIcon (p: System.String) = "PrevIcon" => p
    let inline nextIcon (p: System.String) = "NextIcon" => p
    let inline alwaysShowScrollButtons (p: System.Boolean) = "AlwaysShowScrollButtons" => p
    let inline maxHeight (p: System.Nullable<System.Int32>) = "MaxHeight" => p
    let inline minimumTabWidth (p: System.String) = "MinimumTabWidth" => p
    let inline position (p: MudBlazor.Position) = "Position" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline sliderColor (p: MudBlazor.Color) = "SliderColor" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline scrollIconColor (p: MudBlazor.Color) = "ScrollIconColor" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline applyEffectsToContainer (p: System.Boolean) = "ApplyEffectsToContainer" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline sliderAnimation (p: System.Boolean) = "SliderAnimation" => p
    let inline childContent p = attr.fragment "ChildContent" p

    let inline prePanelContent ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTabPanel -> Bolero.Node) =
        attr.fragmentWith "PrePanelContent" p

    let inline tabPanelClass (p: System.String) = "TabPanelClass" => p
    let inline tabHeaderClass (p: System.String) = "TabHeaderClass" => p
    let inline activeTabClass (p: System.String) = "ActiveTabClass" => p
    let inline panelClass (p: System.String) = "PanelClass" => p
    let inline activePanelIndex (p: System.Int32) = "ActivePanelIndex" => p

    let inline onActivePanelIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "ActivePanelIndexChanged" p

    let inline header ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTabs -> Bolero.Node) =
        attr.fragmentWith "Header" p

    let inline headerPosition (p: MudBlazor.TabHeaderPosition) = "HeaderPosition" => p

    let inline tabPanelHeader ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTabPanel -> Bolero.Node) =
        attr.fragmentWith "TabPanelHeader" p

    let inline tabPanelHeaderPosition (p: MudBlazor.TabHeaderPosition) = "TabPanelHeaderPosition" => p

    let inline onPreviewInteraction (p: System.Func<MudBlazor.TabInteractionEventArgs, System.Threading.Tasks.Task>) =
        "OnPreviewInteraction" => p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTextField<'T36> = comp<MudBlazor.MudTextField<'T36>>

module mudTextFieldAttrs =
    let inline inputType (p: MudBlazor.InputType) = "InputType" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline clearIcon (p: System.String) = "ClearIcon" => p

    let inline onOnClearButtonClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" p

    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline autoGrow (p: System.Boolean) = "AutoGrow" => p
    let inline maxLines (p: System.Int32) = "MaxLines" => p
    let inline debounceInterval (p: System.Double) = "DebounceInterval" => p

    let inline onOnDebounceIntervalElapsed ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "OnDebounceIntervalElapsed" p

    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline fullWidth (p: System.Boolean) = "FullWidth" => p
    let inline immediate (p: System.Boolean) = "Immediate" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline helperId (p: System.String) = "HelperId" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentText (p: System.String) = "AdornmentText" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline onlyValidateIfDirty (p: System.Boolean) = "OnlyValidateIfDirty" => p
    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p

    let inline onOnAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" p

    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline counter (p: System.Nullable<System.Int32>) = "Counter" => p
    let inline maxLength (p: System.Int32) = "MaxLength" => p
    let inline label (p: System.String) = "Label" => p
    let inline autoFocus (p: System.Boolean) = "AutoFocus" => p
    let inline lines (p: System.Int32) = "Lines" => p
    let inline text (p: System.String) = "Text" => p
    let inline textUpdateSuppression (p: System.Boolean) = "TextUpdateSuppression" => p
    let inline inputMode (p: MudBlazor.InputMode) = "InputMode" => p
    let inline pattern (p: System.String) = "Pattern" => p
    let inline shrinkLabel (p: System.Boolean) = "ShrinkLabel" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline onOnBlur ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" p

    let inline onOnInternalInputChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" p

    let inline onOnKeyDown ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" p

    let inline keyDownPreventDefault (p: System.Boolean) = "KeyDownPreventDefault" => p

    let inline onOnKeyUp ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" p

    let inline keyUpPreventDefault (p: System.Boolean) = "KeyUpPreventDefault" => p
    let inline onValueChanged<'T36> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T36> "ValueChanged" p
    let inline value (p: 'T36) = "Value" => p
    let inline format (p: System.String) = "Format" => p
    let inline inputId (p: System.String) = "InputId" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter<'T36> (p: MudBlazor.Converter<'T36, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p
    let inline ``for``<'T36> (p: System.Linq.Expressions.Expression<System.Func<'T36>>) = "For" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudThemeProvider = comp<MudBlazor.MudThemeProvider>

module mudThemeProviderAttrs =
    let inline theme (p: MudBlazor.MudTheme) = "Theme" => p
    let inline defaultScrollbar (p: System.Boolean) = "DefaultScrollbar" => p
    let inline observeSystemThemeChange (p: System.Boolean) = "ObserveSystemThemeChange" => p
    let inline isDarkMode (p: System.Boolean) = "IsDarkMode" => p

    let inline onIsDarkModeChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "IsDarkModeChanged" p

let mudTimeline = comp<MudBlazor.MudTimeline>

module mudTimelineAttrs =
    let inline timelineOrientation (p: MudBlazor.TimelineOrientation) = "TimelineOrientation" => p
    let inline timelinePosition (p: MudBlazor.TimelinePosition) = "TimelinePosition" => p
    let inline timelineAlign (p: MudBlazor.TimelineAlign) = "TimelineAlign" => p
    let inline reverse (p: System.Boolean) = "Reverse" => p
    let inline modifiers (p: System.Boolean) = "Modifiers" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTimelineItem = comp<MudBlazor.MudTimelineItem>

module mudTimelineItemAttrs =
    let inline icon (p: System.String) = "Icon" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline dotStyle (p: System.String) = "DotStyle" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline elevation (p: System.Int32) = "Elevation" => p
    let inline timelineAlign (p: MudBlazor.TimelineAlign) = "TimelineAlign" => p
    let inline hideDot (p: System.Boolean) = "HideDot" => p
    let inline itemOpposite p = attr.fragment "ItemOpposite" p
    let inline itemContent p = attr.fragment "ItemContent" p
    let inline itemDot p = attr.fragment "ItemDot" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTimePicker = comp<MudBlazor.MudTimePicker>

module mudTimePickerAttrs =
    let inline openTo (p: MudBlazor.OpenTo) = "OpenTo" => p
    let inline timeEditMode (p: MudBlazor.TimeEditMode) = "TimeEditMode" => p
    let inline closingDelay (p: System.Int32) = "ClosingDelay" => p
    let inline autoClose (p: System.Boolean) = "AutoClose" => p
    let inline minuteSelectionStep (p: System.Int32) = "MinuteSelectionStep" => p
    let inline amPm (p: System.Boolean) = "AmPm" => p
    let inline timeFormat (p: System.String) = "TimeFormat" => p
    let inline time (p: System.Nullable<System.TimeSpan>) = "Time" => p

    let inline onTimeChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Nullable<System.TimeSpan>> "TimeChanged" p

    let inline adornmentColor (p: MudBlazor.Color) = "AdornmentColor" => p
    let inline adornmentIcon (p: System.String) = "AdornmentIcon" => p
    let inline adornmentAriaLabel (p: System.String) = "AdornmentAriaLabel" => p
    let inline placeholder (p: System.String) = "Placeholder" => p
    let inline pickerOpened (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => p
    let inline pickerClosed (p: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => p
    let inline elevation (p: System.Nullable<System.Int32>) = "Elevation" => p
    let inline square (p: System.Boolean) = "Square" => p
    let inline rounded (p: System.Boolean) = "Rounded" => p
    let inline helperText (p: System.String) = "HelperText" => p
    let inline helperTextOnFocus (p: System.Boolean) = "HelperTextOnFocus" => p
    let inline label (p: System.String) = "Label" => p
    let inline clearable (p: System.Boolean) = "Clearable" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline underline (p: System.Boolean) = "Underline" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline editable (p: System.Boolean) = "Editable" => p
    let inline showToolbar (p: System.Boolean) = "ShowToolbar" => p
    let inline toolbarClass (p: System.String) = "ToolbarClass" => p
    let inline pickerVariant (p: MudBlazor.PickerVariant) = "PickerVariant" => p
    let inline variant (p: MudBlazor.Variant) = "Variant" => p
    let inline adornment (p: MudBlazor.Adornment) = "Adornment" => p
    let inline orientation (p: MudBlazor.Orientation) = "Orientation" => p
    let inline iconSize (p: MudBlazor.Size) = "IconSize" => p
    let inline color (p: MudBlazor.Color) = "Color" => p

    let inline onTextChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.String> "TextChanged" p

    let inline immediateText (p: System.Boolean) = "ImmediateText" => p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline text (p: System.String) = "Text" => p
    let inline actionsClass (p: System.String) = "ActionsClass" => p

    let inline pickerActions
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p:
            MudBlazor.MudPicker<System.Nullable<System.TimeSpan>> -> Bolero.Node)
        =
        attr.fragmentWith "PickerActions" p

    let inline margin (p: MudBlazor.Margin) = "Margin" => p
    let inline mask (p: MudBlazor.IMask) = "Mask" => p
    let inline anchorOrigin (p: MudBlazor.Origin) = "AnchorOrigin" => p
    let inline transformOrigin (p: MudBlazor.Origin) = "TransformOrigin" => p
    let inline overflowBehavior (p: MudBlazor.OverflowBehavior) = "OverflowBehavior" => p
    let inline relativeWidth (p: MudBlazor.DropdownWidth) = "RelativeWidth" => p
    let inline required (p: System.Boolean) = "Required" => p
    let inline requiredError (p: System.String) = "RequiredError" => p
    let inline errorText (p: System.String) = "ErrorText" => p
    let inline error (p: System.Boolean) = "Error" => p
    let inline errorId (p: System.String) = "ErrorId" => p
    let inline converter (p: MudBlazor.Converter<System.Nullable<System.TimeSpan>, System.String>) = "Converter" => p
    let inline culture (p: System.Globalization.CultureInfo) = "Culture" => p
    let inline validation (p: System.Object) = "Validation" => p

    let inline ``for`` (p: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.TimeSpan>>>) =
        "For" => p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudToggleGroup<'T37> = comp<MudBlazor.MudToggleGroup<'T37>>

module mudToggleGroupAttrs =
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline value (p: 'T37) = "Value" => p
    let inline onValueChanged<'T37> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) = attr.callback<'T37> "ValueChanged" p
    let inline values<'T37> (p: System.Collections.Generic.IEnumerable<'T37>) = "Values" => p

    let inline onValuesChanged<'T37> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IEnumerable<'T37>> "ValuesChanged" p

    let inline selectedClass (p: System.String) = "SelectedClass" => p
    let inline checkMarkClass (p: System.String) = "CheckMarkClass" => p
    let inline vertical (p: System.Boolean) = "Vertical" => p
    let inline outlined (p: System.Boolean) = "Outlined" => p
    let inline delimiters (p: System.Boolean) = "Delimiters" => p
    let inline ripple (p: System.Boolean) = "Ripple" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline selectionMode (p: MudBlazor.SelectionMode) = "SelectionMode" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline checkMark (p: System.Boolean) = "CheckMark" => p
    let inline fixedContent (p: System.Boolean) = "FixedContent" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudToggleItem<'T38> = comp<MudBlazor.MudToggleItem<'T38>>

module mudToggleItemAttrs =
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline value (p: 'T38) = "Value" => p
    let inline unselectedIcon (p: System.String) = "UnselectedIcon" => p
    let inline selectedIcon (p: System.String) = "SelectedIcon" => p
    let inline text (p: System.String) = "Text" => p

    let inline childContent ([<Microsoft.FSharp.Core.InlineIfLambda>] p: System.Boolean -> Bolero.Node) =
        attr.fragmentWith "ChildContent" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudToolBar = comp<MudBlazor.MudToolBar>

module mudToolBarAttrs =
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline wrapContent (p: System.Boolean) = "WrapContent" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTooltip = comp<MudBlazor.MudTooltip>

module mudTooltipAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline text (p: System.String) = "Text" => p
    let inline arrow (p: System.Boolean) = "Arrow" => p
    let inline duration (p: System.Double) = "Duration" => p
    let inline delay (p: System.Double) = "Delay" => p
    let inline placement (p: MudBlazor.Placement) = "Placement" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline tooltipContent p = attr.fragment "TooltipContent" p
    let inline ``inline`` (p: System.Boolean) = "Inline" => p
    let inline rootStyle (p: System.String) = "RootStyle" => p
    let inline rootClass (p: System.String) = "RootClass" => p
    let inline showOnHover (p: System.Boolean) = "ShowOnHover" => p
    let inline showOnFocus (p: System.Boolean) = "ShowOnFocus" => p
    let inline showOnClick (p: System.Boolean) = "ShowOnClick" => p
    let inline visible (p: System.Boolean) = "Visible" => p

    let inline onVisibleChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "VisibleChanged" p

    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTreeView<'T39> = comp<MudBlazor.MudTreeView<'T39>>

module mudTreeViewAttrs =
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline checkBoxColor (p: MudBlazor.Color) = "CheckBoxColor" => p
    let inline selectionMode (p: MudBlazor.SelectionMode) = "SelectionMode" => p
    let inline triState (p: System.Boolean) = "TriState" => p
    let inline autoSelectParent (p: System.Boolean) = "AutoSelectParent" => p
    let inline expandOnClick (p: System.Boolean) = "ExpandOnClick" => p
    let inline expandOnDoubleClick (p: System.Boolean) = "ExpandOnDoubleClick" => p
    let inline autoExpand (p: System.Boolean) = "AutoExpand" => p
    let inline hover (p: System.Boolean) = "Hover" => p
    let inline dense (p: System.Boolean) = "Dense" => p
    let inline height (p: System.String) = "Height" => p
    let inline maxHeight (p: System.String) = "MaxHeight" => p
    let inline width (p: System.String) = "Width" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p

    let inline filterFunc<'T39>
        (p: System.Func<MudBlazor.TreeItemData<'T39>, System.Threading.Tasks.Task<System.Boolean>>)
        =
        "FilterFunc" => p

    let inline ripple (p: System.Boolean) = "Ripple" => p

    let inline items<'T39> (p: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T39>>) =
        "Items" => p

    let inline selectedValue (p: 'T39) = "SelectedValue" => p

    let inline onSelectedValueChanged<'T39> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<'T39> "SelectedValueChanged" p

    let inline selectedValues<'T39> (p: System.Collections.Generic.IReadOnlyCollection<'T39>) = "SelectedValues" => p

    let inline onSelectedValuesChanged<'T39> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IReadOnlyCollection<'T39>> "SelectedValuesChanged" p

    let inline childContent p = attr.fragment "ChildContent" p

    let inline itemTemplate<'T39>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.TreeItemData<'T39> -> Bolero.Node)
        =
        attr.fragmentWith "ItemTemplate" p

    let inline comparer<'T39> (p: System.Collections.Generic.IEqualityComparer<'T39>) = "Comparer" => p

    let inline serverData<'T39>
        (p:
            System.Func<
                'T39,
                System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T39>>>
             >)
        =
        "ServerData" => p

    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline checkedIcon (p: System.String) = "CheckedIcon" => p
    let inline uncheckedIcon (p: System.String) = "UncheckedIcon" => p
    let inline indeterminateIcon (p: System.String) = "IndeterminateIcon" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTreeViewItem<'T40> = comp<MudBlazor.MudTreeViewItem<'T40>>

module mudTreeViewItemAttrs =
    let inline value (p: 'T40) = "Value" => p
    let inline text (p: System.String) = "Text" => p
    let inline textTypo (p: MudBlazor.Typo) = "TextTypo" => p
    let inline textClass (p: System.String) = "TextClass" => p
    let inline endText (p: System.String) = "EndText" => p
    let inline endTextTypo (p: MudBlazor.Typo) = "EndTextTypo" => p
    let inline endTextClass (p: System.String) = "EndTextClass" => p
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline readOnly (p: System.Boolean) = "ReadOnly" => p
    let inline canExpand (p: System.Boolean) = "CanExpand" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline content p = attr.fragment "Content" p

    let inline bodyContent<'T40>
        ([<Microsoft.FSharp.Core.InlineIfLambda>] p: MudBlazor.MudTreeViewItem<'T40> -> Bolero.Node)
        =
        attr.fragmentWith "BodyContent" p

    let inline items<'T40> (p: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T40>>) =
        "Items" => p

    let inline onItemsChanged<'T40> ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T40>>> "ItemsChanged" p

    let inline expanded (p: System.Boolean) = "Expanded" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline selected (p: System.Boolean) = "Selected" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline iconExpanded (p: System.String) = "IconExpanded" => p
    let inline iconColor (p: MudBlazor.Color) = "IconColor" => p
    let inline endIcon (p: System.String) = "EndIcon" => p
    let inline endIconColor (p: MudBlazor.Color) = "EndIconColor" => p
    let inline expandButtonIcon (p: System.String) = "ExpandButtonIcon" => p
    let inline expandButtonIconColor (p: MudBlazor.Color) = "ExpandButtonIconColor" => p
    let inline loadingIcon (p: System.String) = "LoadingIcon" => p
    let inline loadingIconColor (p: MudBlazor.Color) = "LoadingIconColor" => p

    let inline onSelectedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "SelectedChanged" p

    let inline onOnClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" p

    let inline onOnDoubleClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnDoubleClick" p

    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudTreeViewItemToggleButton = comp<MudBlazor.MudTreeViewItemToggleButton>

module mudTreeViewItemToggleButtonAttrs =
    let inline visible (p: System.Boolean) = "Visible" => p
    let inline disabled (p: System.Boolean) = "Disabled" => p
    let inline expanded (p: System.Boolean) = "Expanded" => p
    let inline loading (p: System.Boolean) = "Loading" => p

    let inline onExpandedChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Boolean> "ExpandedChanged" p

    let inline loadingIcon (p: System.String) = "LoadingIcon" => p
    let inline loadingIconColor (p: MudBlazor.Color) = "LoadingIconColor" => p
    let inline expandedIcon (p: System.String) = "ExpandedIcon" => p
    let inline expandedIconColor (p: MudBlazor.Color) = "ExpandedIconColor" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudText = comp<MudBlazor.MudText>

module mudTextAttrs =
    let inline typo (p: MudBlazor.Typo) = "Typo" => p
    let inline align (p: MudBlazor.Align) = "Align" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline gutterBottom (p: System.Boolean) = "GutterBottom" => p
    let inline ``inline`` (p: System.Boolean) = "Inline" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline htmlTag (p: System.String) = "HtmlTag" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudVirtualize<'T41> = comp<MudBlazor.MudVirtualize<'T41>>

module mudVirtualizeAttrs =
    let inline enabled (p: System.Boolean) = "Enabled" => p

    let inline childContent<'T41> ([<Microsoft.FSharp.Core.InlineIfLambda>] p: 'T41 -> Bolero.Node) =
        attr.fragmentWith "ChildContent" p

    let inline placeholder p = attr.fragment "Placeholder" p
    let inline noRecordsContent p = attr.fragment "NoRecordsContent" p
    let inline items<'T41> (p: System.Collections.Generic.ICollection<'T41>) = "Items" => p

    let inline itemsProvider<'T41> (p: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'T41>) =
        "ItemsProvider" => p

    let inline overscanCount (p: System.Int32) = "OverscanCount" => p
    let inline itemSize (p: System.Single) = "ItemSize" => p
    let inline spacerElement (p: System.String) = "SpacerElement" => p

let mudTimeSeriesChart = comp<MudBlazor.MudTimeSeriesChart>

module mudTimeSeriesChartAttrs =
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.TimeSeriesChartSeries>) = "ChartSeries" => p
    let inline timeLabelSpacing (p: System.TimeSpan) = "TimeLabelSpacing" => p
    let inline timeLabelFormat (p: System.String) = "TimeLabelFormat" => p
    let inline xAxisTitle (p: System.String) = "XAxisTitle" => p
    let inline yAxisTitle (p: System.String) = "YAxisTitle" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudContainer = comp<MudBlazor.MudContainer>

module mudContainerAttrs =
    let inline ``fixed`` (p: System.Boolean) = "Fixed" => p
    let inline maxWidth (p: MudBlazor.MaxWidth) = "MaxWidth" => p
    let inline gutters (p: System.Boolean) = "Gutters" => p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let mudRender = comp<MudBlazor.MudRender>

module mudRenderAttrs =
    let inline childContent p = attr.fragment "ChildContent" p

let mudSpacer = comp<MudBlazor.MudSpacer>
let mudInputAdornment = comp<MudBlazor.Internal.MudInputAdornment>

module mudInputAdornmentAttrs =
    let inline ``class`` (p: System.String) = "Class" => p
    let inline text (p: System.String) = "Text" => p
    let inline icon (p: System.String) = "Icon" => p
    let inline placement (p: MudBlazor.Adornment) = "Placement" => p
    let inline size (p: MudBlazor.Size) = "Size" => p
    let inline color (p: MudBlazor.Color) = "Color" => p
    let inline ariaLabel (p: System.String) = "AriaLabel" => p

    let inline onAdornmentClick ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AdornmentClick" p

let snackbarMessageMarkupString =
    comp<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageMarkupString>

module snackbarMessageMarkupStringAttrs =
    let inline message (p: Microsoft.AspNetCore.Components.MarkupString) = "Message" => p

let snackbarMessageRenderFragment =
    comp<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageRenderFragment>

module snackbarMessageRenderFragmentAttrs =
    let inline message p = attr.fragment "Message" p

let snackbarMessageText =
    comp<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageText>

module snackbarMessageTextAttrs =
    let inline message (p: System.String) = "Message" => p

let bar = comp<MudBlazor.Charts.Bar>

module barAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let donut = comp<MudBlazor.Charts.Donut>

module donutAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let heatMap = comp<MudBlazor.Charts.HeatMap>

module heatMapAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let line = comp<MudBlazor.Charts.Line>

module lineAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let pie = comp<MudBlazor.Charts.Pie>

module pieAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let stackedBar = comp<MudBlazor.Charts.StackedBar>

module stackedBarAttrs =
    let inline inputData (p: System.Double[]) = "InputData" => p
    let inline inputLabels (p: System.String[]) = "InputLabels" => p
    let inline xAxisLabels (p: System.String[]) = "XAxisLabels" => p
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let timeSeries = comp<MudBlazor.Charts.TimeSeries>

module timeSeriesAttrs =
    let inline chartSeries (p: System.Collections.Generic.List<MudBlazor.TimeSeriesChartSeries>) = "ChartSeries" => p
    let inline timeLabelSpacing (p: System.TimeSpan) = "TimeLabelSpacing" => p
    let inline timeLabelFormat (p: System.String) = "TimeLabelFormat" => p
    let inline xAxisTitle (p: System.String) = "XAxisTitle" => p
    let inline yAxisTitle (p: System.String) = "YAxisTitle" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let legend = comp<MudBlazor.Charts.Legend>

module legendAttrs =
    let inline data (p: System.Collections.Generic.List<MudBlazor.SvgLegend>) = "Data" => p
    let inline chartOptions (p: MudBlazor.ChartOptions) = "ChartOptions" => p
    let inline customGraphics p = attr.fragment "CustomGraphics" p
    let inline childContent p = attr.fragment "ChildContent" p
    let inline chartType (p: MudBlazor.ChartType) = "ChartType" => p
    let inline width (p: System.String) = "Width" => p
    let inline height (p: System.String) = "Height" => p
    let inline legendPosition (p: MudBlazor.Position) = "LegendPosition" => p
    let inline selectedIndex (p: System.Int32) = "SelectedIndex" => p

    let inline onSelectedIndexChanged ([<Microsoft.FSharp.Core.InlineIfLambda>] p) =
        attr.callback<System.Int32> "SelectedIndexChanged" p

    let inline canHideSeries (p: System.Boolean) = "CanHideSeries" => p
    let inline ``class`` (p: System.String) = "Class" => p
    let inline style (p: System.String) = "Style" => p
    let inline tag (p: System.Object) = "Tag" => p

let filters = comp<MudBlazor.Charts.Filters>
