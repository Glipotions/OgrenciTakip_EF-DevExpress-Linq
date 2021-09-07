using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
	public class KardesBilgileri : BaseHareketEntity
	{
		public long TahakkukId { get; set; }
		public long KardesTahakkukId { get; set; }

		//vt ilişki
		public Tahakkuk KardesTahakkuk { get; set; }
	}
}