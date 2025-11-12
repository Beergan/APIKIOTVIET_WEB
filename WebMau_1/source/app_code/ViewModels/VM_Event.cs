using SLK.Common;
using System;

public class VM_Event : VM_Base
{
    [Field(
        Title = "en:Event description|vi:Mô tả sự kiện",
        Required = false,
        Control = InputControlType.RichTextBox)]
    public string Content { get; set; }

    [Field(
        Title = "en:Address|vi:Địa chỉ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Address { get; set; }

    [Field(
       Title = "en:Time|vi:Thời gian diễn ra",
       Required = false,
       Control = InputControlType.TextBox)]
    public string EventTime { get; set; }

    [Field(
       Title = "en:Day|vi:Ngày diễn ra",
       Required = false,
       Control = InputControlType.TextBox)]
    public string EventTime_Day { get; set; }

    [Field(
       Title = "en:Class|vi:Class",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Class { get; set; }

    [Field(
       Title = "en:Math|vi:Math",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Math { get; set; }

    [Field(
       Title = "en:Link Math|vi:Link Math",
       Required = false,
       Control = InputControlType.Link)]
    public string LinkMath { get; set; }

    [Field(
       Title = "en:English|vi:English",
       Required = false,
       Control = InputControlType.TextBox)]
    public string English { get; set; }

    [Field(
       Title = "en:Link English|vi:LInk English",
       Required = false,
       Control = InputControlType.Link)]
    public string LinkEnglish { get; set; }

    [Field(
        Title = "en:User|vi:User",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Usser { get; set; }

    [Field(
        Title = "en:Comment|vi:Comment",
        Required = false,
        Control = InputControlType.Number)]
    public int Comment { get; set; }

    [Field(
        Title = "en:Link Comment|vi:Link Comment",
        Required = false,
        Control = InputControlType.Link)]
    public string LinkComment { get; set; }

    [Field(
        Title = "en:Link Button|vi:Link Button",
        Required = false,
        Control = InputControlType.Link)]
    public string LinkButton { get; set; }

    [Field(Title = "en:Descripttion|vi:Mô tả",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Description { get; set; }
}