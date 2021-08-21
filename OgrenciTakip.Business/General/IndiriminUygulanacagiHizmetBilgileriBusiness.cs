using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Data.Context;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Business.General
{
	public class IndiriminUygulanacagiHizmetBilgileriBusiness : BaseHareketBusiness<IndiriminUygulanacagiHizmetBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<IndiriminUygulanacagiHizmetBilgileri>
	{
		public IEnumerable<BaseHareketEntity> List(Expression<Func<IndiriminUygulanacagiHizmetBilgileri, bool>> filter)
		{
			return List(filter, x => new IndiriminUygulanacagiHizmetBilgileriL
			{
				Id = x.Id,
				IndirimId = x.IndirimId,
				HizmetId = x.HizmetId,
				HizmetAdi = x.Hizmet.HizmetAdi,
				IndirimTutari = x.IndirimTutari,
				IndirimOrani = x.IndirimOrani,
				SubeId = x.SubeId,
				DonemId = x.DonemId
			}).ToList();
		}
	}
}