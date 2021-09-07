﻿using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model
{
	public class Evrak : BaseEntityDurum
	{
		[Index("IX_kod", IsUnique = false)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("Evrak Adı", "txtEvrakAdi")]
		public string EvrakAdi { get; set; }
		[StringLength(500)]
		public string Aciklama { get; set; }

		public long SubeId { get; set; }
		public long DonemId { get; set; }

		public Sube Sube { get; set; }
		public Donem Donem { get; set; }

	}
}
