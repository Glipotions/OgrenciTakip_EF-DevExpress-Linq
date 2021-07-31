using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	[ToolboxItem(true)]
	public class MyCheckEdit : CheckEdit, IStatusBarAciklama
	{
		public MyCheckEdit()
		{
			Properties.AppearanceFocused.BackColor = Color.Transparent;
		}
		public override bool EnterMoveNextControl { get; set; } = true;
		public string StatusBarAciklama { get; set; }
	}

}
