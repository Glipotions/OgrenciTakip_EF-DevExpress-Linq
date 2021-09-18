﻿using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.Base
{
	public class BaseGenelBusiness<T> : BaseBusiness<T, OgrenciTakipContext> where T : BaseEntity
	{
		#region Variables
		private KartTuru _kartTuru;
		#endregion

		public BaseGenelBusiness() { }
		public BaseGenelBusiness(Control ctrl) : base(ctrl) { }
		public BaseGenelBusiness(KartTuru kartTuru) { _kartTuru = kartTuru; }
		public BaseGenelBusiness(Control ctrl, KartTuru kartTuru) : base(ctrl) { _kartTuru = kartTuru; }


		public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
		{
			return BaseSingle(filter, x => x);
		}

		public virtual IEnumerable<BaseEntity> List(Expression<Func<T, bool>> filter)
		{
			return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
		}

		public bool Insert(BaseEntity entity)
		{
			return BaseInsert(entity, x => x.Kod == entity.Kod);
		}

		public bool Insert(BaseEntity entity, Expression<Func<T, bool>> filter)
		{
			return BaseInsert(entity, filter);
		}

		public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
		{
			return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
		}

		public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
		{
			return BaseUpdate(oldEntity, currentEntity, filter);
		}

		public virtual bool Delete(BaseEntity entity)
		{
			return BaseDelete(entity, _kartTuru);
		}

		public string YeniKodVer()
		{
			return BaseYeniKodVer(_kartTuru, x => x.Kod);
		}


		public string YeniKodVer(Expression<Func<T, bool>> filter)
		{
			return BaseYeniKodVer(_kartTuru, x => x.Kod, filter);
		}

	}
}
