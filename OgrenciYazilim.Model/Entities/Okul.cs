using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Entities
{
	public class Okul : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }

		[Required, StringLength(50), ZorunluAlan("Okul Adı", "txtOkulAdi")]
		public string OkulAdi { get; set; }

		[ZorunluAlan("İl Adi", "txtIl")]
		public long IlId { get; set; }

		[ZorunluAlan("İlçe Adi", "txtIlce")]
		public long IlceId { get; set; }

		[StringLength(500)]
		public string Aciklama { get; set; }
		public Il Il { get; set; }
		public Ilce Ilce { get; set; }


	}
}
