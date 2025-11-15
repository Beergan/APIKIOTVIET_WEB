using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class KiotProduct
{
	public int Total { get; set; }
	public int PageSize { get; set; }
	public List<VM_Product> Data { get; set; }
}