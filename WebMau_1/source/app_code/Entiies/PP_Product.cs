using PetaPoco;
using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pp_product")]
public class PP_Product 
{
	public DateTime CreatedDate { get; set; }
	public long Id { get; set; }
	public long RetailerId { get; set; }
	public string Code { get; set; } 
	public string Name { get; set; } 
	public string FullName { get; set; }
	public long CategoryId { get; set; }
	public string CategoryName { get; set; }
	public bool AllowsSale { get; set; } 
	public int Type { get; set; } 
	public bool HasVariants { get; set; } 
	public decimal BasePrice { get; set; } 
	public int ConversionValue { get; set; }
	public string Description { get; set; }
	public DateTime ModifiedDate { get; set; } 
	public bool IsActive { get; set; } = false;
	public bool IsLotSerialControl { get; set; } 
	public bool IsBatchExpireControl { get; set; } 
	public string Images { get; set; } 
	public string Path { get; set; }
}

