﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IGenericService<T>
	{
		void TInsert(T t);
		void TUpdate(T t);
		void TDelete(T t);
		List<T> TGetAll();
		T TGetById(int id);
	}
}
