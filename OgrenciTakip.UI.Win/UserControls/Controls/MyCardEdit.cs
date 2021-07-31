using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	[ToolboxItem(true)]
	public class MyCardEdit : MyTextEdit
	{
		public MyCardEdit()
		{
			Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
			Properties.Mask.MaskType = MaskType.Regular;
			Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
			Properties.Mask.AutoComplete = AutoCompleteType.None;
			StatusBarAciklama = "Kart No Giriniz..";

		}

	}
}
