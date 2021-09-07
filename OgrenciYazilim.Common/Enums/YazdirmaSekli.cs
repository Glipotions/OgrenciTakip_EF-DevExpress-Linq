using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
	public enum YazdirmaSekli : byte
	{
		[Description("Tek Tek Yazdr")]
		TekTekYazdir = 1,
		[Description("Toplu Yazdır")]
		TopluYazdir = 2

	}
}
