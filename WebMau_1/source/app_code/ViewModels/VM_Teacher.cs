using SLK.Common;
using System;

public class VM_Teacher : VM_Base
{

    [Field(
        Title = "en:Sub title|vi:Tiêu đề phụ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string SubTitle { get; set; }

    [Field(
      Title = "Email",
      Required = false,
      Control = InputControlType.TextBox)]
    public string Email { get; set; }

    [Field(
       Title = "Phone",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Phone { get; set; }

    [Field(
        Title = "Facebook",
        Required = false,
        Control = InputControlType.TextBox)]
    public string LinkFacebook { get; set; }

    [Field(
        Title = "Twitter",
        Required = false,
        Control = InputControlType.TextBox)]
    public string LinkTwitter { get; set; }

    [Field(
        Title = "Linkedin",
        Required = false,
        Control = InputControlType.TextBox)]
    public string LinkLinkedin { get; set; }

    [Field(
       Title = "Link google",
       Required = false,
       Control = InputControlType.TextBox)]
    public string LinkGoogle { get; set; }

    [Field(
    Title = "en:Rank|vi:Cấp bậc",
    Required = false,
    Control = InputControlType.TextBox)]
    public string Rank { get; set; }

    [Field(
        Title = "en:Total student|vi:Tổng số sinh viên",
        Required = false,
        Control = InputControlType.Number)]
    public int TotalStudent { get; set; }

    [Field(
          Title = "Star|Đánh sao",
          Required = false,
          Control = InputControlType.Combobox,
        Options = new string[] { "1", "2", "3", "4", "5" })]
    public int Stars { get; set; }

    [Field(
      Title = "Rating|Nhận xét",
      Required = false,
      Control = InputControlType.Number)]
    public int Rating { get; set; }

    [Field(
      Title = "Reviews|Đánh giá",
      Required = false,
      Control = InputControlType.Number)]
    public int Reviews { get; set; }

    [Field(
            Title = "en:My descripttion|vi:Mô tả về tôi",
            Required = false,
            Control = InputControlType.TextArea)]
    public string MyDescription { get; set; }

    [Field(
           Title = "en:My title about|vi:Tiêu đề về tôi",
           Required = false,
           Control = InputControlType.TextBox)]
    public string MyTitleAbout { get; set; }

    [Field(
           Title = "en:Skill title|vi:Tiêu đề kĩ năng",
           Required = false,
           Control = InputControlType.TextBox)]
    public string SkillTitle { get; set; }

    [Field(
            Title = "en:Content part|vi:Phần nội dung",
            Required = false,
            Control = InputControlType.TextArea)]
    public string ContentPart { get; set; }

    [Field(
           Title = "en:Title content part|vi:Tiêu đề phần nội dung",
           Required = false,
           Control = InputControlType.TextArea)]
    public string TitleContentPart { get; set; }

    public class Skill
    {
        [Field(
      Title = "Title|Title",
      Required = false,
      Control = InputControlType.TextBox)]
        public string Title { get; set; }

        [Field(
          Title = "Percent|Phần trăm",
          Required = false,
          Control = InputControlType.Number)]
        public int Percent { get; set; }

    }
    [Field(Title = "en:Skills|vi:Các kĩ năng")]
    public Skill[] Skills { get; set; }
}