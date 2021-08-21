using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class BankaS : Banka
	{
		public string OzelKod1Adi { get; set; }
		public string OzelKod2Adi { get; set; }
	}

	public class BankaL : BaseEntity
	{
		public string BankaAdi { get; set; }
		public string OzelKod1Adi { get; set; }
		public string OzelKod2Adi { get; set; }
		public string Aciklama { get; set; }
	}
}