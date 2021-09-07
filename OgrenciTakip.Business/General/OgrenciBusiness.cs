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
	public class OgrenciBusiness : BaseGenelBusiness<Ogrenci>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public OgrenciBusiness() : base(KartTuru.Ogrenci)
		{
		}

		public OgrenciBusiness(Control control) : base(control, KartTuru.Ogrenci)
		{
		}

		public override BaseEntity Single(Expression<Func<Ogrenci, bool>> filter)
		{
			return BaseSingle(filter, x => new OgrenciS
			{
				Id = x.Id,
				Kod = x.Kod,
				TcKimlikNo = x.TcKimlikNo,
				Adi = x.Adi,
				Soyadi = x.Soyadi,
				Cinsiyet = x.Cinsiyet,
				Telefon = x.Telefon,
				KanGrubu = x.KanGrubu,
				BabaAdi = x.BabaAdi,
				AnaAdi = x.AnaAdi,
				DogumYeri = x.DogumYeri,
				DogumTarihi = x.DogumTarihi,
				KimlikSeriNo = x.KimlikSeriNo,
				KimlikSiraNo = x.KimlikSiraNo,

				KimlikIlId = x.KimlikIlId,
				KimlikIlAdi = x.KimlikIl.IlAdi,
				KimlikIlceId = x.KimlikIlceId,
				KimlikIlceAdi = x.KimlikIlce.IlceAdi,

				KimlikMahalleKoy = x.KimlikMahalleKoy,
				KimlikCiltNo = x.KimlikCiltNo,
				KimlikAileSiraNo = x.KimlikAileSiraNo,
				KimlikBireySiraNo = x.KimlikBireySiraNo,
				KimlikVerildigiYer = x.KimlikVerildigiYer,
				KimlikVerilisNedeni = x.KimlikVerilisNedeni,
				KimlikKayitNo = x.KimlikKayitNo,
				KimlikVerilisTarihi = x.KimlikVerilisTarihi,
				Resim = x.Resim,

				OzelKod1Id = x.OzelKod1Id,
				OzelKod1Adi = x.OzelKod1.OzelKodAdi,

				OzelKod2Id = x.OzelKod2Id,
				OzelKod2Adi = x.OzelKod2.OzelKodAdi,

				OzelKod3Id = x.OzelKod3Id,
				OzelKod3Adi = x.OzelKod3.OzelKodAdi,

				OzelKod4Id = x.OzelKod4Id,
				OzelKod4Adi = x.OzelKod4.OzelKodAdi,

				OzelKod5Id = x.OzelKod5Id,
				OzelKod5Adi = x.OzelKod5.OzelKodAdi,

				Durum = x.Durum
			});
		}

		public override IEnumerable<BaseEntity> List(Expression<Func<Ogrenci, bool>> filter)
		{
			return BaseList(filter, x => new OgrenciL
			{
				Id = x.Id,
				Kod = x.Kod,
				TcKimlikNo = x.TcKimlikNo,
				Adi = x.Adi,
				Soyadi = x.Soyadi,
				Cinsiyet = x.Cinsiyet,
				Telefon = x.Telefon,
				KanGrubu = x.KanGrubu,
				BabaAdi = x.BabaAdi,
				AnaAdi = x.AnaAdi,
				DogumYeri = x.DogumYeri,
				DogumTarihi = x.DogumTarihi,
				KimlikSeriNo = x.KimlikSeriNo,
				KimlikSiraNo = x.KimlikSiraNo,

				KimlikIlAdi = x.KimlikIl.IlAdi,
				KimlikIlceAdi = x.KimlikIlce.IlceAdi,

				KimlikMahalleKoy = x.KimlikMahalleKoy,
				KimlikCiltNo = x.KimlikCiltNo,
				KimlikAileSiraNo = x.KimlikAileSiraNo,
				KimlikBireySiraNo = x.KimlikBireySiraNo,
				KimlikVerildigiYer = x.KimlikVerildigiYer,
				KimlikVerilisNedeni = x.KimlikVerilisNedeni,
				KimlikKayitNo = x.KimlikKayitNo,
				KimlikVerilisTarihi = x.KimlikVerilisTarihi,

				OzelKod1Adi = x.OzelKod1.OzelKodAdi,
				OzelKod2Adi = x.OzelKod2.OzelKodAdi,
				OzelKod3Adi = x.OzelKod3.OzelKodAdi,
				OzelKod4Adi = x.OzelKod4.OzelKodAdi,
				OzelKod5Adi = x.OzelKod5.OzelKodAdi,
			}).OrderBy(x => x.Kod).ToList();
		}
	}
}