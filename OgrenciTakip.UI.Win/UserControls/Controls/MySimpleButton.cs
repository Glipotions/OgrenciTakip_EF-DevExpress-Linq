using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MySimpleButton : SimpleButton, IStatusBarAciklama
	{
		[ToolboxItem(true)]
		public MySimpleButton()
		{
			Appearance.ForeColor = Color.Maroon;
		}
		public string StatusBarAciklama { get; set; }
	}
}
