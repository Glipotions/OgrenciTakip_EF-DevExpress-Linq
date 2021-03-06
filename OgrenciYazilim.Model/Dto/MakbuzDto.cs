using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class MakbuzS : Makbuz
	{
		public string HesapAdi { get; set; }
	}

	public class MakbuzL : BaseEntity
	{
		public DateTime Tarih { get; set; }
		public MakbuzTuru MakbuzTuru { get; set; }
		public MakbuzHesapTuru MakbuzHesapTuru { get; set; }
		public decimal MakbuzToplami { get; set; }
		public int HareketSayisi { get; set; }
		public string HesapAdi { get; set; }
	}
}