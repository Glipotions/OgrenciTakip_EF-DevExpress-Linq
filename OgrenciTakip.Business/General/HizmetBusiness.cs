using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class HizmetBusiness : BaseGenelBusiness<Hizmet>, IBaseCommonBusiness
	{
		public HizmetBusiness() : base(KartTuru.Hizmet)
		{
		}

		public HizmetBusiness(Control control) : base(control, KartTuru.Hizmet)
		{
		}

		public override BaseEntity Single(Expression<Func<Hizmet, bool>> filter)
		{
			return BaseSingle(filter, x => new HizmetS
			{
				Id = x.Id,
				Kod = x.Kod,
				HizmetAdi = x.HizmetAdi,
				HizmetTuruId = x.HizmetTuruId,
				HizmetTuruAdi = x.HizmetTuru.HizmetTuruAdi,
				BaslamaTarihi = x.BaslamaTarihi,
				BitisTarihi = x.BitisTarihi,
				Ucret = x.Ucret,
				SubeId = x.SubeId,
				DonemId = x.DonemId,
				Aciklama = x.Aciklama,
				Durum = x.Durum
			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Hizmet, bool>> filter)
		{
			return BaseList(filter, x => new HizmetL
			{
				Id = x.Id,
				Kod = x.Kod,
				HizmetAdi = x.HizmetAdi,
				HizmetTuruId = x.HizmetTuruId,
				HizmetTuruAdi = x.HizmetTuru.HizmetTuruAdi,
				HizmetTipi = x.HizmetTuru.HizmetTipi,
				BaslamaTarihi = x.BaslamaTarihi,
				BitisTarihi = x.BitisTarihi,
				Ucret = x.Ucret,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();
		}
	}
}