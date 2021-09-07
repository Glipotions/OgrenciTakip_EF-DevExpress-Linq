﻿using OgrenciTakip.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Interfaces
{
	public interface IRepository<T> : IDisposable where T : class
	{
		void Insert(T entity);
		void Insert(IEnumerable<T> entities);
		void Update(T entity);
		void Update(T entity, IEnumerable<string> fields);
		void Update(IEnumerable<T> entities);
		void Delete(T entity);
		void Delete(IEnumerable<T> entities);
		TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
		IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
		int Count(Expression<Func<T, bool>> filter = null);
		string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);

	}
}
