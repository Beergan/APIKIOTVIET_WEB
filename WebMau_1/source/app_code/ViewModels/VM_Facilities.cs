using SLK.Common;

public class VM_Facilities : VM_Base
{
    [Field(
       Title = "en:Description Facilities|vi:Mô tả cơ sở",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Description_Facilities { get; set; }

    [Field(
        Title = "en:Icon Facilities|vi:Icon cơ sở",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Icon_Facilities { get; set; }

    [Field(
        Title = "en:Class|vi:Class",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class { get; set; }
}