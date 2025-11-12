using SLK.Common;

public class VM_Contact : VM_Base
{
    [Field(
        Title = "en:Tiêu đề email|vi:Tiêu đề email",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title_Email { get; set; }

    [Field(
        Title = "en:Email|vi:Email",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Email { get; set; }

    [Field(
        Title = "en:Tiêu đề số điện thoại 01|vi:Tiêu đề số điện thoại 01",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title_Phone_01 { get; set; }

    [Field(
        Title = "en:Số điện thoại 01|vi:Số điện thoại 01",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Phone_01 { get; set; }

    [Field(
        Title = "en:Tiêu đề số điện thoại 02|vi:Tiêu đề số điện thoại 02",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title_Phone_02 { get; set; }

    [Field(
        Title = "en:Số điện thoại 02|vi:Số điện thoại 02",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Phone_02 { get; set; }

    [Field(
        Title = "en:Tiêu đề địa chỉ|vi:Tiêu đề địa chỉ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Title_Address { get; set; }

    [Field(
        Title = "en:Địa chỉ|vi:Địa chỉ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Address { get; set; }

    [Field(
        Title = "en:Class|vi:Class",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Class { get; set; }

    [Field(
        Title = "en:Đường dẫn số điện thoại 01|vi:Đường dẫn số điện thoại 01",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Link_Phone_01 { get; set; }

    [Field(
        Title = "en:Đường dẫn số điện thoại 02|vi:Đường dẫn số điện thoại 02",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Link_Phone_02 { get; set; }
}