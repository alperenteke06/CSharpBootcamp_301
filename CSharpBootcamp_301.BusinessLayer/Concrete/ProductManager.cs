using CSharpBootcamp_301.BusinessLayer.Abstract;
using CSharpBootcamp_301.DataAccessLayer.Abstract;
using CSharpBootcamp_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp_301.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void TDelete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public List<Product> TGetAll()
		{
			return _productDal.GetAll();
		}

		public Product TGetById(int id)
		{
			return _productDal.GetById(id);
		}

		public List<object> TGetProductsWithCategoryName()
		{
			return _productDal.GetProductsWithCategoryName();
		}

		public void TInsert(Product entity)
		{
			_productDal.Insert(entity);
		}

		public void TUpdate(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}
