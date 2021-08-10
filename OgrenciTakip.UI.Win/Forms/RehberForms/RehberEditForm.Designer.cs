
namespace OgrenciTakip.UI.Win.Forms.RehberForms
{
	partial class RehberEditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
			this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.txtKod = new OgrenciTakip.UI.Win.UserControls.Controls.MyCodeTextEdit();
			this.Kod = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtAdiSoyadi = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtTelefon1 = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtTelefon2 = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtAciklama = new OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tglDurum = new OgrenciTakip.UI.Win.UserControls.Controls.MyToggleSwitch();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
			this.myDataLayoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kod)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdiSoyadi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			// 
			// 
			// 
			this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.ribbonControl.SearchEditItem.EditWidth = 150;
			this.ribbonControl.SearchEditItem.Id = -5000;
			this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.ribbonControl.Size = new System.Drawing.Size(415, 109);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// myDataLayoutControl
			// 
			this.myDataLayoutControl.Controls.Add(this.tglDurum);
			this.myDataLayoutControl.Controls.Add(this.txtAciklama);
			this.myDataLayoutControl.Controls.Add(this.txtTelefon2);
			this.myDataLayoutControl.Controls.Add(this.txtTelefon1);
			this.myDataLayoutControl.Controls.Add(this.txtAdiSoyadi);
			this.myDataLayoutControl.Controls.Add(this.txtKod);
			this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
			this.myDataLayoutControl.Name = "myDataLayoutControl";
			this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
			this.myDataLayoutControl.Root = this.Root;
			this.myDataLayoutControl.Size = new System.Drawing.Size(415, 201);
			this.myDataLayoutControl.TabIndex = 0;
			this.myDataLayoutControl.Text = "myDataLayoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Kod,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
			this.Root.Name = "Root";
			columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
			columnDefinition1.Width = 200D;
			columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
			columnDefinition2.Width = 100D;
			columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
			columnDefinition3.Width = 99D;
			this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
			rowDefinition1.Height = 24D;
			rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
			rowDefinition2.Height = 24D;
			rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
			rowDefinition3.Height = 24D;
			rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
			rowDefinition4.Height = 24D;
			rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
			rowDefinition5.Height = 100D;
			rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
			this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
			this.Root.Size = new System.Drawing.Size(415, 201);
			this.Root.TextVisible = false;
			// 
			// txtKod
			// 
			this.txtKod.Location = new System.Drawing.Point(74, 12);
			this.txtKod.MenuManager = this.ribbonControl;
			this.txtKod.Name = "txtKod";
			this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.txtKod.Properties.Appearance.Options.UseBackColor = true;
			this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
			this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
			this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
			this.txtKod.Properties.MaxLength = 20;
			this.txtKod.Size = new System.Drawing.Size(134, 20);
			this.txtKod.StatusBarAciklama = "Kod Alanı..";
			this.txtKod.StyleController = this.myDataLayoutControl;
			this.txtKod.TabIndex = 5;
			// 
			// Kod
			// 
			this.Kod.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.Kod.AppearanceItemCaption.Options.UseForeColor = true;
			this.Kod.Control = this.txtKod;
			this.Kod.Location = new System.Drawing.Point(0, 0);
			this.Kod.Name = "Kod";
			this.Kod.Size = new System.Drawing.Size(200, 24);
			this.Kod.TextSize = new System.Drawing.Size(50, 13);
			// 
			// txtAdiSoyadi
			// 
			this.txtAdiSoyadi.Location = new System.Drawing.Point(74, 36);
			this.txtAdiSoyadi.MenuManager = this.ribbonControl;
			this.txtAdiSoyadi.Name = "txtAdiSoyadi";
			this.txtAdiSoyadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
			this.txtAdiSoyadi.Properties.AppearanceFocused.Options.UseBackColor = true;
			this.txtAdiSoyadi.Properties.MaxLength = 50;
			this.txtAdiSoyadi.Size = new System.Drawing.Size(329, 20);
			this.txtAdiSoyadi.StatusBarAciklama = null;
			this.txtAdiSoyadi.StyleController = this.myDataLayoutControl;
			this.txtAdiSoyadi.TabIndex = 0;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem2.Control = this.txtAdiSoyadi;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
			this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
			this.layoutControlItem2.Size = new System.Drawing.Size(395, 24);
			this.layoutControlItem2.Text = "Adı Soyadı";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
			// 
			// txtTelefon1
			// 
			this.txtTelefon1.Location = new System.Drawing.Point(74, 60);
			this.txtTelefon1.MenuManager = this.ribbonControl;
			this.txtTelefon1.Name = "txtTelefon1";
			this.txtTelefon1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
			this.txtTelefon1.Properties.AppearanceFocused.Options.UseBackColor = true;
			this.txtTelefon1.Properties.MaxLength = 50;
			this.txtTelefon1.Size = new System.Drawing.Size(329, 20);
			this.txtTelefon1.StatusBarAciklama = null;
			this.txtTelefon1.StyleController = this.myDataLayoutControl;
			this.txtTelefon1.TabIndex = 1;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem3.Control = this.txtTelefon1;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 3;
			this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
			this.layoutControlItem3.Size = new System.Drawing.Size(395, 24);
			this.layoutControlItem3.Text = "Telefon 1";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 13);
			// 
			// txtTelefon2
			// 
			this.txtTelefon2.Location = new System.Drawing.Point(74, 84);
			this.txtTelefon2.MenuManager = this.ribbonControl;
			this.txtTelefon2.Name = "txtTelefon2";
			this.txtTelefon2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
			this.txtTelefon2.Properties.AppearanceFocused.Options.UseBackColor = true;
			this.txtTelefon2.Properties.MaxLength = 50;
			this.txtTelefon2.Size = new System.Drawing.Size(329, 20);
			this.txtTelefon2.StatusBarAciklama = null;
			this.txtTelefon2.StyleController = this.myDataLayoutControl;
			this.txtTelefon2.TabIndex = 2;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem4.Control = this.txtTelefon2;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
			this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
			this.layoutControlItem4.Size = new System.Drawing.Size(395, 24);
			this.layoutControlItem4.Text = "Telefon 2";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 13);
			// 
			// txtAciklama
			// 
			this.txtAciklama.EnterMoveNextControl = true;
			this.txtAciklama.Location = new System.Drawing.Point(74, 108);
			this.txtAciklama.MenuManager = this.ribbonControl;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
			this.txtAciklama.Properties.Appearance.Options.UseBackColor = true;
			this.txtAciklama.Properties.MaxLength = 500;
			this.txtAciklama.Size = new System.Drawing.Size(329, 81);
			this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
			this.txtAciklama.StyleController = this.myDataLayoutControl;
			this.txtAciklama.TabIndex = 3;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem5.Control = this.txtAciklama;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
			this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
			this.layoutControlItem5.Size = new System.Drawing.Size(395, 85);
			this.layoutControlItem5.Text = "Açıklama";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(50, 13);
			// 
			// tglDurum
			// 
			this.tglDurum.EnterMoveNextControl = true;
			this.tglDurum.Location = new System.Drawing.Point(308, 12);
			this.tglDurum.MenuManager = this.ribbonControl;
			this.tglDurum.Name = "tglDurum";
			this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
			this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
			this.tglDurum.Properties.AutoHeight = false;
			this.tglDurum.Properties.AutoWidth = true;
			this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.tglDurum.Properties.OffText = "Pasif";
			this.tglDurum.Properties.OnText = "Aktif";
			this.tglDurum.Size = new System.Drawing.Size(77, 20);
			this.tglDurum.StatusBarAciklama = "Kartın Kullanım Durumunu Belirtiniz.";
			this.tglDurum.StyleController = this.myDataLayoutControl;
			this.tglDurum.TabIndex = 4;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem6.Control = this.tglDurum;
			this.layoutControlItem6.Location = new System.Drawing.Point(296, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
			this.layoutControlItem6.Size = new System.Drawing.Size(99, 24);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// RehberEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 334);
			this.Controls.Add(this.myDataLayoutControl);
			this.IconOptions.ShowIcon = false;
			this.MinimumSize = new System.Drawing.Size(390, 250);
			this.Name = "RehberEditForm";
			this.Text = "Rehber Kartı";
			this.Controls.SetChildIndex(this.ribbonControl, 0);
			this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
			this.myDataLayoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kod)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdiSoyadi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private UserControls.Controls.MyToggleSwitch tglDurum;
		private UserControls.Controls.MyMemoEdit txtAciklama;
		private UserControls.Controls.MyTextEdit txtTelefon2;
		private UserControls.Controls.MyTextEdit txtTelefon1;
		private UserControls.Controls.MyTextEdit txtAdiSoyadi;
		private UserControls.Controls.MyCodeTextEdit txtKod;
		private DevExpress.XtraLayout.LayoutControlItem Kod;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}