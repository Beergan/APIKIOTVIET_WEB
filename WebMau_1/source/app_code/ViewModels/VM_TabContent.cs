using SLK.Common;

public class VM_TabContent : VM_Base
{
    [Field(
        Title = "en:Class|vi:Class",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class { get; set; }    

    [Field(
        Title = "en:Id Tab|vi:Id Tab",
        Required = false,
        Control = InputControlType.TextBox)]
    public string IdTab { get; set; }

    [Field(
        Title = "en:Active|vi:Active",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Active { get; set; }

    [Field(
        Title = "en:aria-labelledby|vi:aria-labelledby",
        Required = false,
        Control = InputControlType.TextBox)]
    public string aria_labelledby { get; set; }
    
}