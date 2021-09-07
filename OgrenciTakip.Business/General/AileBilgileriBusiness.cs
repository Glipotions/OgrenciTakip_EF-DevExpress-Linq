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
	public class AileBilgileriBusiness : BaseHareketBusiness<AileBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<AileBilgileri>
	{
		public IEnumerable<BaseHareketEntity> List(Expression<Func<AileBilgileri, bool>> filter)
		{
			return List(filter, x => new AileBilgileriL
			{
				Id = x.Id,
				TahakkukId = x.TahakkukId,
				AileBilgiId = x.AileBilgiId,
				BilgiAdi = x.AileBilgi.BilgiAdi,
				Aciklama = x.Aciklama
			}).ToList();
		}
	}
}