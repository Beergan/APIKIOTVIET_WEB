using SLK.Common;

public class VM_Tab : VM_Base
{
    [Field(
        Title = "en:Class|vi:Class",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class { get; set; }

    [Field(
        Title = "en:Active|vi:Active",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Active { get; set; }

    [Field(
        Title = "en:Icon|vi:Icon",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Icon { get; set; }

    [Field(
        Title = "en:Link|vi:Link",
        Required = false,
        Control = InputControlType.Link)]
    public string Link { get; set; }

    [Field(
        Title = "en:Id|vi:Id",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Id { get; set; }

    [Field(
        Title = "en:aria-controls|vi:aria-controls",
        Required = false,
        Control = InputControlType.TextBox)]
    public string aria_controls { get; set; }

    [Field(
        Title = "en:aria-selected|vi:aria-selected",
        Required = false,
        Control = InputControlType.CheckBox)]
    public bool aria_selected { get; set; }
}