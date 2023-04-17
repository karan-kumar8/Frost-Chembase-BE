using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frost_Chembase_BE_Entities_Stock.Products
{
	public class Master
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int Year { get; set; }
		[Required]
		public Manufacturer Manufacturer { get; set; }
		[Required]
		public MainCategory MainCategory { get; set; }
		[Required]
		public Product Product { get; set; }
		[Required]
		public ProductType ProductType { get; set;}
		[Required]
		public string ShowProdType { get; set;}
		[Required]
		public Province Province { get; set; }
		[Required]
		public string Unit { get; set; }
		[Required]
		public double Existing_Capacity { get; set; }
		[Required]
		public double Upcoming_Capacity { get; set;}
		[Required]
		public int Status { get; set; }
		[Required]
		public int Created_By { get; set; }
		[Required]
		public int Updated_By { get; set; }
		[Required]
		public DateTime Created_At { get; set; }
		[Required]
		public DateTime Updated_At { get; set; }
	}
}
