using SLK.Common;

public class VM_CTA : VM_Base
{
    [Field(
       Title = "en:Description CTA|vi:Mô tả CTA",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Description_CTA { get; set; }    

    [Field(
        Title = "en:Link button|vi:Link button",
        Required = false,
        Control = InputControlType.Link)]
    public string Link_Button { get; set; }

    [Field(
        Title = "en:Class|vi:Class",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class { get; set; }
}