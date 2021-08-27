using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciYazilim.Model.Entities
{
	public class KardesBilgileri : BaseHareketEntity
	{
		public long TahakkukId { get; set; }
		public long KardesTahakkukId { get; set; }

		//vt ilişki
		public Tahakkuk KardesTahakkuk { get; set; }
	}
}