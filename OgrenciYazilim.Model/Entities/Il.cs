using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Entities
{
	public class Il : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }

		[Required, StringLength(50),ZorunluAlan("İl Adı", "txtIlAdi")]
		public string IlAdi { get; set; }

		[StringLength(500)]
		public string Aciklama { get; set; }
		//public ICollection<Ilce> Ilce { get; set; }

	}
}
