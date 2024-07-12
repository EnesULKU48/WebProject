using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Abstract;
using DataAccess.Concrete;

namespace DataAccess.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		//Context c = new Context(); using kullanarak yaparsak bellek daha verimli kullanılmış olur yoksa manuel yapmak gerekti
		public void Delete(T t)
		{
			using var c = new Context();
			c.Remove(t);
			c.SaveChanges();
		}

		public List<T> GetAll()
		{
			using var c = new Context();
			return c.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			using var c = new Context();
			return c.Set<T>().Find(id);
		}

		public void Insert(T t)
		{
			using var c = new Context();
			c.Add(t);
			c.SaveChanges();
		}

		public void Update(T t)
		{
			using var c = new Context();
			c.Update(t);
			c.SaveChanges();
		}
	}
}
