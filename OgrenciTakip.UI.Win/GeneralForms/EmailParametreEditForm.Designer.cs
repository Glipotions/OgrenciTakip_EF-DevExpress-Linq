﻿
namespace OgrenciTakip.UI.Win.GeneralForms
{
	partial class EmailParametreEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition11 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition12 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtKod = new OgrenciTakip.UI.Win.UserControls.Controls.MyCodeTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtEmail = new OgrenciTakip.UI.Win.UserControls.Controls.MyEmailTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSifre = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPortNo = new OgrenciTakip.UI.Win.UserControls.Controls.MySpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtHost = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSslKullan = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSslKullan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(306, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtSslKullan);
            this.myDataLayoutControl1.Controls.Add(this.txtHost);
            this.myDataLayoutControl1.Controls.Add(this.txtPortNo);
            this.myDataLayoutControl1.Controls.Add(this.txtSifre);
            this.myDataLayoutControl1.Controls.Add(this.txtEmail);
            this.myDataLayoutControl1.Controls.Add(this.txtKod);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(306, 177);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 130D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition5.Width = 60D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 90D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition10.Height = 24D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition11.Height = 24D;
            rowDefinition11.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition12.Height = 24D;
            rowDefinition12.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition7,
            rowDefinition8,
            rowDefinition9,
            rowDefinition10,
            rowDefinition11,
            rowDefinition12});
            this.Root.Size = new System.Drawing.Size(306, 177);
            this.Root.TextVisible = false;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(64, 12);
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
            this.txtKod.StatusBarAciklama = "Kod Giriniz.";
            this.txtKod.StyleController = this.myDataLayoutControl1;
            this.txtKod.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(64, 36);
            this.txtEmail.MenuManager = this.ribbonControl;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEmail.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtEmail.Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.StatusBarAciklama = "E-mail Adresi Giriniz.";
            this.txtEmail.StyleController = this.myDataLayoutControl1;
            this.txtEmail.TabIndex = 1;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtEmail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(286, 24);
            this.layoutControlItem2.Text = "E-Mail";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtSifre
            // 
            this.txtSifre.EnterMoveNextControl = true;
            this.txtSifre.Location = new System.Drawing.Point(64, 60);
            this.txtSifre.MenuManager = this.ribbonControl;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSifre.Properties.MaxLength = 50;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(230, 20);
            this.txtSifre.StatusBarAciklama = "Şifre Giriniz";
            this.txtSifre.StyleController = this.myDataLayoutControl1;
            this.txtSifre.TabIndex = 2;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtSifre;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(286, 24);
            this.layoutControlItem3.Text = "Şifre";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtPortNo
            // 
            this.txtPortNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPortNo.EnterMoveNextControl = true;
            this.txtPortNo.Location = new System.Drawing.Point(64, 84);
            this.txtPortNo.MenuManager = this.ribbonControl;
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPortNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPortNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPortNo.Properties.Mask.EditMask = "d";
            this.txtPortNo.Size = new System.Drawing.Size(74, 20);
            this.txtPortNo.StatusBarAciklama = "Port No Giriniz";
            this.txtPortNo.StyleController = this.myDataLayoutControl1;
            this.txtPortNo.TabIndex = 3;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtPortNo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(130, 24);
            this.layoutControlItem4.Text = "Port No";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtHost
            // 
            this.txtHost.EnterMoveNextControl = true;
            this.txtHost.Location = new System.Drawing.Point(64, 108);
            this.txtHost.MenuManager = this.ribbonControl;
            this.txtHost.Name = "txtHost";
            this.txtHost.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHost.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHost.Properties.MaxLength = 50;
            this.txtHost.Size = new System.Drawing.Size(230, 20);
            this.txtHost.StatusBarAciklama = "Host Giriniz";
            this.txtHost.StyleController = this.myDataLayoutControl1;
            this.txtHost.TabIndex = 4;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtHost;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(286, 24);
            this.layoutControlItem5.Text = "Host";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtSslKullan
            // 
            this.txtSslKullan.EnterMoveNextControl = true;
            this.txtSslKullan.Location = new System.Drawing.Point(64, 132);
            this.txtSslKullan.MenuManager = this.ribbonControl;
            this.txtSslKullan.Name = "txtSslKullan";
            this.txtSslKullan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSslKullan.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSslKullan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSslKullan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtSslKullan.Size = new System.Drawing.Size(74, 20);
            this.txtSslKullan.StatusBarAciklama = "SSL Kullanım Durumunu Seçiniz";
            this.txtSslKullan.StatusBarKisayol = "F4 :";
            this.txtSslKullan.StatusBarKisayolAciklama = "Seçim Yap";
            this.txtSslKullan.StyleController = this.myDataLayoutControl1;
            this.txtSslKullan.TabIndex = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtSslKullan;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(130, 37);
            this.layoutControlItem6.Text = "SSL Kullan";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 13);
            // 
            // EmailParametreEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 310);
            this.Controls.Add(this.myDataLayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmailParametreEditForm";
            this.Text = "E-Mail Parametreleri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSslKullan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyComboBoxEdit txtSslKullan;
        private UserControls.Controls.MyTextEdit txtHost;
        private UserControls.Controls.MySpinEdit txtPortNo;
        private UserControls.Controls.MyTextEdit txtSifre;
        private UserControls.Controls.MyEmailTextEdit txtEmail;
        private UserControls.Controls.MyCodeTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}