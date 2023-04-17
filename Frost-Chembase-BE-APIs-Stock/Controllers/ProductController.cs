using Frost_Chembase_BE_Business_Stock.Products.Interfaces;
using Frost_Chembase_BE_Entities_Stock.Products;
using Frost_Chembase_BE_Repository_Stock.Products.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frost_Chembase_BE_APIs_Stock.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IRepository<Product> productService;
		private readonly ILogger<ProductController> logger;

		public ProductController(IRepository<Product> productService,ILogger<ProductController> logger)
		{
			this.productService = productService;
			this.logger = logger;
		}

		[HttpGet]
		[Route("Product:{Name}")]
		public IActionResult GetByName(string Name)
		{
			try
			{
				logger.LogInformation("Get Product by Name");
				var Product = productService.GetByName(Name);
				if (Product == null)
				{
					return NotFound();
				}
				return Ok(Product);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				logger.LogInformation("Get All Product");
				var Product = productService.GetAll();
				if (Product == null)
				{
					return NotFound();
				}
				return Ok(Product);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpPost]
		public IActionResult Post([FromBody] Product product)
		{
			try
			{
				logger.LogInformation("Add  Product");
				productService.Add(product);
				return Ok(product);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
