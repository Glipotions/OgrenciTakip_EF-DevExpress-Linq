﻿using System.ComponentModel;

namespace OgrenciYazilim.Common.Enums
{
	public enum KartTuru : byte
	{
		[Description("Okul Kartı")]
		Okul = 1,
		[Description("İl Kartı")]
		Il = 2,
		[Description("İlçe Kartı")]
		Ilce = 3,
		[Description("Filtre Kartı")]
		Filtre = 4,
		[Description("Aile Bilgi Kartı")]
		AileBilgi = 5,
		[Description("İptal Nedeni Kartı")]
		IptalNedeni = 6,
		[Description("Yabancı Dil Kartı")]
		YabanciDil = 7,
		[Description("Tesvik Kartı")]
		Tesvik = 8,
		[Description("Kontenjan Kartı")]
		Kontenjan = 9,
		[Description("Rehber Kartı")]
		Rehber = 10,
		[Description("Sınıf Grup Kartı")]
		SinifGrup = 11,
		[Description("Meslek Kartı")]
		Meslek = 12,
		[Description("Yakınlık Kartı")]
		Yakinlik = 13,
		[Description("İşyeri Kartı")]
		Isyeri = 14,
		[Description("Görev Kartı")]
		Gorev = 15,
		[Description("İndirim Türü Kartı")]
		IndirimTuru = 16,
		[Description("Evrak Kartı")]
		Evrak = 17,
		[Description("Promosyon Kartı")]
		Promosyon = 18,
		[Description("Servis Kartı")]
		Servis = 19,
		[Description("Sınıf Kartı")]
		Sinif = 20,
		[Description("Hizmet Türü Kartı")]
		HizmetTuru = 21,
		[Description("Hizmet Kartı")]
		Hizmet = 22,
		[Description("Özel Kod Kartı")]
		OzelKod = 23,
		[Description("Kasa Kartı")]
		Kasa = 24

	}
}
