using SLK.Common;

public class VM_StudentReview
{
    [Field(
        Title = "en:Image|vi:Image",
        Required = false,
        Control = InputControlType.Image)]
    public string Image { get; set; }

    [Field(
        Title = "en:Name|vi:Name",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Name { get; set; }

    [Field(
        Title = "en:Description|vi:Description",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Description { get; set; }

    [Field(
        Title = "en:Position|vi:Position",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Position { get; set; }

    [Field(
        Title = "en:Link|vi:Link",
        Required = false,
        Control = InputControlType.Link)]
    public string Link { get; set; }
}