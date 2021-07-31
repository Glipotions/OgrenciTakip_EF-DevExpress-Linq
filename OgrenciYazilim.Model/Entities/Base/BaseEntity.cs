using OgrenciYazilim.Model.Attributes;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYazilim.Model.Entities.Base
{
	public class BaseEntity : IBaseEntity
	{
		[Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long Id { get; set; }
		[Column(Order = 1), Required, StringLength(20), Kod("Kod","txtKod"), ZorunluAlan("Kod","txtKod")]
		public virtual string Kod { get; set; }

	}
}
