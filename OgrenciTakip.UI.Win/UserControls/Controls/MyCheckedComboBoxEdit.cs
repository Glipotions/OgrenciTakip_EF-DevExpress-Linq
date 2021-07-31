﻿using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	[ToolboxItem(true)]
	public class MyCheckedComboBoxEdit : CheckedComboBoxEdit, IStatusBarKisayol
	{
		public MyCheckedComboBoxEdit()
		{
			Properties.AppearanceFocused.BackColor = Color.LightCyan;
		}

		public override bool EnterMoveNextControl { get; set; } = true;

		public string StatusBarAciklama { get; set; }
		public string StatusBarKisayol { get; set; } = "F4: ";
		public string StatusBarKisayolAciklama { get; set; }
	}
}
