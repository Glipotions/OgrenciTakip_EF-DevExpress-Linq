using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IndirimBusiness : BaseGenelBusiness<Indirim>, IBaseCommonBusiness
	{
		public IndirimBusiness() : base(KartTuru.Indirim)
		{
		}

		public IndirimBusiness(Control control) : base(control, KartTuru.Indirim)
		{
		}

		public override BaseEntity Single(Expression<Func<Indirim, bool>> filter)
		{
			return BaseSingle(filter, x => new IndirimS
			{
				Id = x.Id,
				Kod = x.Kod,
				IndirimAdi = x.IndirimAdi,
				IndirimTuruId = x.IndirimTuruId,
				IndirimTuruAdi = x.IndirimTuru.IndirimTuruAdi,
				SubeId = x.SubeId,
				DonemId = x.DonemId,
				Aciklama = x.Aciklama,
				Durum = x.Durum
			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Indirim, bool>> filter)
		{
			return BaseList(filter, x => new IndirimL
			{
				Id = x.Id,
				Kod = x.Kod,
				IndirimAdi = x.IndirimAdi,
				IndirimTuruAdi = x.IndirimTuru.IndirimTuruAdi,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();
		}
	}
}