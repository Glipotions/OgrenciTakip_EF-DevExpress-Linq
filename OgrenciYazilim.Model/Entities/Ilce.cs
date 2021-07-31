using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYazilim.Model.Entities
{
	public class Ilce:BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = false)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("İlçe Adı", "txtIlceAdi")]
		public string IlceAdi { get; set; }
		public long IlId { get; set; }
		[StringLength(500)]
		public string Aciklama { get; set; }
		public Il Il { get; set; }


	}
}
