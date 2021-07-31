using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyPhoneTextEdit : MyTextEdit
	{
		[ToolboxItem(true)]
		public MyPhoneTextEdit()
		{
			Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
			Properties.Mask.MaskType = MaskType.Regular;
			Properties.Mask.EditMask = @"(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
			Properties.Mask.AutoComplete = AutoCompleteType.None;
			StatusBarAciklama = "Telefon No Giriniz.";
		}
	}
}
