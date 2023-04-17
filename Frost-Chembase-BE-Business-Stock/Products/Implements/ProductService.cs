using AutoMapper;
using Frost_Chembase_BE_Business_Stock.Products.Interfaces;
using Frost_Chembase_BE_DTOs_Stock.Products;
using Frost_Chembase_BE_Entities_Stock.Products;
using Frost_Chembase_BE_Repository_Stock.Products.Interfaces;

namespace Frost_Chembase_BE_Business_Stock.Products.Implements
{
	public class ProductService : IProductService
	{
		private readonly IRepository<Product> product;
		private readonly IMapper mapping;

		public ProductService(IRepository<Product> productRepo, IMapper mapping)
		{
			this.product = productRepo;
			this.mapping = mapping;
		}
		public ProductDto GetProductByName(string name)
		{
			var Products = product.GetByName(name);
			var ProductsDto = mapping.Map<ProductDto>(Products);
			return ProductsDto;

		}
	}
}
