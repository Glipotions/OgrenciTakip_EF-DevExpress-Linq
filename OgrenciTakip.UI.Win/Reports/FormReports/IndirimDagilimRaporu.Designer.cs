
namespace OgrenciTakip.UI.Win.Reports.FormReports
{
	partial class IndirimDagilimRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndirimDagilimRaporu));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.colOgrenciNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSinifAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCinsiyet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colYabanciDil = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGeldigiOkul = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRehberOgretmen = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKontenjanTuru = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTesvik = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKayitSekli = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKayitDurumu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVeliAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVeliSoyadi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVeliYakinlik = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVeliMeslek = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVeliGorev = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVeliIsyeri = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colBrutIndirim = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKistDonemDusulenIndirim = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNetIndirim = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryYuzde = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colSubeAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIptalDurumu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOzelKod5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.longNavigator1 = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.btnRaporHazirla = new OgrenciTakip.UI.Win.UserControls.Controls.MySimpleButton();
            this.txtIptalDurumu = new OgrenciTakip.UI.Win.UserControls.Controls.MyCheckedComboBoxEdit();
            this.txtKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Controls.MyCheckedComboBoxEdit();
            this.txtKayitSekli = new OgrenciTakip.UI.Win.UserControls.Controls.MyCheckedComboBoxEdit();
            this.txtSubeler = new OgrenciTakip.UI.Win.UserControls.Controls.MyCheckedComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIndirimler = new OgrenciTakip.UI.Win.UserControls.Controls.MyCheckedComboBoxEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYuzde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIptalDurumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKayitDurumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKayitSekli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubeler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndirimler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
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
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 

            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtIndirimler);
            this.myDataLayoutControl1.Controls.Add(this.grid);
            this.myDataLayoutControl1.Controls.Add(this.longNavigator1);
            this.myDataLayoutControl1.Controls.Add(this.btnRaporHazirla);
            this.myDataLayoutControl1.Controls.Add(this.txtIptalDurumu);
            this.myDataLayoutControl1.Controls.Add(this.txtKayitDurumu);
            this.myDataLayoutControl1.Controls.Add(this.txtKayitSekli);
            this.myDataLayoutControl1.Controls.Add(this.txtSubeler);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 236, 650, 400);
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(1088, 428);
            this.myDataLayoutControl1.TabIndex = 4;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(2, 52);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDecimal,
            this.repositoryYuzde});
            this.grid.Size = new System.Drawing.Size(1084, 348);
            this.grid.TabIndex = 10;
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
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand3,
            this.gridBand9,
            this.gridBand8,
            this.gridBand2,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOgrenciNo,
            this.colOkulNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colCinsiyet,
            this.colKayitTarihi,
            this.colIptalDurumu,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colSinifAdi,
            this.colGeldigiOkul,
            this.colKontenjanTuru,
            this.colYabanciDil,
            this.colRehberOgretmen,
            this.colTesvik,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5,
            this.colTelefon,
            this.colSubeAdi,
            this.colVeliAdi,
            this.colVeliSoyadi,
            this.colVeliYakinlik,
            this.colVeliMeslek,
            this.colVeliIsyeri,
            this.colVeliGorev,
            this.colBrutIndirim,
            this.colKistDonemDusulenIndirim,
            this.colNetIndirim});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIptalDurumu;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[IptalDurumu] = 1";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.tablo.FormatRules.Add(gridFormatRule1);
            this.tablo.GridControl = this.grid;
            this.tablo.GroupCount = 1;
            this.tablo.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutIndirim", this.colBrutIndirim, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenIndirim", this.colKistDonemDusulenIndirim, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetIndirim", this.colNetIndirim, "{0:n2}", "NetIndirim")});
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubeAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.ViewCaption = "İndirim Dağılım Raporu";
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 100;
            // 
            // colOkulNo
            // 
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.Visible = true;
            this.colOkulNo.Width = 100;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "TC Kimlik No";
            this.colTcKimlikNo.CustomizationCaption = "Öğrenci TC Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 100;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 100;
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.Caption = "Cinsiyet";
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            this.colCinsiyet.OptionsColumn.AllowEdit = false;
            this.colCinsiyet.Visible = true;
            this.colCinsiyet.Width = 100;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.CustomizationCaption = "Öğrenci Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Width = 100;
            // 
            // colYabanciDil
            // 
            this.colYabanciDil.Caption = "Yabancı Dil";
            this.colYabanciDil.FieldName = "YabanciDilAdi";
            this.colYabanciDil.Name = "colYabanciDil";
            this.colYabanciDil.OptionsColumn.AllowEdit = false;
            this.colYabanciDil.Width = 100;
            // 
            // colGeldigiOkul
            // 
            this.colGeldigiOkul.Caption = "Geldiği Okul";
            this.colGeldigiOkul.FieldName = "GeldigiOkulAdi";
            this.colGeldigiOkul.Name = "colGeldigiOkul";
            this.colGeldigiOkul.OptionsColumn.AllowEdit = false;
            this.colGeldigiOkul.Width = 100;
            // 
            // colRehberOgretmen
            // 
            this.colRehberOgretmen.Caption = "Rehber Öğretmen";
            this.colRehberOgretmen.FieldName = "RehberAdi";
            this.colRehberOgretmen.Name = "colRehberOgretmen";
            this.colRehberOgretmen.OptionsColumn.AllowEdit = false;
            this.colRehberOgretmen.Width = 100;
            // 
            // colKontenjanTuru
            // 
            this.colKontenjanTuru.Caption = "Kontenjan Türü";
            this.colKontenjanTuru.FieldName = "KontenjanAdi";
            this.colKontenjanTuru.Name = "colKontenjanTuru";
            this.colKontenjanTuru.OptionsColumn.AllowEdit = false;
            this.colKontenjanTuru.Width = 100;
            // 
            // colTesvik
            // 
            this.colTesvik.Caption = "Teşvik Türü";
            this.colTesvik.FieldName = "TesvikAdi";
            this.colTesvik.Name = "colTesvik";
            this.colTesvik.OptionsColumn.AllowEdit = false;
            this.colTesvik.Width = 100;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 100;
            // 
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.Width = 100;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.Width = 100;
            // 
            // colVeliAdi
            // 
            this.colVeliAdi.Caption = "VeliAdı";
            this.colVeliAdi.FieldName = "VeliAdi";
            this.colVeliAdi.Name = "colVeliAdi";
            this.colVeliAdi.OptionsColumn.AllowEdit = false;
            this.colVeliAdi.Visible = true;
            this.colVeliAdi.Width = 100;
            // 
            // colVeliSoyadi
            // 
            this.colVeliSoyadi.Caption = "Veli Soyadı";
            this.colVeliSoyadi.FieldName = "VeliSoyadi";
            this.colVeliSoyadi.Name = "colVeliSoyadi";
            this.colVeliSoyadi.OptionsColumn.AllowEdit = false;
            this.colVeliSoyadi.Visible = true;
            this.colVeliSoyadi.Width = 100;
            // 
            // colVeliYakinlik
            // 
            this.colVeliYakinlik.Caption = "Yakınlık";
            this.colVeliYakinlik.FieldName = "VeliYakinlikAdi";
            this.colVeliYakinlik.Name = "colVeliYakinlik";
            this.colVeliYakinlik.OptionsColumn.AllowEdit = false;
            this.colVeliYakinlik.Visible = true;
            this.colVeliYakinlik.Width = 100;
            // 
            // colVeliMeslek
            // 
            this.colVeliMeslek.Caption = "Meslek";
            this.colVeliMeslek.FieldName = "VeliMeslekAdi";
            this.colVeliMeslek.Name = "colVeliMeslek";
            this.colVeliMeslek.OptionsColumn.AllowEdit = false;
            this.colVeliMeslek.Visible = true;
            this.colVeliMeslek.Width = 100;
            // 
            // colVeliGorev
            // 
            this.colVeliGorev.Caption = "Görev Adı";
            this.colVeliGorev.FieldName = "VeliGorevAdi";
            this.colVeliGorev.Name = "colVeliGorev";
            this.colVeliGorev.OptionsColumn.AllowEdit = false;
            this.colVeliGorev.Visible = true;
            this.colVeliGorev.Width = 100;
            // 
            // colVeliIsyeri
            // 
            this.colVeliIsyeri.Caption = "İşyeri Adı";
            this.colVeliIsyeri.FieldName = "VeliIsyeriAdi";
            this.colVeliIsyeri.Name = "colVeliIsyeri";
            this.colVeliIsyeri.OptionsColumn.AllowEdit = false;
            this.colVeliIsyeri.Visible = true;
            this.colVeliIsyeri.Width = 100;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colBrutIndirim
            // 
            this.colBrutIndirim.Caption = "Brüt İndirim";
            this.colBrutIndirim.ColumnEdit = this.repositoryDecimal;
            this.colBrutIndirim.FieldName = "BrutIndirim";
            this.colBrutIndirim.Name = "colBrutIndirim";
            this.colBrutIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutIndirim", "{0:n2}")});
            this.colBrutIndirim.Visible = true;
            this.colBrutIndirim.Width = 100;
            // 
            // colKistDonemDusulenIndirim
            // 
            this.colKistDonemDusulenIndirim.Caption = "Kıst Dön. Düşülen İndirim";
            this.colKistDonemDusulenIndirim.ColumnEdit = this.repositoryDecimal;
            this.colKistDonemDusulenIndirim.FieldName = "KistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.Name = "colKistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenIndirim", "{0:n2}")});
            this.colKistDonemDusulenIndirim.Visible = true;
            this.colKistDonemDusulenIndirim.Width = 100;
            // 
            // colNetIndirim
            // 
            this.colNetIndirim.Caption = "Net İndirim";
            this.colNetIndirim.ColumnEdit = this.repositoryDecimal;
            this.colNetIndirim.FieldName = "NetIndirim";
            this.colNetIndirim.Name = "colNetIndirim";
            this.colNetIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetIndirim", "{0:n2}")});
            this.colNetIndirim.Visible = true;
            this.colNetIndirim.Width = 100;
            // 
            // repositoryYuzde
            // 
            this.repositoryYuzde.Appearance.Options.UseTextOptions = true;
            this.repositoryYuzde.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryYuzde.AutoHeight = false;
            this.repositoryYuzde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryYuzde.DisplayFormat.FormatString = "{0:F} %";
            this.repositoryYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryYuzde.EditFormat.FormatString = "{0:F} %";
            this.repositoryYuzde.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryYuzde.Name = "repositoryYuzde";
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.Width = 100;
            // 
            // colIptalDurumu
            // 
            this.colIptalDurumu.Caption = "İptal Durumu";
            this.colIptalDurumu.FieldName = "IptalDurumu";
            this.colIptalDurumu.Name = "colIptalDurumu";
            this.colIptalDurumu.OptionsColumn.AllowEdit = false;
            this.colIptalDurumu.OptionsColumn.AllowShowHide = false;
            this.colIptalDurumu.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalDurumu.Width = 100;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1Adi";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 150;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2Adi";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 150;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3Adi";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.Width = 150;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4Adi";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.Width = 150;
            // 
            // colOzelKod5
            // 
            this.colOzelKod5.Caption = "Özel Kod-5";
            this.colOzelKod5.FieldName = "OzelKod5Adi";
            this.colOzelKod5.Name = "colOzelKod5";
            this.colOzelKod5.OptionsColumn.AllowEdit = false;
            this.colOzelKod5.Visible = true;
            this.colOzelKod5.Width = 150;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Location = new System.Drawing.Point(2, 404);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1084, 22);
            this.longNavigator1.TabIndex = 9;
            // 
            // btnRaporHazirla
            // 
            this.btnRaporHazirla.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRaporHazirla.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRaporHazirla.Appearance.Options.UseFont = true;
            this.btnRaporHazirla.Appearance.Options.UseForeColor = true;
            this.btnRaporHazirla.Location = new System.Drawing.Point(913, 28);
            this.btnRaporHazirla.Name = "btnRaporHazirla";
            this.btnRaporHazirla.Size = new System.Drawing.Size(96, 20);
            this.btnRaporHazirla.StatusBarAciklama = null;
            this.btnRaporHazirla.StyleController = this.myDataLayoutControl1;
            this.btnRaporHazirla.TabIndex = 8;
            this.btnRaporHazirla.Text = "Rapor Hazırla";
            // 
            // txtIptalDurumu
            // 
            this.txtIptalDurumu.Location = new System.Drawing.Point(692, 4);
            this.txtIptalDurumu.MenuManager = this.ribbonControl;
            this.txtIptalDurumu.Name = "txtIptalDurumu";
            this.txtIptalDurumu.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtIptalDurumu.Properties.Appearance.Options.UseBackColor = true;
            this.txtIptalDurumu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIptalDurumu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIptalDurumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIptalDurumu.Size = new System.Drawing.Size(317, 20);
            this.txtIptalDurumu.StatusBarAciklama = null;
            this.txtIptalDurumu.StatusBarKisayol = "F4 :";
            this.txtIptalDurumu.StatusBarKisayolAciklama = null;
            this.txtIptalDurumu.StyleController = this.myDataLayoutControl1;
            this.txtIptalDurumu.TabIndex = 7;
            // 
            // txtKayitDurumu
            // 
            this.txtKayitDurumu.Location = new System.Drawing.Point(376, 28);
            this.txtKayitDurumu.MenuManager = this.ribbonControl;
            this.txtKayitDurumu.Name = "txtKayitDurumu";
            this.txtKayitDurumu.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtKayitDurumu.Properties.Appearance.Options.UseBackColor = true;
            this.txtKayitDurumu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKayitDurumu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKayitDurumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKayitDurumu.Size = new System.Drawing.Size(198, 20);
            this.txtKayitDurumu.StatusBarAciklama = null;
            this.txtKayitDurumu.StatusBarKisayol = "F4 :";
            this.txtKayitDurumu.StatusBarKisayolAciklama = null;
            this.txtKayitDurumu.StyleController = this.myDataLayoutControl1;
            this.txtKayitDurumu.TabIndex = 6;
            // 
            // txtKayitSekli
            // 
            this.txtKayitSekli.Location = new System.Drawing.Point(86, 28);
            this.txtKayitSekli.MenuManager = this.ribbonControl;
            this.txtKayitSekli.Name = "txtKayitSekli";
            this.txtKayitSekli.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtKayitSekli.Properties.Appearance.Options.UseBackColor = true;
            this.txtKayitSekli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKayitSekli.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKayitSekli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKayitSekli.Size = new System.Drawing.Size(202, 20);
            this.txtKayitSekli.StatusBarAciklama = null;
            this.txtKayitSekli.StatusBarKisayol = "F4 :";
            this.txtKayitSekli.StatusBarKisayolAciklama = null;
            this.txtKayitSekli.StyleController = this.myDataLayoutControl1;
            this.txtKayitSekli.TabIndex = 5;
            // 
            // txtSubeler
            // 
            this.txtSubeler.Location = new System.Drawing.Point(86, 4);
            this.txtSubeler.MenuManager = this.ribbonControl;
            this.txtSubeler.Name = "txtSubeler";
            this.txtSubeler.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtSubeler.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubeler.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSubeler.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSubeler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSubeler.Size = new System.Drawing.Size(488, 20);
            this.txtSubeler.StatusBarAciklama = null;
            this.txtSubeler.StatusBarKisayol = "F4 :";
            this.txtSubeler.StatusBarKisayolAciklama = null;
            this.txtSubeler.StyleController = this.myDataLayoutControl1;
            this.txtSubeler.TabIndex = 4;
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
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 290D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 286D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 30D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 275D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition5.Width = 30D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 100D;
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition7.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5,
            columnDefinition6,
            columnDefinition7});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition4.Height = 26D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 2, 0);
            this.Root.Size = new System.Drawing.Size(1088, 428);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtSubeler;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(576, 24);
            this.layoutControlItem1.Text = "Şubeler";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtKayitSekli;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem2.Text = "Kayıt Şekli";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtKayitDurumu;
            this.layoutControlItem3.Location = new System.Drawing.Point(290, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(286, 24);
            this.layoutControlItem3.Text = "Kayıt Durumu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtIptalDurumu;
            this.layoutControlItem4.Location = new System.Drawing.Point(606, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(405, 24);
            this.layoutControlItem4.Text = "İptal Durumu";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.btnRaporHazirla;
            this.layoutControlItem5.Location = new System.Drawing.Point(911, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 5;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.longNavigator1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 400);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 7;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(1088, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.grid;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnSpan = 7;
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem7.Size = new System.Drawing.Size(1088, 352);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // txtIndirimler
            // 
            this.txtIndirimler.Location = new System.Drawing.Point(692, 28);
            this.txtIndirimler.MenuManager = this.ribbonControl;
            this.txtIndirimler.Name = "txtIndirimler";
            this.txtIndirimler.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtIndirimler.Properties.Appearance.Options.UseBackColor = true;
            this.txtIndirimler.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIndirimler.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIndirimler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIndirimler.Size = new System.Drawing.Size(187, 20);
            this.txtIndirimler.StatusBarAciklama = null;
            this.txtIndirimler.StatusBarKisayol = "F4 :";
            this.txtIndirimler.StatusBarKisayolAciklama = null;
            this.txtIndirimler.StyleController = this.myDataLayoutControl1;
            this.txtIndirimler.TabIndex = 11;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.txtIndirimler;
            this.layoutControlItem8.Location = new System.Drawing.Point(606, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem8.Size = new System.Drawing.Size(275, 24);
            this.layoutControlItem8.Text = "İndirim Türleri";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(81, 13);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colOgrenciNo);
            this.gridBand1.Columns.Add(this.colOkulNo);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colSinifAdi);
            this.gridBand1.Columns.Add(this.colCinsiyet);
            this.gridBand1.Columns.Add(this.colTelefon);
            this.gridBand1.Columns.Add(this.colYabanciDil);
            this.gridBand1.Columns.Add(this.colGeldigiOkul);
            this.gridBand1.Columns.Add(this.colRehberOgretmen);
            this.gridBand1.Columns.Add(this.colKontenjanTuru);
            this.gridBand1.Columns.Add(this.colTesvik);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 700;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Kayıt Bilgileri";
            this.gridBand3.Columns.Add(this.colKayitTarihi);
            this.gridBand3.Columns.Add(this.colKayitSekli);
            this.gridBand3.Columns.Add(this.colKayitDurumu);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Visible = false;
            this.gridBand3.VisibleIndex = -1;
            this.gridBand3.Width = 300;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "Veli Bilgileri";
            this.gridBand9.Columns.Add(this.colVeliAdi);
            this.gridBand9.Columns.Add(this.colVeliSoyadi);
            this.gridBand9.Columns.Add(this.colVeliYakinlik);
            this.gridBand9.Columns.Add(this.colVeliMeslek);
            this.gridBand9.Columns.Add(this.colVeliGorev);
            this.gridBand9.Columns.Add(this.colVeliIsyeri);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Visible = false;
            this.gridBand9.VisibleIndex = -1;
            this.gridBand9.Width = 600;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "İndirim Bilgileri";
            this.gridBand8.Columns.Add(this.colBrutIndirim);
            this.gridBand8.Columns.Add(this.colKistDonemDusulenIndirim);
            this.gridBand8.Columns.Add(this.colNetIndirim);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 1;
            this.gridBand8.Width = 300;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Diğer Bilgiler";
            this.gridBand2.Columns.Add(this.colSubeAdi);
            this.gridBand2.Columns.Add(this.colIptalDurumu);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Visible = false;
            this.gridBand2.VisibleIndex = -1;
            this.gridBand2.Width = 100;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Özel Kod";
            this.gridBand6.Columns.Add(this.colOzelKod1);
            this.gridBand6.Columns.Add(this.colOzelKod2);
            this.gridBand6.Columns.Add(this.colOzelKod3);
            this.gridBand6.Columns.Add(this.colOzelKod4);
            this.gridBand6.Columns.Add(this.colOzelKod5);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Visible = false;
            this.gridBand6.VisibleIndex = -1;
            this.gridBand6.Width = 750;
            // 
            // IndirimDagilimRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 561);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Name = "IndirimDagilimRaporu";
            this.Text = "İndirim Dağılım Raporu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYuzde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIptalDurumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKayitDurumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKayitSekli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubeler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndirimler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private UserControls.Controls.MyCheckedComboBoxEdit txtIndirimler;
        private UserControls.Grid.MyGridControl grid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrenciNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOkulNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoyadi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSinifAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCinsiyet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTelefon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colYabanciDil;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGeldigiOkul;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRehberOgretmen;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKontenjanTuru;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTesvik;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKayitSekli;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKayitDurumu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVeliAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVeliSoyadi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVeliYakinlik;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVeliMeslek;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVeliGorev;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVeliIsyeri;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBrutIndirim;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKistDonemDusulenIndirim;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNetIndirim;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSubeAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIptalDurumu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOzelKod1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOzelKod2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOzelKod3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOzelKod4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOzelKod5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryYuzde;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Controls.MySimpleButton btnRaporHazirla;
        private UserControls.Controls.MyCheckedComboBoxEdit txtIptalDurumu;
        private UserControls.Controls.MyCheckedComboBoxEdit txtKayitDurumu;
        private UserControls.Controls.MyCheckedComboBoxEdit txtKayitSekli;
        private UserControls.Controls.MyCheckedComboBoxEdit txtSubeler;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}