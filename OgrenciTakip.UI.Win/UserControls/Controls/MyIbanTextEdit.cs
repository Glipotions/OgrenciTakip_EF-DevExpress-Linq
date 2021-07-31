using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyIbanTextEdit : MyTextEdit
	{
		[ToolboxItem(true)]
		public MyIbanTextEdit()
		{
			Properties.Mask.MaskType = MaskType.Regular;
			Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
			Properties.Mask.AutoComplete = AutoCompleteType.None;
			StatusBarAciklama = "Iban Giriniz..";
		}
	}
}
