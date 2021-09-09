﻿using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base.Interfaces;

namespace OgrenciTakip.Model.Dto
{
	public class FaturaL
    {
        public long Id { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string OgrenciNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public decimal HizmetTutar { get; set; }
        public decimal HizmetIndirim { get; set; }
        public decimal HizmetNetTutar { get; set; }
        public decimal PlanTutar { get; set; }
        public decimal PlanIndirim { get; set; }
        public decimal PlanNetTutar { get; set; }

        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
    }

    [NotMapped]
    public class FaturaPlaniL : Fatura, IBaseHareketEntity
    {
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliTcKimlikNo { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string VeliEvAdres { get; set; }
        public long? VeliEvAdresIlId { get; set; }
        public string VeliEvAdresIlAdi { get; set; }
        public long? VeliEvAdresIlceId { get; set; }
        public string VeliEvAdresIlceAdi { get; set; }
        public string VeliIsAdres { get; set; }
        public long? VeliIsAdresIlId { get; set; }
        public string VeliIsAdresIlAdi { get; set; }
        public long? VeliIsAdresIlceId { get; set; }
        public string VeliIsAdresIlceAdi { get; set; }
        public string FaturaAdresIlAdi { get; set; }
        public string FaturaAdresIlceAdi { get; set; }

        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
        public string Sube { get; set; }
        public string Donem { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    public class FaturaAlinanHizmetlerL
    {
        public long HizmetId { get; set; }
        public long TahakkukId { get; set; }
        public string OkulNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string HizmetAdi { get; set; }
        public decimal BrutUcret { get; set; }
        public decimal Indirim { get; set; }
        public decimal NetUcret { get; set; }
    }

    [HighlightedClass]
    public class FaturaR : IBaseEntity
    {
        public long TahakkukId { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliTcKimlikNo { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string FaturaAdres { get; set; }
        public string FaturaAdresIlAdi { get; set; }
        public string FaturaAdresIlceAdi { get; set; }
        public int? FaturaNo { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? Indirim { get; set; }
        public decimal? NetTutar { get; set; }
        public KdvSekli? KdvSekli { get; set; }
        public byte? KdvOrani { get; set; }
        public decimal? KdvHaricTutar { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? ToplamTutar { get; set; }
        public decimal? PlanTutar { get; set; }
        public decimal? PlanIndirim { get; set; }
        public decimal? PlanNetTutar { get; set; }
        public string TutarYazi { get; set; }
        public string Aciklama { get; set; }
        public string Sube { get; set; }
        public string Donem { get; set; }
    }
}