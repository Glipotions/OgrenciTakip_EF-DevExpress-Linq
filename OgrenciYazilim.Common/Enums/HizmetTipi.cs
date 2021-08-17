using System;
using System.ComponentModel;

namespace OgrenciYazilim.Common.Enums
{
	public enum HizmetTipi : Byte
	{
		[Description("Eğitim")]
		Egitim = 1,
		[Description("Yemek")]
		Yemek = 2,
		[Description("Servis")]
		Servis = 3,
		[Description("Pansiyon")]
		Pansiyon = 4,
		[Description("Diğer")]
		Diger = 5
	}
}
