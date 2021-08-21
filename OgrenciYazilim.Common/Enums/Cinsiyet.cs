using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
	public enum Cinsiyet : byte
	{
		[Description("Erkek")]
		Erkek = 1,

		[Description("Kadın")]
		Kadin = 2
	}
}