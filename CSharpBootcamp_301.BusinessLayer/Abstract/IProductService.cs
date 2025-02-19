﻿using CSharpBootcamp_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp_301.BusinessLayer.Abstract
{
	public interface IProductService : IGenericService<Product>
	{
		List<object> TGetProductsWithCategoryName();

	}
}
