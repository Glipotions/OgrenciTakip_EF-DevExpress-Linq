using System;

namespace OgrenciTakip.Model.Attributes
{
	public class Kod : Attribute
	{
		public string Description { get; }
		public string ControlName { get; }

		/// <summary>
		/// Validation işlemleri sırasında Zorunlu olan alanları işaretlemek için kullanılacak
		/// </summary>
		/// <param name="description"> Uyarı Mesajında Gösterilecek Olan Açıklama Yapacak </param>
		/// <param name="controlName"> Uyarı Mesajı Sonrası Focuslanacak Control Adı</param>
		public Kod(string description, string controlName)
		{
			Description = description;
			ControlName = controlName;
		}
	}
}
