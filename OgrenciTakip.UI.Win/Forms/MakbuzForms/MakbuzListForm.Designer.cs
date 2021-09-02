
namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
	partial class MakbuzListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakbuzListForm));
            this.longNavigator1 = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colMakbuzNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTarih = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colMakbuzHesapTuru = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colMakbuzTuru = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHareketSayisi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryHareketSayisi = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMakbuzToplami = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHareketSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            //this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            //this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // barSubItem1
            // 
            //this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            // 
            // btnYeniMakbuz
            // 
            //this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            //this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 506);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1088, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDecimal,
            this.repositoryTarih,
            this.repositoryHareketSayisi});
            this.grid.Size = new System.Drawing.Size(1088, 404);
            this.grid.TabIndex = 3;
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
            this.colMakbuzNo,
            this.colTarih,
            this.colMakbuzHesapTuru,
            this.colMakbuzTuru,
            this.colHareketSayisi,
            this.colMakbuzToplami,
            this.colHesapAdi});
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
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Makbuz Kartları";
            // 
            // colMakbuzNo
            // 
            this.colMakbuzNo.Caption = "Makbuz No";
            this.colMakbuzNo.FieldName = "Kod";
            this.colMakbuzNo.Name = "colMakbuzNo";
            this.colMakbuzNo.OptionsColumn.AllowEdit = false;
            this.colMakbuzNo.StatusBarAciklama = null;
            this.colMakbuzNo.StatusBarKisayol = null;
            this.colMakbuzNo.StatusBarKisayolAciklama = null;
            this.colMakbuzNo.Visible = true;
            this.colMakbuzNo.VisibleIndex = 0;
            this.colMakbuzNo.Width = 90;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisayol = null;
            this.colTarih.StatusBarKisayolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 90;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colMakbuzHesapTuru
            // 
            this.colMakbuzHesapTuru.Caption = "Hesap Türü";
            this.colMakbuzHesapTuru.FieldName = "MakbuzHesapTuru";
            this.colMakbuzHesapTuru.Name = "colMakbuzHesapTuru";
            this.colMakbuzHesapTuru.OptionsColumn.AllowEdit = false;
            this.colMakbuzHesapTuru.StatusBarAciklama = null;
            this.colMakbuzHesapTuru.StatusBarKisayol = null;
            this.colMakbuzHesapTuru.StatusBarKisayolAciklama = null;
            this.colMakbuzHesapTuru.Visible = true;
            this.colMakbuzHesapTuru.VisibleIndex = 2;
            this.colMakbuzHesapTuru.Width = 90;
            // 
            // colMakbuzTuru
            // 
            this.colMakbuzTuru.Caption = "Makbuz Türü";
            this.colMakbuzTuru.FieldName = "MakbuzTuru";
            this.colMakbuzTuru.Name = "colMakbuzTuru";
            this.colMakbuzTuru.OptionsColumn.AllowEdit = false;
            this.colMakbuzTuru.StatusBarAciklama = null;
            this.colMakbuzTuru.StatusBarKisayol = null;
            this.colMakbuzTuru.StatusBarKisayolAciklama = null;
            this.colMakbuzTuru.Visible = true;
            this.colMakbuzTuru.VisibleIndex = 3;
            this.colMakbuzTuru.Width = 200;
            // 
            // colHareketSayisi
            // 
            this.colHareketSayisi.Caption = "Hareket";
            this.colHareketSayisi.ColumnEdit = this.repositoryHareketSayisi;
            this.colHareketSayisi.FieldName = "HareketSayisi";
            this.colHareketSayisi.Name = "colHareketSayisi";
            this.colHareketSayisi.OptionsColumn.AllowEdit = false;
            this.colHareketSayisi.StatusBarAciklama = null;
            this.colHareketSayisi.StatusBarKisayol = null;
            this.colHareketSayisi.StatusBarKisayolAciklama = null;
            this.colHareketSayisi.Visible = true;
            this.colHareketSayisi.VisibleIndex = 4;
            this.colHareketSayisi.Width = 90;
            // 
            // repositoryHareketSayisi
            // 
            this.repositoryHareketSayisi.AutoHeight = false;
            this.repositoryHareketSayisi.DisplayFormat.FormatString = "{0:n0}";
            this.repositoryHareketSayisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryHareketSayisi.Name = "repositoryHareketSayisi";
            // 
            // colMakbuzToplami
            // 
            this.colMakbuzToplami.Caption = "Makbuz Toplamı";
            this.colMakbuzToplami.ColumnEdit = this.repositoryDecimal;
            this.colMakbuzToplami.FieldName = "MakbuzToplami";
            this.colMakbuzToplami.Name = "colMakbuzToplami";
            this.colMakbuzToplami.OptionsColumn.AllowEdit = false;
            this.colMakbuzToplami.StatusBarAciklama = null;
            this.colMakbuzToplami.StatusBarKisayol = null;
            this.colMakbuzToplami.StatusBarKisayolAciklama = null;
            this.colMakbuzToplami.Visible = true;
            this.colMakbuzToplami.VisibleIndex = 5;
            this.colMakbuzToplami.Width = 120;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsColumn.AllowEdit = false;
            this.colHesapAdi.StatusBarAciklama = null;
            this.colHesapAdi.StatusBarKisayol = null;
            this.colHesapAdi.StatusBarKisayolAciklama = null;
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 6;
            this.colHesapAdi.Width = 200;
            // 
            // MakbuzListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 561);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator1);
            this.Name = "MakbuzListForm";
            this.Text = "Makbuz Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHareketSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colMakbuzNo;
        private UserControls.Grid.MyGridColumn colTarih;
        private UserControls.Grid.MyGridColumn colMakbuzHesapTuru;
        private UserControls.Grid.MyGridColumn colMakbuzTuru;
        private UserControls.Grid.MyGridColumn colHareketSayisi;
        private UserControls.Grid.MyGridColumn colMakbuzToplami;
        private UserControls.Grid.MyGridColumn colHesapAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryHareketSayisi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
    }
}