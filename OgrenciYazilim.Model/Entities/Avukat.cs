using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
	public class Avukat : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }

		[Required, StringLength(50), ZorunluAlan("Adı Soyad", "txtAdiSoyadi")]
		public string AdiSoyadi { get; set; }

		[StringLength(20)]
		public string SozlesmeNo { get; set; }

		[Column(TypeName = "date")]
		public DateTime? SozlesmeBaslamaTarihi { get; set; }

		[Column(TypeName = "date")]
		public DateTime? SozlesmeBitisTarihi { get; set; }

		public long? OzelKod1Id { get; set; }
		public long? OzelKod2Id { get; set; }

		[StringLength(500)]
		public string Aciklama { get; set; }

		//vt ilişki
		public OzelKod OzelKod1 { get; set; }

		public OzelKod OzelKod2 { get; set; }
	}
}