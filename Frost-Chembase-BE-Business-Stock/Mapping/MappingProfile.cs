using AutoMapper;
using Frost_Chembase_BE_DTOs_Stock.Products;
using Frost_Chembase_BE_Entities_Stock.Products;

namespace Frost_Chembase_BE_Business_Stock.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			this.CreateMap<Product,ProductDto>().ReverseMap();
		}
	}
}
