using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
	public class BankaSube : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = false)]
		public override string Kod { get; set; }

		[Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
		public string SubeAdi { get; set; }

		public long BankaId { get; set; }

		public string Aciklama { get; set; }

		//vt ilişki
		public Banka Banka { get; set; }
	}
}