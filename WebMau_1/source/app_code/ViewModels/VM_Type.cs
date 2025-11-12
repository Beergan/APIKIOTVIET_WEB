using SLK.Common;

public class VM_Type : VM_Base
{
    [Field(
        Title = "en:Id|vi:Id",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Id { get; set; }

    [Field(
        Title = "en:Title|vi:Tiêu đề",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title_Type { get; set; }

    [Field(
        Title = "en:Value|vi:Giá trị",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Value { get; set; }

    [Field(
        Title = "en:Checked|vi:Checked",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Checked { get; set; }

    [Field(
        Title = "en:For|vi:For",
        Required = false,
        Control = InputControlType.TextBox)]
    public string For { get; set; }

    [Field(
        Title = "en:Ty count|vi:Type count",
        Required = false,
        Control = InputControlType.Number)]
    public string TypeCount { get; set; }
}