﻿using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYazilim.Model.Entities
{
	public class Kontenjan : BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("Kontenjan Adı", "txtKontenjanAdi")]
		public string KontenjanAdi { get; set; }
		[StringLength(500)]
		public string Aciklama { get; set; }

	}
}