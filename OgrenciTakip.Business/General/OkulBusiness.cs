using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Dto;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class OkulBusiness : BaseGenelBusiness<Okul>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public OkulBusiness() : base(KartTuru.Okul) { }
		public OkulBusiness(Control ctrl) : base(ctrl, KartTuru.Okul) { }

		public override BaseEntity Single(Expression<Func<Okul, bool>> filter)
		{
			return BaseSingle(filter, x => new OkulS
			{
				Id = x.Id,
				Kod = x.Kod,
				OkulAdi = x.OkulAdi,
				IlId = x.IlId,
				IlAdi = x.Il.IlAdi,
				IlceId = x.IlceId,
				IlceAdi = x.Ilce.IlceAdi,
				Aciklama = x.Aciklama,
				Durum = x.Durum

			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Okul, bool>> filter)
		{
			return BaseList(filter, x => new OkulL
			{
				Id = x.Id,
				Kod = x.Kod,
				OkulAdi = x.OkulAdi,
				IlAdi = x.Il.IlAdi,
				IlceAdi = x.Ilce.IlceAdi,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();

		}
	}
}