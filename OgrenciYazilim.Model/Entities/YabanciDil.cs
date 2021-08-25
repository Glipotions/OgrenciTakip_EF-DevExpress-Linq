using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Entities
{
	public class YabanciDil : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("Dil Adı", "txtYabanciDilAdi")]
		public string DilAdi { get; set; }
		[StringLength(500)]
		public string Aciklama { get; set; }
	}
}
