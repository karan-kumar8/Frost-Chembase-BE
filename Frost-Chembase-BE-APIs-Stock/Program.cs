using Frost_Chembase_BE_Business_Stock.Mapping;
using Frost_Chembase_BE_Business_Stock.Products.Implements;
using Frost_Chembase_BE_Business_Stock.Products.Interfaces;
using Frost_Chembase_BE_Context_Stock.Context;
using Microsoft.EntityFrameworkCore;
using Frost_Chembase_BE_Repository_Stock.Products.Implements;
using Frost_Chembase_BE_Repository_Stock.Products.Interfaces;
using Serilog;
using Frost_Chembase_BE_Entities_Stock.Products;

namespace Frost_Chembase_BE_APIs_Stock
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var logger = new LoggerConfiguration()
				.ReadFrom.Configuration(builder.Configuration)
				.Enrich.FromLogContext()
				.CreateLogger();
			builder.Logging.ClearProviders();
			builder.Logging.AddSerilog(logger);
			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString"));
			});
			builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
			builder.Services.AddScoped<IProductService, ProductService>();

			builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
			builder.Services.AddScoped<AppDbContext>();
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}