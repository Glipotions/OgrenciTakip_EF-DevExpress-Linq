using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
	public enum MakbuzTuru : byte
	{
		[Description("Avukata Gönderme")]
		AvukataGonderme = 1,

		[Description("Avukat Yoluyla Tahsil Etme")]
		AvukatYoluylaTahsilEtme = 2,

		[Description("Bankaya Tahsile Gönderme")]
		BankayaTahsileGonderme = 3,

		[Description("Banka Yoluyla Tahsil Etme")]
		BankaYoluylaTahsilEtme = 4,

		[Description("Başka Şubeye Gönderme")]
		BaskaSubeyeGonderme = 5,

		[Description("Blokeye Alma")]
		BlokeyeAlma = 6,

		[Description("Bloke Çözümü")]
		BlokeCozumu = 7,

		[Description("Ciro Etme")]
		CiroEtme = 8,

		[Description("Gelen Belgeyi Onaylama")]
		GelenBelgeyiOnaylama = 9,

		[Description("Karşılıksız Olarak İşaretleme")]
		KarsiliksizOlarakIsaretleme = 10,

		[Description("Mahsup Etme")]
		MahsupEtme = 11,

		[Description("Müşteriye Geri İade")]
		MusteriyeGeriIade = 12,

		[Description("Ödenmiş Olarak İşaretleme")]
		OdenmisOlarakIsaretleme = 13,

		[Description("Portföye Geri İade")]
		PortfoyeGeriIade = 14,

		[Description("Portföye Karşılıksız İade")]
		PortfoyeKarsiliksizIade = 15,

		[Description("Tahsil Etme ( Banka )")]
		TahsilEtmeBanka = 16,

		[Description("Tahsil Etme ( Kasa )")]
		TahsilEtmeKasa = 17,

		[Description("Tahsili İmkansız Hale Gelme")]
		TahsiliImkansizHaleGelme = 18
	}
}