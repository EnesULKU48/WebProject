using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business.Abstract;

using DataAccess.Abstract;

namespace Business.RepositoriesBus
{
	public class GenericRepositoryBus<T> : IGenericService<T> where T : class
	{
		IGenericDal<T> _genDal;
		public GenericRepositoryBus(IGenericDal<T> genericDal)
		{
			_genDal = genericDal;
		}

		public void TDelete(T t)
		{
			_genDal.Delete(t);
		}

		public List<T> TGetAll()
		{
			return _genDal.GetAll();
		}

		public T TGetById(int id)
		{
			return _genDal.GetById(id);
		}

		public void TInsert(T t)
		{
			_genDal.Insert(t);
		}

		public void TUpdate(T t)
		{
			_genDal.Update(t);
		}
	}
}
