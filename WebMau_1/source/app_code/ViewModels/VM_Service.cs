using SLK.Common;

public class VM_Service : VM_Base
{
    [Field(
        Title = "en:Descripttion|vi:Mô tả",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Description { get; set; }

    [Field(
        Title = "en:Backgound color|vi:Màu nền",
        Required = false,
        Control = InputControlType.TextBox)]
    public string BackgroundColor { get; set; }

    [Field(
        Title = "en:Image|vi:Ảnh",
        Required = false,
        Control = InputControlType.Image)]
    public string Image { get; set; }

    [Field(
        Title = "en:Icon services|vi:Icon dịch vụ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Icon_Services { get; set; }

    [Field(
        Title = "en:Title services|vi:Tiêu đề dịch vụ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title_services { get; set; }

    [Field(
        Title = "en:Description services|vi:Mô tả dịch vụ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Description_Services { get; set; }

    [Field(
        Title = "en:Link services|vi:Link dịch vụ",
        Required = false,
        Control = InputControlType.Link)]
    public string Link_Services { get; set; }

    [Field(
        Title = "en:Class services|vi:Class dịch vụ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class_Services { get; set; }
}