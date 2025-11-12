using SLK.Common;

public class VM_Partner : VM_Base
{
    [Field(
        Title = "en:Image|vi:Ảnh",
        Required = false,
        Control = InputControlType.RichTextBox)]
    public string Image { get; set; }

    [Field(
        Title = "en:Link Image|vi:Link Ảnh",
        Required = false,
        Control = InputControlType.Link)]
    public string LinkImage { get; set; }
}