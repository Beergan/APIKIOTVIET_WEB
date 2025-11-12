using SLK.Common;

public class VM_Skill : VM_Base
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
    public string Title_Skill { get; set; }

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
}