using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyEmailTextEdit : MyTextEdit
	{
		[ToolboxItem(true)]
		public MyEmailTextEdit()
		{
			Properties.Mask.MaskType = MaskType.RegEx;
			Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
			Properties.Mask.AutoComplete = AutoCompleteType.Strong;
			StatusBarAciklama = "Email Adresinizi Giriniz.";
		}
	}
}
