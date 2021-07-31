using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYazilim.Model.Attributes
{
	public class ZorunluAlan:Attribute
	{
		public string Description { get; }
		public string ControlName { get; }

		/// <summary>
		/// Validation işlemleri sırasında Zorunlu olan alanları işaretlemek için kullanılacak
		/// </summary>
		/// <param name="description"> Uyarı Mesajında Gösterilecek Olan Açıklama Yapacak </param>
		/// <param name="controlName"> Uyarı Mesajı Sonrası Focuslanacak Control Adı</param>
		public ZorunluAlan(string description, string controlName)
		{
			Description = description;
			ControlName = controlName;
		}
	}
}
