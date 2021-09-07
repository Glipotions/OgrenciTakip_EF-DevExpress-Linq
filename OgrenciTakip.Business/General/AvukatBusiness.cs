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
	public class AvukatBusiness : BaseGenelBusiness<Avukat>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public AvukatBusiness() : base(KartTuru.Avukat)
		{
		}

		public AvukatBusiness(Control control) : base(control, KartTuru.Avukat)
		{
		}

		public override BaseEntity Single(Expression<Func<Avukat, bool>> filter)
		{
			return BaseSingle(filter, x => new AvukatS
			{
				Id = x.Id,
				Kod = x.Kod,
				AdiSoyadi = x.AdiSoyadi,
				SozlesmeNo = x.SozlesmeNo,
				SozlesmeBaslamaTarihi = x.SozlesmeBaslamaTarihi,
				SozlesmeBitisTarihi = x.SozlesmeBitisTarihi,
				OzelKod1Id = x.OzelKod1Id,
				OzelKod1Adi = x.OzelKod1.OzelKodAdi,
				OzelKod2Id = x.OzelKod2Id,
				OzelKod2Adi = x.OzelKod2.OzelKodAdi,
				Aciklama = x.Aciklama,
				Durum = x.Durum
			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Avukat, bool>> filter)
		{
			return BaseList(filter, x => new AvukatL
			{
				Id = x.Id,
				Kod = x.Kod,
				AdiSoyadi = x.AdiSoyadi,
				SozlesmeNo = x.SozlesmeNo,
				SozlesmeBaslamaTarihi = x.SozlesmeBaslamaTarihi,
				SozlesmeBitisTarihi = x.SozlesmeBitisTarihi,
				OzelKod1Adi = x.OzelKod1.OzelKodAdi,
				OzelKod2Adi = x.OzelKod2.OzelKodAdi,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();
		}
	}
}