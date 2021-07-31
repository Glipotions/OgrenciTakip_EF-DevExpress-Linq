﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
	public class MyToggleSwitch : ToggleSwitch, IStatusBarAciklama
	{
		[ToolboxItem(true)]
		public MyToggleSwitch()
		{
			Name = "tglDurum";
			Properties.OffText = "Pasif";
			Properties.OnText = "Aktif";
			Properties.AutoHeight = false;
			Properties.AutoWidth = true;
			Properties.GlyphAlignment = HorzAlignment.Far;
			Properties.Appearance.ForeColor = Color.Maroon;
		}
		public override bool EnterMoveNextControl { get; set; } = true;
		public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Belirtiniz.";
	}
}
