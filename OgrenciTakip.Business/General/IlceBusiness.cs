using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Data.Context;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IlceBusiness : BaseBusiness<Ilce, OgrenciTakipContext>, IBaseCommonBusiness
	{

		public IlceBusiness() { }
		public IlceBusiness(Control ctrl) : base(ctrl) { }

		public BaseEntity Single(Expression<Func<Ilce, bool>> filter)
		{
			//Burada hata olabilir.
			return BaseSingle(filter, x => x);
		}

		public IEnumerable<BaseEntity> List(Expression<Func<Ilce, bool>> filter)
		{
			return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
		}
		public bool Insert(BaseEntity entity, Expression<Func<Ilce, bool>> filter)
		{
			return BaseInsert(entity, filter);
		}

		public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Ilce, bool>> filter)
		{
			return BaseUpdate(oldEntity, currentEntity, filter);
		}

		public bool Delete(BaseEntity entity)
		{
			return BaseDelete(entity, KartTuru.Ilce);
		}

		public string YeniKodVer(Expression<Func<Ilce, bool>> filter)
		{
			return BaseYeniKodVer(KartTuru.Ilce, x => x.Kod, filter);
		}
	}
}
