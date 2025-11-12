using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pp_order")]
public class PP_Order : EntityBase
{
    public DateTime Date { get; set; }

    [Display(Name = "Tổng cộng")]
    public decimal TotalAmount { get; set; }

    [Display(Name = "Thanh toán")]
    public string PayMethod { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string DeliveryAddress { get; set; }

    public string Province { get; set; }

    public string Ward { get; set; }

    public string Note { get; set; }

    public string JsonData { get; set; }
}