using System;
using System.ComponentModel.DataAnnotations;

namespace nest.Models
{
	public class Product:BaseEntity
	{
		public string Name { get; set; }
		public int ReviewSum { get; set; }
		public int ReviewCount { get; set; }
		public decimal SellPrice { get; set; }
		[Range(0,100)]
		public decimal CostPrice { get; set; }
		public int DiscountPercent { get; set; }
		public string SubTitle { get; set; }
		public string SKU { get; set; }
		public int LifeDay { get; set; }
		public int StockCount { get; set; }
		public string Description { get; set; }

	}
}

