using System.ComponentModel;

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
		IndirimTuru = 16

	}
}
