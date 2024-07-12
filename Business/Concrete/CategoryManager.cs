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
	internal class CategoryManager : GenericRepositoryBus<Category>,ICategoryService
	{
		public CategoryManager(ICategoryDal categoryDal) :base(categoryDal)
		{
		}
	}
}
