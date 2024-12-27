using CSharpBootcamp_301.DataAccessLayer.Abstract;
using CSharpBootcamp_301.DataAccessLayer.Context;
using CSharpBootcamp_301.DataAccessLayer.Repositories;
using CSharpBootcamp_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp_301.DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		private readonly BootcampContext _db;

		public EfProductDal()
		{
			_db = new BootcampContext();
		}

		public List<object> GetProductsWithCategoryName()
		{
			var values = _db.Products
				.Select(x=> new
				{
					ProductId = x.ProductId,
					ProductName = x.ProductName,
					ProductStock = x.ProductStock,
					ProductDescription = x.ProductDescription,
					CategoryName = x.Category.CategoryName,
				}).ToList();

			return values.Cast<Object>().ToList();
		}
	}
}
