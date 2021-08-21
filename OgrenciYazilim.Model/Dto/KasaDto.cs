﻿using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class KasaS : Kasa
	{
		public string OzelKod1Adi { get; set; }
		public string OzelKod2Adi { get; set; }
	}

	public class KasaL : BaseEntity
	{
		public string KasaAdi { get; set; }
		public string OzelKod1Adi { get; set; }
		public string OzelKod2Adi { get; set; }
		public string Aciklama { get; set; }
	}
}