using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
	public class Rehber : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("Rehber Adı Soyadı", "txtAdiSoyadi")]
		public string AdiSoyadi { get; set; }
		[StringLength(17)]
		public string Telefon1 { get; set; }
		[StringLength(17)]
		public string Telefon2 { get; set; }

		[StringLength(500)]
		public string Aciklama { get; set; }

	}
}