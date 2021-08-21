using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
	public class Hizmet : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = false)]
		public override string Kod { get; set; }

		[Required, StringLength(50), ZorunluAlan("Hizmet Adı", "txtHizmetAdi")]
		public string HizmetAdi { get; set; }

		[ZorunluAlan("Hizmet Türü Adı", "txtHizmetTuru")]
		public long HizmetTuruId { get; set; }

		[Column(TypeName = "date")]
		public DateTime BaslamaTarihi { get; set; }

		[Column(TypeName = "date")]
		public DateTime BitisTarihi { get; set; }

		[Column(TypeName = "money")]
		public decimal Ucret { get; set; }

		public string Aciklama { get; set; }

		public long SubeId { get; set; }

		public long DonemId { get; set; }

		//vt ilişki
		public HizmetTuru HizmetTuru { get; set; }

		public Sube Sube { get; set; }
		public Donem Donem { get; set; }
	}
}