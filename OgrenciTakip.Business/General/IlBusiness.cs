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
	public class IlBusiness : BaseBusiness<Il, OgrenciTakipContext>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public IlBusiness() { }
		public IlBusiness(Control ctrl) : base(ctrl) { }

		public BaseEntity Single(Expression<Func<Il, bool>> filter)
		{
			return BaseSingle(filter, x => x);
		}

		public IEnumerable<BaseEntity> List(Expression<Func<Il, bool>> filter)
		{
			return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
		}
		public bool Insert(BaseEntity entity)
		{
			return BaseInsert(entity, x => x.Kod == entity.Kod);
		}

		public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
		{
			return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
		}

		public bool Delete(BaseEntity entity)
		{
			return BaseDelete(entity, KartTuru.Il);
		}

		public string YeniKodVer()
		{
			return BaseYeniKodVer(KartTuru.Il, x => x.Kod);
		}
	}
}
