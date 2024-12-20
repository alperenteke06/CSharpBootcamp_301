using CSharpBootcamp_301.DataAccessLayer.Abstract;
using CSharpBootcamp_301.DataAccessLayer.Repositories;
using CSharpBootcamp_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp_301.DataAccessLayer.EntityFramework
{
	public class EfAdminDal : GenericRepository<Admin>, IAdminDal
	{
	}
}
