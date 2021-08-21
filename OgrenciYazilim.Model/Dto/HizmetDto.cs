using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class HizmetS : Hizmet
	{
		public string HizmetTuruAdi { get; set; }
	}

	public class HizmetL : BaseEntity
	{
		public string HizmetAdi { get; set; }
		public long HizmetTuruId { get; set; }
		public string HizmetTuruAdi { get; set; }
		public HizmetTipi HizmetTipi { get; set; }
		public DateTime BaslamaTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }
		public decimal Ucret { get; set; }
		public string Aciklama { get; set; }
	}
}