using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
	public enum KayitDurumu : byte
	{
		[Description("Ön Kayıt")]
		Onkayit = 1,

		[Description("Kesin Kayıt")]
		KesinKayit = 2,

		[Description("Kayıtsız")]
		Kayitsiz = 3
	}
}