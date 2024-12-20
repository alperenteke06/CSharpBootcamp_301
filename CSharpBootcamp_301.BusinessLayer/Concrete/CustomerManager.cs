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
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public void TDelete(Customer entity)
		{
			_customerDal.Delete(entity);
		}

		public List<Customer> TGetAll()
		{
			return _customerDal.GetAll();
		}

		public Customer TGetById(int id)
		{
			return _customerDal.GetById(id);
		}

		public void TInsert(Customer entity)
		{
			//Validation
			if (entity != null && entity.CustomerName.Length >= 3 && entity.CustomerSurname != null &&
				entity.CustomerCity != null && entity.CustomerSurname.Length <= 30)
			{
				_customerDal.Insert(entity);
			}
			else
			{
				//Error Message
			}
		}

		public void TUpdate(Customer entity)
		{
			_customerDal.Update(entity);
		}
	}
}
