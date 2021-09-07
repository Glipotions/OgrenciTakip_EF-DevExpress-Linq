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
	public class MakbuzBusiness : BaseGenelBusiness<Makbuz>, IBaseCommonBusiness
	{
		public MakbuzBusiness() : base(KartTuru.Makbuz)
		{
		}

		public MakbuzBusiness(Control control) : base(control, KartTuru.Makbuz)
		{
		}

		public override BaseEntity Single(Expression<Func<Makbuz, bool>> filter)
		{
			return BaseSingle(filter, x => new MakbuzS
			{
				Id = x.Id,
				Kod = x.Kod,
				Tarih = x.Tarih,
				MakbuzTuru = x.MakbuzTuru,
				MakbuzHesapTuru = x.MakbuzHesapTuru,
				AvukatHesapId = x.AvukatHesapId,
				BankaHesapId = x.BankaHesapId,
				CariHesapId = x.CariHesapId,
				KasaHesapId = x.KasaHesapId,
				SubeHesapId = x.SubeHesapId,
				HesapAdi = x.MakbuzHesapTuru == MakbuzHesapTuru.Avukat ? x.AvukatHesap.AdiSoyadi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Banka || x.MakbuzHesapTuru == MakbuzHesapTuru.Epos || x.MakbuzHesapTuru == MakbuzHesapTuru.Ots || x.MakbuzHesapTuru == MakbuzHesapTuru.Pos ? x.BankaHesap.HesapAdi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Cari || x.MakbuzHesapTuru == MakbuzHesapTuru.Mahsup ? x.CariHesap.CariAdi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Kasa ? x.KasaHesap.KasaAdi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Transfer ? x.SubeHesap.SubeAdi : null,
				HareketSayisi = x.HareketSayisi,
				MakbuzToplami = x.MakbuzToplami,
				DonemId = x.DonemId,
				SubeId = x.SubeId
			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Makbuz, bool>> filter)
		{
			return BaseList(filter, x => new MakbuzL
			{
				Id = x.Id,
				Kod = x.Kod,
				Tarih = x.Tarih,
				MakbuzTuru = x.MakbuzTuru,
				MakbuzHesapTuru = x.MakbuzHesapTuru,
				HesapAdi = x.MakbuzHesapTuru == MakbuzHesapTuru.Avukat ? x.AvukatHesap.AdiSoyadi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Banka || x.MakbuzHesapTuru == MakbuzHesapTuru.Epos || x.MakbuzHesapTuru == MakbuzHesapTuru.Ots || x.MakbuzHesapTuru == MakbuzHesapTuru.Pos ? x.BankaHesap.HesapAdi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Cari || x.MakbuzHesapTuru == MakbuzHesapTuru.Mahsup ? x.CariHesap.CariAdi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Kasa ? x.KasaHesap.KasaAdi :
							x.MakbuzHesapTuru == MakbuzHesapTuru.Transfer ? x.SubeHesap.SubeAdi : null,
				HareketSayisi = x.HareketSayisi,
				MakbuzToplami = x.MakbuzToplami,
			}).OrderBy(x => x.Kod).ToList();
		}

		public override bool Delete(BaseEntity entity)
		{
			return BaseDelete(entity, KartTuru.Makbuz, false);
		}
	}
}