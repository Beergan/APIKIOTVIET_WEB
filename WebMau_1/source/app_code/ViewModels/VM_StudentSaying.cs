using SLK.Common;

public class VM_StudentSaying : VM_Base
{
    [Field(
        Title = "en:Image|vi:Ảnh",
        Required = false,
        Control = InputControlType.Image)]
    public string Image { get; set; }

    [Field(
        Title = "en:Content|vi:Nội dung",
        Required = false,
        Control = InputControlType.TextArea)]
    public string Content { get; set; }
	[Field(
	  Title = "en:Image|vi:Ảnh thành viên",
	  Required = false,
	  Control = InputControlType.Image)]
	public string Imagecus { get; set; }

	[Field(
        Title = "en:Name|vi:Tên",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Name { get; set; }
	[Field(
		Title = "Trình độ",
		Required = false,
		Control = InputControlType.TextBox)]
	public string Level{ get; set; }
	[Field(
	   Title = "en:Name|vi:Điển",
	   Required = false,
	   Control = InputControlType.TextBox)]
	public string poin { get; set; }
	[Field(
		   Title = "en:Designation|vi:Tuổi",
		   Required = false,
		   Control = InputControlType.TextBox)]
	public string Designation { get; set; }

	[Field(
	  Title = "Star|Đánh sao",
	  Required = false,
	  Control = InputControlType.Combobox,
		Options = new string[] { "1", "2", "3", "4", "5" })]
	public int Stars { get; set; }
}