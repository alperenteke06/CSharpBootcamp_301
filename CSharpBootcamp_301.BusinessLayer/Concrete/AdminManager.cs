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
	public class AdminManager : IAdminService
	{
		private readonly IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public void TDelete(Admin entity)
		{
			_adminDal.Delete(entity);
		}

		public List<Admin> TGetAll()
		{
			return _adminDal.GetAll();
		}

		public Admin TGetById(int id)
		{
			return _adminDal.GetById(id);
		}

		public void TInsert(Admin entity)
		{
			_adminDal.Insert(entity);
		}

		public void TUpdate(Admin entity)
		{
			//Validations
			if (entity != null && entity.Password.Length >= 6 && entity.Username.Length >= 3 && entity.AdminId != 0)
			{
				_adminDal.Update(entity);
			}
		}
	}
}
