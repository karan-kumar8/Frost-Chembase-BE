using Frost_Chembase_BE_Entities_Stock.Products;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Frost_Chembase_BE_Context_Stock.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasKey(p => p.Id);
			modelBuilder.Entity<Product>()
				.Property(p => p.Name)
				.HasMaxLength(50);
			modelBuilder.Entity<Product>()
				.Property(p => p.Description)
				.HasMaxLength(200);
		}
	}

}