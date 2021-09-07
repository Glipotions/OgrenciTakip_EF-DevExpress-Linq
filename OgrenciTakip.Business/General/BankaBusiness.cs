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
	public class BankaBusiness : BaseGenelBusiness<Banka>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public BankaBusiness() : base(KartTuru.Banka)
		{
		}

		public BankaBusiness(Control control) : base(control, KartTuru.Banka)
		{
		}

		public override BaseEntity Single(Expression<Func<Banka, bool>> filter)
		{
			return BaseSingle(filter, x => new BankaS
			{
				Id = x.Id,
				Kod = x.Kod,
				BankaAdi = x.BankaAdi,
				OzelKod1Id = x.OzelKod1Id,
				OzelKod1Adi = x.OzelKod1.OzelKodAdi,
				OzelKod2Id = x.OzelKod2Id,
				OzelKod2Adi = x.OzelKod2.OzelKodAdi,
				Aciklama = x.Aciklama,
				Durum = x.Durum
			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Banka, bool>> filter)
		{
			return BaseList(filter, x => new BankaL
			{
				Id = x.Id,
				Kod = x.Kod,
				BankaAdi = x.BankaAdi,
				OzelKod1Adi = x.OzelKod1.OzelKodAdi,
				OzelKod2Adi = x.OzelKod2.OzelKodAdi,
				Aciklama = x.Aciklama
			}).OrderBy(x => x.Kod).ToList();
		}
	}
}