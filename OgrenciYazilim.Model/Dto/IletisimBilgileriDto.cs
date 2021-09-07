﻿using DevExpress.DataAccess.ObjectBinding;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
	[NotMapped]
	public class IletisimBilgileriL : IletisimBilgileri, IBaseHareketEntity
	{
		public string TcKimlikNo { get; set; }
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string EvTelefonu { get; set; }
		public string IsTel1 { get; set; }
		public string IsTel2 { get; set; }
		public string CepTel1 { get; set; }
		public string CepTel2 { get; set; }

		public string EvAdres { get; set; }
		public string EvAdresIlAdi { get; set; }
		public string EvAdresIlceAdi { get; set; }

		public string IsAdres { get; set; }
		public string IsAdresIlAdi { get; set; }
		public string IsAdresIlceAdi { get; set; }

		public string YakinlikAdi { get; set; }
		public string MeslekAdi { get; set; }
		public string IsyeriAdi { get; set; }
		public string GorevAdi { get; set; }

		public bool Insert { get; set; }
		public bool Update { get; set; }
		public bool Delete { get; set; }
	}

	[HighlightedClass]
	public class IletisimBilgileriR   //hareket olduğu için 1den çok kaydı tutar o yüzde interface den implemente etmiyoruz
	{
		public string TcKimlikNo { get; set; }
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string AdiSoyadi { get; set; }
		public string EvTelefonu { get; set; }
		public string IsTel1 { get; set; }
		public string IsTel2 { get; set; }
		public string CepTel1 { get; set; }
		public string CepTel2 { get; set; }

		public string EvAdres { get; set; }
		public string EvAdresIlAdi { get; set; }
		public string EvAdresIlceAdi { get; set; }
		public string EvAdresTam { get; set; }

		public string IsAdres { get; set; }
		public string IsAdresIlAdi { get; set; }
		public string IsAdresIlceAdi { get; set; }
		public string IsAdresTam { get; set; }

		public string YakinlikAdi { get; set; }
		public string MeslekAdi { get; set; }
		public string IsyeriAdi { get; set; }
		public string GorevAdi { get; set; }
	}
}