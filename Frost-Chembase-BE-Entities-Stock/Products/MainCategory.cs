using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frost_Chembase_BE_Entities_Stock.Products
{
	public class MainCategory
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public int SortOrder { get; set; }
		[Required]
		public int Status { get; set; }
		[Required]
		public int Created_By { get; set; }
		[Required]
		public int Updated_By { get;set; }
		[Required]
		public DateTime Created_At { get; set; }
		[Required]
		public DateTime Updated_At { get; set; }
		[Required]
		public Category Category { get; set; }
	}
}
