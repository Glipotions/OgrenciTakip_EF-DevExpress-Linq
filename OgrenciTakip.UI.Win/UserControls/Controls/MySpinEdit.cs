using DevExpress.Utils;
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MySpinEdit : SpinEdit, IStatusBarAciklama
	{
		[ToolboxItem(true)]
		public MySpinEdit()
		{
			Properties.Appearance.BackColor = Color.LightCyan;
			Properties.AllowNullInput = DefaultBoolean.False;
			Properties.EditMask = "d";
		}
		public override bool EnterMoveNextControl { get; set; } = true;
		public string StatusBarAciklama { get; set; }
	}
}
