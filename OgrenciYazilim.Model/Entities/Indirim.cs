using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
	public class Indirim : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = false)]
		public override string Kod { get; set; }

		[Required, StringLength(50), ZorunluAlan("İndirim Adı", "txtIndirimAdi")]
		public string IndirimAdi { get; set; }

		[ZorunluAlan("İndirim Türü Adı", "txtIndirimTuru")]
		public long IndirimTuruId { get; set; }

		public string Aciklama { get; set; }

		public long SubeId { get; set; }
		public long DonemId { get; set; }

		//vt ilişki
		public IndirimTuru IndirimTuru { get; set; }

		public Sube Sube { get; set; }
		public Donem Donem { get; set; }

		[InverseProperty("Indirim")]
		public ICollection<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri { get; set; }
	}
}