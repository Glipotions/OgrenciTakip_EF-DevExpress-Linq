using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyFilterControl : FilterControl, IStatusBarAciklama
	{
		[ToolboxItem(true)]
		public MyFilterControl()
		{
			ShowGroupCommandsIcon = true;
		}
		public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz..";
	}
}
