using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base.Interfaces;

namespace OgrenciTakip.Model.Entities
{
	public class DokumParametreleri : IBaseEntity
	{
		public string RaporBaslik { get; set; }
		public EvetHayir BaslikEkle { get; set; }
		public RaporuKagidaSigdirmaTuru RaporuKagidaSigdir { get; set; }
		public YazdirmaYonu YazdirmaYonu { get; set; }
		public EvetHayir YatayCizgileriGoster { get; set; }
		public EvetHayir DikeyCizgileriGoster { get; set; }
		public EvetHayir SutunBasliklariniGoster { get; set; }
		public string YaziciAdi { get; set; }
		public int YazdiralacakAdet { get; set; }
		public DokumSekli DokumSekli { get; set; }

	}
}
