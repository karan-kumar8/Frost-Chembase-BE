using Frost_Chembase_BE_Entities_Stock.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frost_Chembase_BE_Repository_Stock.Products.Interfaces
{
	public interface IRepository<T> where T : class
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(Guid id);
		T GetById(Guid id);
		IEnumerable<T> GetAll();
		T GetByName(string name);
	}
}
