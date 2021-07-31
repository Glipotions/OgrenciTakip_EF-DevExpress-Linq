using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyCodeTextEdit : MyTextEdit
	{
		[ToolboxItem(true)]
		public MyCodeTextEdit()
		{
			Properties.Appearance.BackColor = Color.PaleGoldenrod;
			Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
			Properties.MaxLength = 20;
			StatusBarAciklama = "Kod Alanı..";
		}

	}
}
