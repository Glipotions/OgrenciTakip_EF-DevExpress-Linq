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
	public class EvrakBilgileriBusiness : BaseHareketBusiness<EvrakBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<EvrakBilgileri>
	{
		public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
		{
			return List(filter, x => new EvrakBilgileriL
			{
				Id = x.Id,
				TahakkukId = x.TahakkukId,
				Kod = x.Evrak.Kod,
				EvrakId = x.EvrakId,
				EvrakAdi = x.Evrak.EvrakAdi
			}).ToList();
		}
	}
}