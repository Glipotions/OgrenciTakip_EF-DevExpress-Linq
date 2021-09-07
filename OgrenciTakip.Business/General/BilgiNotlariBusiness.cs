using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Business.General
{
	public class BilgiNotlariBusiness : BaseHareketBusiness<BilgiNotlari, OgrenciTakipContext>, IBaseHareketSelectBusiness<BilgiNotlari>
	{
		public IEnumerable<BaseHareketEntity> List(Expression<Func<BilgiNotlari, bool>> filter)
		{
			return List(filter, x => new BilgiNotlariL
			{
				Id = x.Id,
				TahakkukId = x.TahakkukId,
				Tarih = x.Tarih,
				BilgiNotu = x.BilgiNotu
			}).ToList();
		}
	}
}