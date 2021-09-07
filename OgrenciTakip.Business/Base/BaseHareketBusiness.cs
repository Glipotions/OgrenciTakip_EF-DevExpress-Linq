using DataAccess.Interfaces;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Business.Base
{
	public class BaseHareketBusiness<TEntity, TContext> : IBaseBusiness, IBaseHareketGenelBusiness
		where TEntity : BaseHareketEntity
		where TContext : DbContext
	{
		private IUnitOfWork<TEntity> _unitOfWork;

		protected TResult Single<TResult>(Expression<Func<TEntity, bool>> filter,
			Expression<Func<TEntity, TResult>> selector)
		{
			GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _unitOfWork);
			return _unitOfWork.Rep.Find(filter, selector);
		}

		protected IQueryable<TResult> List<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
		{
			GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _unitOfWork);
			return _unitOfWork.Rep.Select(filter, selector);
		}

		public virtual bool Insert(IList<BaseHareketEntity> entities)
		{
			GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _unitOfWork);
			_unitOfWork.Rep.Insert(entities.EntityListConvert<TEntity>());
			return _unitOfWork.Save();
		}

		public virtual bool InsertSingle(BaseHareketEntity entity)
		{
			GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _unitOfWork);
			_unitOfWork.Rep.Insert(entity.EntityConvert<TEntity>());
			return _unitOfWork.Save();
		}

		public virtual bool Update(IList<BaseHareketEntity> entities)
		{
			GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _unitOfWork);
			_unitOfWork.Rep.Update(entities.EntityListConvert<TEntity>());
			return _unitOfWork.Save();
		}

		public bool Delete(IList<BaseHareketEntity> entities)
		{
			GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref _unitOfWork);
			_unitOfWork.Rep.Delete(entities.EntityListConvert<TEntity>());
			return _unitOfWork.Save();
		}

		#region Dispose

		public void Dispose()
		{
			_unitOfWork?.Dispose();
		}

		#endregion Dispose
	}
}