using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
	public class SinavBilgileri : BaseHareketEntity
	{
		public long TahakkukId { get; set; }

		[Column(TypeName = "date")]
		public DateTime Tarih { get; set; }

		[Required, StringLength(30)]
		public string SinavAdi { get; set; }

		[Required, StringLength(20)]
		public string PuanTuru { get; set; }

		public double Puan { get; set; }
		public int Sira { get; set; }
		public double Yuzde { get; set; }
	}
}