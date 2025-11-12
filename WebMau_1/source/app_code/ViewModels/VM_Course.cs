using SLK.Common;

public class VM_Course : VM_Base
{
    [Field(
        Title = "en:Banner image|vi:Hình nền banner",
        Required = false,
        Control = InputControlType.Image)]
    public string BannerImage { get; set; }

    [Field(
        Title = "en:Content|vi:Nội dung",
        Required = false,
        Control = InputControlType.RichTextBox)]
    public string Content { get; set; }

    [Field(
       Title = "en:Link Image|vi:Đường dẫn",
       Required = false,
       Control = InputControlType.Link)]
    public string LinkImage { get; set; }

    [Field(
        Title = "Youtube video id",
        Required = false,
        Control = InputControlType.TextBox)]
    public string YouTubeVideoId { get; set; }

    [Field(
       Title = "Price|Giá",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Price { get; set; }

    [Field(
        Title = "Evaluate|Đánh giá",
        Required = false,
        Control = InputControlType.TextBox)]
    public string EvaluateCourse { get; set; }

    [Field(
        Title = "Star|Đánh sao",
        Required = false,
        Control = InputControlType.Number,
        Options = new string[] { "1", "2", "3", "4", "5" })]
    public int Stars { get; set; }    

    [Field(
        Title = "en:Name author|vi:Tên tác giả",
        Required = false,
        Control = InputControlType.TextBox)]
    public string NameAuthor { get; set; }

    [Field(
        Title = "en:Image author|vi:Hình đại diện",
        Required = false,
        Control = InputControlType.TextBox)]
    public string ImageAuthor { get; set; }
 
    [Field(
        Title = "Lectures tiltle|Tiêu đề bài giảng",
        Required = false,
        Control = InputControlType.TextBox)]
    public string TitleLectures { get; set; }

    [Field(
        Title = "Lectures|Số bài giảng",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Lectures { get; set; }

    [Field(
        Title = "Quizzes tiltle|Tiêu đề bài trắc nghiệm",
        Required = false,
        Control = InputControlType.TextBox)]
    public string TitleQuizzes { get; set; }

    [Field(
        Title = "Quizzes|Số bài trắc nghiệm",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Quizzes { get; set; }

    [Field(
        Title = "Practice tiltle|Tiêu đề bài thực hành",
        Required = false,
        Control = InputControlType.TextBox)]
    public string TitlePractice { get; set; }

    [Field(
       Title = "Practices|Số bài thực hành",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Practice { get; set; }


    [Field(
        Title = "Duration tiltle|Tiêu đề thời lượng",
        Required = false,
        Control = InputControlType.TextBox)]
    public string TitleDuration { get; set; }

    [Field(
        Title = "Duration|Thời lượng",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Duration { get; set; }

    [Field(
        Title = "StudentCount tiltle|Tiêu đề số học viên",
        Required = false,
        Control = InputControlType.TextBox)]
    public string TitleStudentCount { get; set; }

    [Field(
        Title = "Users|Số học viên",
        Required = false,
        Control = InputControlType.TextBox)]
    public string StudentCount { get; set; }

    [Field(
        Title = "Assessments tiltle|Tiêu đề đánh giá cuối kỳ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string TitleAssessments { get; set; }

    [Field(
        Title = "Assessments|Đánh giá cuối kỳ",
        Required = false,
        Control = InputControlType.CheckBox)]
    public bool Assessments { get; set; }
}