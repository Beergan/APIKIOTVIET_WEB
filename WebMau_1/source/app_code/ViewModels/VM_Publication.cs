using SLK.Common;

public class VM_Publication : VM_Base
{
    [Field(
       Title = "en:Shopping|vi:Shopping",
       Required = false,
       Control = InputControlType.Link)]
    public string Shopping { get; set; }

    [Field(
        Title = "en:Price|vi:Price",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Price { get; set; }

}