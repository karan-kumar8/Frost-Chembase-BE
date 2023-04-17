using Frost_Chembase_BE_DTOs_Stock.Products;

namespace Frost_Chembase_BE_Business_Stock.Products.Interfaces
{
	public interface IProductService
	{
		ProductDto GetProductByName(string name);
	}
}