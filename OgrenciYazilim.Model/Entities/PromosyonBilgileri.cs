using OgrenciYazilim.Model.Entities.Base;

namespace OgrenciYazilim.Model.Entities
{
	public class PromosyonBilgileri : BaseHareketEntity
	{
		public long TahakkukId { get; set; }
		public long PromosyonId { get; set; }

		public Promosyon Promosyon { get; set; }
	}
}