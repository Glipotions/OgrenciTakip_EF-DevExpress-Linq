using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyPictureEdit : PictureEdit, IStatusBarKisayol
	{
		[ToolboxItem(true)]
		public MyPictureEdit()
		{
			Properties.Appearance.BackColor = Color.LightCyan;
			Properties.Appearance.ForeColor = Color.Maroon;
			Properties.NullText = "Resim Yok";
			Properties.SizeMode = PictureSizeMode.Stretch;
			Properties.ShowMenu = false;
		}
		public override bool EnterMoveNextControl { get; set; } = true;

		public string StatusBarAciklama { get; set; }
		public string StatusBarKisayol { get; set; } = "F4: ";
		public string StatusBarKisayolAciklama { get; set; }
	}
}
