using SLK.Common;

public class VM_Couter : VM_Base
{
    [Field(
        Title = "en:Count|vi:Count",
        Required = false,
        Control = InputControlType.Number)]
    public string Count { get; set; }    

    [Field(
        Title = "en:Title|vi:Title",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title { get; set; }

    [Field(
        Title = "en:Icon|vi:Icon",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Icon { get; set; }

    [Field(
        Title = "en:Class|vi:Class",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class { get; set; }
}