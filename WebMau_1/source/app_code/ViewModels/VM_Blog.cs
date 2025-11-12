using SLK.Common;

public class VM_Blog : VM_Base
{
    [Field(
        Title = "en:Author|vi:Tác giả",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Author { get; set; }

    [Field(
        Title = "en:Content|vi:Nội dung",
        Required = false,
        Control = InputControlType.RichTextBox)]
    public string Content { get; set; }

    [Field(
        Title = "en:Count comment|vi:Số lượng bình luận",
        Required = false,
        Control = InputControlType.Number)]
    public int CountComment { get; set; }

}