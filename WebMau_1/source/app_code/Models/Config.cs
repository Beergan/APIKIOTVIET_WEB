using SLK.Common;

public class Config
{
    public Config()
    {
        MainMenus = new MenuItem[]
            {
                new MenuItem {
                    Title ="TRANG CHỦ",
                    Href ="#"
                },
                new MenuItem {
                    Title ="GIỚI THIỆU",
                    Href ="#",
                    },
                new MenuItem {
                    Title ="KHÓA HỌC",
                    Href ="#"
                },
                new MenuItem {
                    Title ="GIÁO VIÊN",
                    Href ="#"
                },
                new MenuItem {
                    Title ="TIN TỨC",
                    Href ="#"
                },
                new MenuItem {
                    Title ="LIÊN HỆ",
                    Href ="#"
                },
            };
        ComplainItems = new ComplainItem[]
            {
                new ComplainItem {
                    Name ="Mr.Sang",
                    Phone ="0352889129"
                },
                new ComplainItem {
                    Name ="Mr.Pờm",
                    Phone ="0372461306"
                },
            };
        this.WebTitle = "VIET GROUP";
        this.LinkMap = "https://maps.google.com/maps?q=Fort%20Miley&t=&z=13&ie=UTF8&iwloc=&output=embed";
        this.Favicon = "/assets/images/pre-logo.png";
        this.GoogleGtag = "1234";
        this.LinkFacebook = "https://facebook.com";
        this.LinkInstagram = "https://www.instagram.com";
        this.LinkGoogle = "https://www.google.com";
        this.LinkTwitter = "#";
        this.LinkPinterest = "#";
        this.Company = new CompanyInfo
        {
            CompanyName = "Công Ty Cổ Phần Việt Group",
            Slogan = "Xây dựng chuyên nghiệp trong lĩnh vực xây dựng công trình vốn tư nhân có dịch vụ chất lượng cao.",
            Address = "251A Quang Trung, thành phố Đồng Hới, tỉnh Quảng Bình",
            Hotline = "(84-52) 3 710 688",
            Email = "office@pvctruongson.com",
            WorkingHours = "8:00 Sáng - 17:00 Chiều",
            Website = "www.vietgroup.com",
            ContactPhone = "(84-52) 3 710 688",
            CopyrightText = @"Copyright 2016 Viet Group. All rights reserved. Design by slk.vn"
        };
        this.popup = new Popup();
        {
            popup.ImgPopup = "/upload/Web%20(600%20x%20250%20px)%20(1).jpg";
            popup.LinkPopup = "#";
            popup.button = false;
            popup.Popupsub = new Popupsub[]
            {
                new Popupsub
                {
                    Title="Võ Thị Sáu",
                },
                   new Popupsub
                {
                    Title="Phạm Văn Thuận",
                },
            };


        }
        this.ImgLoader = "admin/assets/images/logo-sm.png";
    }

    [Field(
        Title = "Tiêu đề website",
        Required = false,
        Control = InputControlType.TextBox)]
    public string WebTitle { get; set; }

    [Field(
        Title = "Favicon",
        Required = false,
        Control = InputControlType.Image)]
    public string Favicon { get; set; }


    [Field(
        Title = "Hình loading",
        Required = false,
        Control = InputControlType.Image)]
    public string ImgLoader { get; set; }

    [Field(
        Title = "Google Gtag",
        Required = false,
        Control = InputControlType.TextBox)]
    public string GoogleGtag { get; set; }

    [Field(
        Title = "Link bản đồ",
        Required = false,
        Control = InputControlType.TextBox)]
    public string LinkMap { get; set; }

    [Field(
       Title = "Link facebook",
       Required = false,
       Control = InputControlType.TextBox)]
    public string LinkFacebook { get; set; }

    [Field(
      Title = "Link mess",
      Required = false,
      Control = InputControlType.TextBox)]
    public string LinkMess { get; set; }

    [Field(
      Title = "Link zalo",
      Required = false,
      Control = InputControlType.TextBox)]
    public string LinkZalo { get; set; }

    [Field(
      Title = "Link twitter",
      Required = false,
      Control = InputControlType.TextBox)]
    public string LinkTwitter { get; set; }

    [Field(
       Title = "Link pinterest",
       Required = false,
       Control = InputControlType.TextBox)]
    public string LinkPinterest { get; set; }

    [Field(
       Title = "Link instagram",
       Required = false,
       Control = InputControlType.TextBox)]
    public string LinkInstagram { get; set; }

