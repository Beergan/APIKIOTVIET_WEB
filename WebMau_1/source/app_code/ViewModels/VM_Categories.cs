using System;

public class VM_Categories : VM_Base
{
	public long CategoryId { get; set; }
	public string CategoryName { get; set; }
	public string RetailerId { get; set; }
    public long ParentId { get; set; }
    public DateTime CreatedDate { get; set; }
}