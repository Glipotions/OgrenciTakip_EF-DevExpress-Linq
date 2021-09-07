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
	public class PromosyonBilgileriBusiness : BaseHareketBusiness<PromosyonBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<PromosyonBilgileri>
	{
		public IEnumerable<BaseHareketEntity> List(Expression<Func<PromosyonBilgileri, bool>> filter)
		{
			return List(filter, x => new PromosyonBilgileriL
			{
				Id = x.Id,
				TahakkukId = x.TahakkukId,
				Kod = x.Promosyon.Kod,
				PromosyonId = x.PromosyonId,
				PromosyonAdi = x.Promosyon.PromosyonAdi
			}).ToList();
		}
	}
}