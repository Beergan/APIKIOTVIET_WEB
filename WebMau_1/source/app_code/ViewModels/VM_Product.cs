using System;

public class VM_Product
{
	public DateTime CreatedDate { get; set; } = DateTime.MinValue;
	public long Id { get; set; } 
	public long RetailerId { get; set; } 
	public string Code { get; set; } = "";
	public string Name { get; set; } = "";
	public string FullName { get; set; } = "";
	public long CategoryId { get; set; } 
	public string CategoryName { get; set; }
	public bool AllowsSale { get; set; } = false;
	public int Type { get; set; } = 0;
	public bool HasVariants { get; set; } = false;
	public decimal BasePrice { get; set; } = 0;
	public int ConversionValue { get; set; } = 0;
	public string Description { get; set; } = "";
	public DateTime ModifiedDate { get; set; } = DateTime.MinValue;
	public bool IsActive { get; set; } = false;
	public bool IsLotSerialControl { get; set; } = false;
	public bool IsBatchExpireControl { get; set; } = false;
	public string[] Images { get; set; } = new[] { "https://placehold.co/120x120" };
	public string Path { get; set; }

	public PP_Product MapToEntity(VM_Product vm)
	{
		return new PP_Product
		{
			Id = vm.Id,
			CreatedDate = vm.CreatedDate,
			RetailerId = vm.RetailerId,
			Code = vm.Code,
			Name = vm.Name,
			FullName = vm.FullName,
			CategoryId = vm.CategoryId,
			CategoryName = vm.CategoryName,
			AllowsSale = vm.AllowsSale,
			Type = vm.Type,
			HasVariants = vm.HasVariants,
			BasePrice = vm.BasePrice,
			ConversionValue = vm.ConversionValue,
			Description = vm.Description,
			ModifiedDate = vm.ModifiedDate,
			IsActive = vm.IsActive,
			IsLotSerialControl = vm.IsLotSerialControl,
			IsBatchExpireControl = vm.IsBatchExpireControl,
			Images = string.Join(",", this.Images ?? Array.Empty<string>()),
			Path = vm.Path
		};
	}
}


