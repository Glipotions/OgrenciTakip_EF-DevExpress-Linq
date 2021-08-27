using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Dto
{
	[NotMapped]
	public class KardesBilgileriL : KardesBilgileri, IBaseHareketEntity
	{
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string SinifAdi { get; set; }
		public KayitSekli KayitSekli { get; set; }
		public KayitDurumu KayitDurumu { get; set; }
		public IptalDurumu IptalDurumu { get; set; }
		public long SubeId { get; set; }
		public long DonemId { get; set; }
		public string SubeAdi { get; set; }
		public bool Insert { get; set; }
		public bool Update { get; set; }
		public bool Delete { get; set; }
	}
}