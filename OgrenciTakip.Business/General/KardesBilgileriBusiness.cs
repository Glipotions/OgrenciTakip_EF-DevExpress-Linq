using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
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
	public class KardesBilgileriBusiness : BaseHareketBusiness<KardesBilgileri, OgrenciTakipContext>, IBaseHareketSelectBusiness<KardesBilgileri>
	{
		public IEnumerable<BaseHareketEntity> List(Expression<Func<KardesBilgileri, bool>> filter)
		{
			return List(filter, x => new KardesBilgileriL
			{
				Id = x.Id,
				TahakkukId = x.TahakkukId,
				KardesTahakkukId = x.KardesTahakkukId,
				Adi = x.KardesTahakkuk.Ogrenci.Adi,
				Soyadi = x.KardesTahakkuk.Ogrenci.Soyadi,
				SinifAdi = x.KardesTahakkuk.Sinif.SinifAdi,
				KayitSekli = x.KardesTahakkuk.KayitSekli,
				KayitDurumu = x.KardesTahakkuk.KayitDurumu,
				IptalDurumu = x.KardesTahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
				SubeId = x.KardesTahakkuk.SubeId,
				SubeAdi = x.KardesTahakkuk.Sube.SubeAdi,
				DonemId = x.KardesTahakkuk.DonemId
			}).ToList();
		}
	}
}