    [Field(
       Title = "Link google",
       Required = false,
       Control = InputControlType.TextBox)]
    public string LinkGoogle { get; set; }

    [Field(Title = "Danh sách menu", ChildTitle = "Menu chính")]
    public MenuItem[] MainMenus { get; set; }

    [Field(Title = "Thông tin công ty")]
    public CompanyInfo Company { get; set; }
    [Field(Title = "Thông tin quảng cáo")]
    public Popup popup { get; set; }

    [Field(Title = "Danh sách liên hệ khiếu nại", ChildTitle = "Thông tin liên hệ")]
    public ComplainItem[] ComplainItems { get; set; }
}
public class Popup
{
    [Field(
    Title = "Hình ảnh quảng cáo",
    Required = false,
    Control = InputControlType.Image)]
    public string ImgPopup { get; set; }
    [Field(
    Title = "Đường dẫn quảng cáo",
    Required = false,
    Control = InputControlType.Link)]
    public string LinkPopup { get; set; }

    [Field(
    Title = "Bật/Tắt",
    Required = false,
    Control = InputControlType.CheckBox)]
    public bool button { get; set; }
    [Field(Title = "Thông tin chi nhánh")]

    public Popupsub[] Popupsub { get; set; }
}
public class Popupsub
{
    [Field(
       Title = "en:Title|vi:Chi nhánh",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Title { get; set; }
}
public class MenuItem
{
    [Field(
       Title = "en:Title|vi:Tiêu đề",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Title { get; set; }

    [Field(
       Title = "en:Link|vi:Link",
       Required = false,
       Control = InputControlType.Link)]
    public string Href { get; set; }

    [Field(Title = "Các menu con", ChildTitle = "Menu con")]
    public SubMenu[] SubMenus { get; set; }
}

public class SubMenu
{
    [Field(
       Title = "en:Title|vi:Tiêu đề",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Title { get; set; }

    [Field(
       Title = "en:Link|vi:Link",
       Required = false,
       Control = InputControlType.Link)]
    public string Href { get; set; }

    [Field(
       Title = "en:Link|vi:Link",
       Required = false,
       Control = InputControlType.Image)]
    public string ImageUrl { get; set; }

    [Field(Title = "Các menu con", ChildTitle = "Menu con")]
    public SubMenuLv2[] SubMenusLv2 { get; set; }
}

public class SubMenuLv2
{
    [Field(
       Title = "en:Title|vi:Tiêu đề",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Title { get; set; }

    [Field(
       Title = "en:Link|vi:Link",
       Required = false,
       Control = InputControlType.Link)]
    public string Href { get; set; }

    [Field(Title = "Các menu con", ChildTitle = "Menu con")]
    public SubMenuLv2[] SubMenus { get; set; }
}

public class ComplainItem
{
    [Field(
       Title = "en:Name|vi:Tên",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Name { get; set; }
    [Field(
       Title = "en:Phone|vi:Số điện thoại",
       Required = false,
       Control = InputControlType.TextBox)]
    public string Phone { get; set; }
}

public class CompanyInfo
{
    [Field(
        Title = "en:Slogan|vi:Slogan",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Slogan { get; set; }

    [Field(
        Title = "en:Company name|vi:Tên công ty",
        Required = false,
        Control = InputControlType.TextBox)]
    public string CompanyName { get; set; }

    [Field(
        Title = "Hotline",
        Required = false,
        Control = InputControlType.TextBox)]
    public string Hotline { get; set; }

    [Field(
        Title = "Số điện thoại",
        Required = false,
        Control = InputControlType.TextBox)]
    public string ContactPhone { get; set; }

    [Field(
      Title = "Website",
      Required = false,
      Control = InputControlType.TextBox)]
    public string Website { get; set; }

    [Field(Title = "Địa chỉ chính")]
    public string Address { get; set; }

    [Field(
      Title = "Địa chỉ các chi nhánh",
      Required = false,
      Control = InputControlType.RichTextBox)]
    public string Address2 { get; set; }

    [Field(
      Title = "Email",
      Required = false,
      Control = InputControlType.TextBox)]
    public string Email { get; set; }

    [Field(
        Title = "Copyright Text",
        Required = false,
        Control = InputControlType.TextBox)]
    public string CopyrightText { get; set; }

    [Field(
        Title = "Giờ làm việc",
        Required = false,
        Control = InputControlType.TextBox)]
    public string WorkingHours { get; set; }
}