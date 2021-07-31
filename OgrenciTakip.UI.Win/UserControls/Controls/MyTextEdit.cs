using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	[ToolboxItem(true)]
	public class MyTextEdit : TextEdit, IStatusBarAciklama
	{

		public MyTextEdit()
		{
			Properties.AppearanceFocused.BackColor = Color.LightCyan;
			Properties.MaxLength = 50;
		}

		public string StatusBarAciklama { get; set; }
	}
}
