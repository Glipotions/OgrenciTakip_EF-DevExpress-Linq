
namespace OgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
	partial class KullaniciTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colKullaniciAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.comEmail = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colRolAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(687, 358);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKullaniciAdi,
            this.colAdi,
            this.colSoyadi,
            this.comEmail,
            this.colRolAdi,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Kullanıcı Kartları";
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Kullanıcı Kartları";
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "Kullanıcı Adı";
            this.colKullaniciAdi.FieldName = "Kod";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKullaniciAdi.OptionsFilter.AllowAutoFilter = false;
            this.colKullaniciAdi.OptionsFilter.AllowFilter = false;
            this.colKullaniciAdi.StatusBarAciklama = null;
            this.colKullaniciAdi.StatusBarKisayol = null;
            this.colKullaniciAdi.StatusBarKisayolAciklama = null;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 0;
            this.colKullaniciAdi.Width = 135;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisayol = null;
            this.colAdi.StatusBarKisayolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 120;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisayol = null;
            this.colSoyadi.StatusBarKisayolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 2;
            this.colSoyadi.Width = 120;
            // 
            // comEmail
            // 
            this.comEmail.Caption = "E-Mail";
            this.comEmail.FieldName = "Email";
            this.comEmail.Name = "comEmail";
            this.comEmail.OptionsColumn.AllowEdit = false;
            this.comEmail.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.comEmail.OptionsFilter.AllowAutoFilter = false;
            this.comEmail.OptionsFilter.AllowFilter = false;
            this.comEmail.StatusBarAciklama = null;
            this.comEmail.StatusBarKisayol = null;
            this.comEmail.StatusBarKisayolAciklama = null;
            this.comEmail.Visible = true;
            this.comEmail.VisibleIndex = 3;
            this.comEmail.Width = 160;
            // 
            // colRolAdi
            // 
            this.colRolAdi.Caption = "Yetki Türü";
            this.colRolAdi.FieldName = "RolAdi";
            this.colRolAdi.Name = "colRolAdi";
            this.colRolAdi.OptionsColumn.AllowEdit = false;
            this.colRolAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRolAdi.OptionsFilter.AllowAutoFilter = false;
            this.colRolAdi.OptionsFilter.AllowFilter = false;
            this.colRolAdi.StatusBarAciklama = null;
            this.colRolAdi.StatusBarKisayol = null;
            this.colRolAdi.StatusBarKisayolAciklama = null;
            this.colRolAdi.Visible = true;
            this.colRolAdi.VisibleIndex = 4;
            this.colRolAdi.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 250;
            // 
            // KullaniciTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "KullaniciTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colKullaniciAdi;
        private Grid.MyGridColumn colAdi;
        private Grid.MyGridColumn colSoyadi;
        private Grid.MyGridColumn comEmail;
        private Grid.MyGridColumn colRolAdi;
        private Grid.MyGridColumn colAciklama;
    }
}
