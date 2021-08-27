using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class SinavBilgileriL : SinavBilgileri, IBaseHareketEntity
	{
		public bool Insert { get; set; }
		public bool Update { get; set; }
		public bool Delete { get; set; }
	}
}