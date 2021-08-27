using OgrenciTakip.Model;
using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciYazilim.Model.Entities
{
	public class EvrakBilgileri : BaseHareketEntity
	{
		public long TahakkukId { get; set; }
		public long EvrakId { get; set; }

		public Evrak Evrak { get; set; }
	}
}