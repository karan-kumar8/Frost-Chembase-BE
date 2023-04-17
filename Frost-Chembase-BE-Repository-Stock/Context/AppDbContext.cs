using Frost_Chembase_BE_Entities_Stock.Products;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Frost_Chembase_BE_Context_Stock.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Manufacturer> Manufacturers { get; set; }
		public DbSet<MainCategory> MainCategories { get; set; }
		public DbSet<Province> Provinces { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Master> Masters { get; set; }
		
	}

}