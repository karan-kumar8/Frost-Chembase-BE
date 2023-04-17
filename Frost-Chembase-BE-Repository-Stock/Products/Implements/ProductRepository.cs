using Frost_Chembase_BE_Context_Stock.Context;
using Frost_Chembase_BE_Entities_Stock.Products;
using Frost_Chembase_BE_Repository_Stock.Products.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Frost_Chembase_BE_Repository_Stock.Products.Implements
{
	public class ProductRepository : IRepository<Product>
	{
		private readonly AppDbContext _dbContext;

		public ProductRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Add(Product entity)
		{
			_dbContext.Products.Add(entity);
			_dbContext.SaveChanges();
		}

		public void Delete(Guid id)
		{
			var product = _dbContext.Products.Find(id);
        if (product != null)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }
		}

		public IEnumerable<Product> GetAll()
		{
			return _dbContext.Products.ToList();
		}

		public Product GetById(Guid id)
		{
			return _dbContext.Products.Find(id);
		}

		public Product GetByName(string name)
		{
			return _dbContext.Products.FirstOrDefault(p => p.Name.Contains(name));
		}

		public void Update(Product entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}
	}
}