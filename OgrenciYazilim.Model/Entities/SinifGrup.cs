using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Entities
{
	public class SinifGrup : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("Grup Adı", "txtGrupAdi")]
		public string GrupAdi { get; set; }
		[StringLength(500)]
		public string Aciklama { get; set; }

	}
}