using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Dto
{
	[NotMapped]
	public class PromosyonBilgileriL : PromosyonBilgileri, IBaseHareketEntity
	{
		public string Kod { get; set; }
		public string PromosyonAdi { get; set; }

		public bool Insert { get; set; }
		public bool Update { get; set; }
		public bool Delete { get; set; }
	}
}