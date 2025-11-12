using PetaPoco;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pp_product")]
public class PP_Product : EntityBase
{

    [Display(Name = "en:Language|vi:Ngôn ngữ")]
    public string LangId { get; set; }

    [Display(Name = "en:Page template|vi:Mẫu hiển thị")]
    public int PageId { get; set; }

    [Display(Name = "en:Category|vi:Chuyên mục")]
    public int? CategoryId { get; set; }

    [Display(Name = "en:Status|vi:Trạng thái")]
    public string NodeStatus { get; set; }

    [Display(Name = "en:Title|vi:Tiêu đề")]
    public string Title { get; set; }

    [Display(Name = "en:Path|vi:Đường dẫn")]
    public string NodePath { get; set; }

    [Display(Name = "en:Mô tả sản phẩm|vi:Mô tả sản phẩm")]
    public string Content { get; set; }

    [Display(Name = "en:Price|vi:Giá")]
    public decimal Price { get; set; }

    [Display(Name = "en:Promotion percent|vi:Phần trăm khuyến mãi")]
    public decimal PromotionPercent { get; set; }

    [Display(Name = "en:Product state|vi:Trạng thái")]
    public string ProductState { get; set; }

    [Display(Name = "en:Promotion enabled|vi:Kích hoạt khuyến mãi")]
    public bool PromotionEnabled { get; set; }

    [Display(Name = "en:Promotion expiration|vi:Thời hạn khuyến mãi")]
    public DateTime? PromotionExpiration { get; set; }

    [Display(Name = "en:Featured|vi:Nổi bật")]
    public Boolean Featured { get; set; }

    [Display(Name = "en:Best seller|vi:Sản phẩm bán chạy")]
    public bool BestSeller { get; set; }

    [Display(Name = "en:Manufacturing date|vi: Ngày sản xuất")]
    public DateTime ManufacturingDate { get; set; }

    [Display(Name = "en:Expired day|vi: Hạn sử dụng")]
    public int Life { get; set; }

    [Display(Name = "en:Tags|vi: Thẻ sản phẩm")]
    public string Tags { get; set; }

    public string MetaDescription { get; set; }

    public string MetaKeywords { get; set; }

    [Display(Name = "en:Image|vi:Ảnh đại diện")]
    public string ImageUrl { get; set; }

    public decimal PromotionPrice { get; set; }

    [NotMapped]
    [Ignore]
    public string Breadcrumb { get; set; }

    public PP_Product SetBreadcrumb(string b)
    {
        this.Breadcrumb = b;
        return this;
    }
}
