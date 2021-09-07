using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
	public enum KayitSekli : byte
	{
		[Description("Yeni Kayıt")]
		YeniKayit = 1,

		[Description("Kayıt Yenileme")]
		KayitYenileme = 2,

		[Description("Nakil Kayıt")]
		NakilKayit = 3
	}
}