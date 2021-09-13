using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
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
		Kasa = 24,
		[Description("Banka Kartı")]
		Banka = 25,
		[Description("Banka Şube Kartı")]
		BankaSube = 26,
		[Description("Avukat Kartı")]
		Avukat = 27,
		[Description("Cari Kartı")]
		Cari = 28,
		[Description("Ödeme Türü Kartı")]
		OdemeTuru = 29,
		[Description("Banka Hesap Kartı")]
		BankaHesap = 30,
		[Description("İletişim Kartı")]
		Iletisim = 31,
		[Description("Öğrenci Kartı")]
		Ogrenci = 32,
		[Description("İndirim Kartı")]
		Indirim = 33,
		[Description("Tahakkuk Kartı")]
		Tahakkuk = 34,
		[Description("Belge Hareketleri Kartı")]
		BelgeHareketleri = 35,
		[Description("Makbuz Kartı")]
		Makbuz = 36,
		[Description("Belge Seçim Kartı")]
		BelgeSecim = 37,
		[Description("Rapor Kartı")]
		Rapor = 38,
		[Description("Rapor Tasarım Kartı")]
		RaporTasarim = 39,
		[Description("Öğrenci Kartı Raporu")]
		OgrenciKartiRaporu = 40,
		[Description("Banka Ödeme Planı Raporu")]
		BankaOdemePlaniRaporu = 41,
		[Description("Meb Kayıt Sözlesmesi Raporu")]
		MebKayitSozlesmesiRaporu = 42,
		[Description("İndirim Dilekçesi Raporu")]
		IndirimDilekcesiRaporu = 43,
		[Description("Kayıt Sözleşmesi Raporu")]
		KayitSozlesmesiRaporu = 44,
		[Description("Kredi Kartlı Ödeme Talimatı Raporu")]
		KrediKartliOdemeTalimatiRaporu = 45,
		[Description("Ödeme Senedi Raporu")]
		OdemeSenediRaporu = 46,
		[Description("Kullanıcı Tanimlı Rapor")]
		KullaniciTanimliRapor = 47,
		[Description("Tahsilat Makbuzu")]
		TahsilatMakbuzu = 48,
		[Description("Şube Kartı")]
		Sube = 49,
		[Description("Teslimat Makbuzu")]
		TeslimatMakbuzu = 50,
		[Description("İade Makbuzu")]
		GeriIadeMakbuzu = 51,
		[Description("Genel Makbuzu")]
		GenelMakbuz = 52,
		[Description("Fatura Kartı")]
		Fatura = 53,
		[Description("Fatura Raporu")]
		FaturaRaporu = 54,
		[Description("Fatura Dönem İcmal Raporu")]
		FaturaDonemIcmalRaporu = 55,
		[Description("Fatura Ögrenci İcmal Raporu")]
		FaturaOgrenciIcmalRaporu = 56,
		[Description("Genel Amaçlı Rapor")]
		GenelAmacliRapor = 57
	}
}
