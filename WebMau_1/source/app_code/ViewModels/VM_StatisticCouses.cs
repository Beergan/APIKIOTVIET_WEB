using SLK.Common;

public class VM_StatisticCouses
{
    [Field(
        Title = "en:Finished sessions|vi:Đã hoàn thành",
        Required = false,
        Control = InputControlType.Number)]
    public int FinishedSessions { get; set; }

    [Field(
        Title = "en:Enrolled learners|vi:Người học đã đăng ký",
        Required = false,
        Control = InputControlType.Number)]
    public int EnrolledLearners { get; set; }

    [Field(
        Title = "en:Online instructors|vi:Giảng viên trực tuyến",
        Required = false,
        Control = InputControlType.Number)]
    public int OnlineInstructors { get; set; }

    [Field(
        Title = "en:Satisfaction rate|vi:Tỷ lệ hài lòng",
        Required = false,
        Control = InputControlType.Number)]
    public int SatisfactionRate { get; set; }

    [Field(
        Title = "en:Background image|vi:Hinh nền banner",
        Required = false,
        Control = InputControlType.Image)]
    public string BackgroundImage { get; set; }
}