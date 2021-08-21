using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class IndirimS : Indirim
	{
		public string IndirimTuruAdi { get; set; }
	}

	public class IndirimL : BaseEntity
	{
		public string IndirimAdi { get; set; }
		public long IndirimTuruId { get; set; }
		public string IndirimTuruAdi { get; set; }
		public string Aciklama { get; set; }
	}
}