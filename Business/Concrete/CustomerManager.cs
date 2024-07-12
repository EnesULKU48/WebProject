using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business.Abstract;
using Business.RepositoriesBus;

using DataAccess.Abstract;

using Entity.Concrete;

namespace Business.Concrete
{
	public class CustomerManager : GenericRepositoryBus<Customer>, ICustomerService
	{
		public CustomerManager(ICustomerDal customerDal) : base(customerDal)
		{
		}
	}
}
