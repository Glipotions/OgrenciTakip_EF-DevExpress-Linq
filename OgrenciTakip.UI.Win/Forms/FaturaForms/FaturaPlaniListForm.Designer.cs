
namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
	partial class FaturaPlaniListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaPlaniListForm));
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			this.colNetTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
			this.longNavigator1 = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
			this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
			this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colOgrenciNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colSinif = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colVeliAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colVeliSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colYakinlik = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colMeslek = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colKayitTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colKayitSekli = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIptalDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colBrutTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIndirim = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colPlanTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colPlanIndirim = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colPlanNetTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colOzelKod1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colOzelKod2 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colOzelKod3 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colOzelKod4 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colOzelKod5 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sagTikMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1088, 24);
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.OptionsPageCategories.ShowCaptions = false;
			// 
			// 
			// 
			this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.ribbonControl.SearchEditItem.EditWidth = 150;
			this.ribbonControl.SearchEditItem.Id = -5000;
			this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.ribbonControl.Size = new System.Drawing.Size(1088, 109);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// btnExcelDosyalari
			// 
			this.btnExcelDosyalari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelDosyalari.ImageOptions.Image")));
			// 
			// colNetTutar
			// 
			this.colNetTutar.Caption = "Net Tutar";
			this.colNetTutar.ColumnEdit = this.repositoryDecimal;
			this.colNetTutar.FieldName = "HizmetNetTutar";
			this.colNetTutar.Name = "colNetTutar";
			this.colNetTutar.OptionsColumn.AllowEdit = false;
			this.colNetTutar.StatusBarAciklama = null;
			this.colNetTutar.StatusBarKisayol = null;
			this.colNetTutar.StatusBarKisayolAciklama = null;
			this.colNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HizmetNetTutar", "{0:n2}")});
			this.colNetTutar.Visible = true;
			this.colNetTutar.Width = 100;
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
			this.repositoryDecimal.Name = "repositoryDecimal";
			// 
			// longNavigator1
			// 
			this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.longNavigator1.Location = new System.Drawing.Point(0, 513);
			this.longNavigator1.Name = "longNavigator1";
			this.longNavigator1.Size = new System.Drawing.Size(1088, 24);
			this.longNavigator1.TabIndex = 2;
			// 
			// grid
			// 
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 109);
			this.grid.MainView = this.tablo;
			this.grid.MenuManager = this.ribbonControl;
			this.grid.Name = "grid";
			this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
			this.grid.Size = new System.Drawing.Size(1088, 404);
			this.grid.TabIndex = 3;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
			// 
			// tablo
			// 
			this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
			this.tablo.Appearance.BandPanel.Options.UseFont = true;
			this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
			this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
			this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
			this.tablo.BandPanelRowHeight = 40;
			this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
			this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOgrenciNo,
            this.colAdi,
            this.colSoyadi,
            this.colSinif,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colIptalDurumu,
            this.colVeliAdi,
            this.colVeliSoyadi,
            this.colYakinlik,
            this.colMeslek,
            this.colBrutTutar,
            this.colIndirim,
            this.colNetTutar,
            this.colPlanTutar,
            this.colPlanIndirim,
            this.colPlanNetTutar,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5});
			gridFormatRule1.ApplyToRow = true;
			gridFormatRule1.Column = this.colNetTutar;
			gridFormatRule1.Name = "Format0";
			formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Salmon;
			formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
			formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression1.Expression = "[HizmetNetTutar] <> [PlanNetTutar]";
			gridFormatRule1.Rule = formatConditionRuleExpression1;
			gridFormatRule2.ApplyToRow = true;
			gridFormatRule2.Column = this.colNetTutar;
			gridFormatRule2.Name = "Format1";
			formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(93)))));
			formatConditionRuleExpression2.Appearance.Options.HighPriority = true;
			formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression2.Expression = "[HizmetNetTutar] == 0";
			gridFormatRule2.Rule = formatConditionRuleExpression2;
			this.tablo.FormatRules.Add(gridFormatRule1);
			this.tablo.FormatRules.Add(gridFormatRule2);
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
			this.tablo.OptionsView.ShowFooter = true;
			this.tablo.OptionsView.ShowGroupPanel = false;
			this.tablo.OptionsView.ShowViewCaption = true;
			this.tablo.StatusBarAciklama = null;
			this.tablo.StatusBarKisayol = null;
			this.tablo.StatusBarKisayolAciklama = null;
			this.tablo.ViewCaption = "Fatura Planı Kartları";
			// 
			// gridBand1
			// 
			this.gridBand1.Caption = "Öğrenci Bilgileri";
			this.gridBand1.Columns.Add(this.colOgrenciNo);
			this.gridBand1.Columns.Add(this.colAdi);
			this.gridBand1.Columns.Add(this.colSoyadi);
			this.gridBand1.Columns.Add(this.colSinif);
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.VisibleIndex = 0;
			this.gridBand1.Width = 400;
			// 
			// colOgrenciNo
			// 
			this.colOgrenciNo.Caption = "Tahakkuk No";
			this.colOgrenciNo.FieldName = "OgrenciNo";
			this.colOgrenciNo.Name = "colOgrenciNo";
			this.colOgrenciNo.OptionsColumn.AllowEdit = false;
			this.colOgrenciNo.StatusBarAciklama = null;
			this.colOgrenciNo.StatusBarKisayol = null;
			this.colOgrenciNo.StatusBarKisayolAciklama = null;
			this.colOgrenciNo.Visible = true;
			this.colOgrenciNo.Width = 100;
			// 
			// colAdi
			// 
			this.colAdi.Caption = "Adi";
			this.colAdi.FieldName = "Adi";
			this.colAdi.Name = "colAdi";
			this.colAdi.OptionsColumn.AllowEdit = false;
			this.colAdi.StatusBarAciklama = null;
			this.colAdi.StatusBarKisayol = null;
			this.colAdi.StatusBarKisayolAciklama = null;
			this.colAdi.Visible = true;
			this.colAdi.Width = 100;
			// 
			// colSoyadi
			// 
			this.colSoyadi.Caption = "Soyadı";
			this.colSoyadi.FieldName = "Soyadi";
			this.colSoyadi.Name = "colSoyadi";
			this.colSoyadi.OptionsColumn.AllowEdit = false;
			this.colSoyadi.StatusBarAciklama = null;
			this.colSoyadi.StatusBarKisayol = null;
			this.colSoyadi.StatusBarKisayolAciklama = null;
			this.colSoyadi.Visible = true;
			this.colSoyadi.Width = 100;
			// 
			// colSinif
			// 
			this.colSinif.Caption = "Sınıf";
			this.colSinif.FieldName = "SinifAdi";
			this.colSinif.Name = "colSinif";
			this.colSinif.OptionsColumn.AllowEdit = false;
			this.colSinif.StatusBarAciklama = null;
			this.colSinif.StatusBarKisayol = null;
			this.colSinif.StatusBarKisayolAciklama = null;
			this.colSinif.Visible = true;
			this.colSinif.Width = 100;
			// 
			// gridBand2
			// 
			this.gridBand2.Caption = "Veli Bilgileri";
			this.gridBand2.Columns.Add(this.colVeliAdi);
			this.gridBand2.Columns.Add(this.colVeliSoyadi);
			this.gridBand2.Columns.Add(this.colYakinlik);
			this.gridBand2.Columns.Add(this.colMeslek);
			this.gridBand2.Name = "gridBand2";
			this.gridBand2.VisibleIndex = 1;
			this.gridBand2.Width = 400;
			// 
			// colVeliAdi
			// 
			this.colVeliAdi.Caption = "Adı";
			this.colVeliAdi.CustomizationCaption = "Veli Adı";
			this.colVeliAdi.FieldName = "VeliAdi";
			this.colVeliAdi.Name = "colVeliAdi";
			this.colVeliAdi.OptionsColumn.AllowEdit = false;
			this.colVeliAdi.StatusBarAciklama = null;
			this.colVeliAdi.StatusBarKisayol = null;
			this.colVeliAdi.StatusBarKisayolAciklama = null;
			this.colVeliAdi.Visible = true;
			this.colVeliAdi.Width = 100;
			// 
			// colVeliSoyadi
			// 
			this.colVeliSoyadi.Caption = "Soyadı";
			this.colVeliSoyadi.CustomizationCaption = "Veli Soyadı";
			this.colVeliSoyadi.FieldName = "VeliSoyadi";
			this.colVeliSoyadi.Name = "colVeliSoyadi";
			this.colVeliSoyadi.OptionsColumn.AllowEdit = false;
			this.colVeliSoyadi.StatusBarAciklama = null;
			this.colVeliSoyadi.StatusBarKisayol = null;
			this.colVeliSoyadi.StatusBarKisayolAciklama = null;
			this.colVeliSoyadi.Visible = true;
			this.colVeliSoyadi.Width = 100;
			// 
			// colYakinlik
			// 
			this.colYakinlik.Caption = "Yakınlık";
			this.colYakinlik.FieldName = "VeliYakinlikAdi";
			this.colYakinlik.Name = "colYakinlik";
			this.colYakinlik.OptionsColumn.AllowEdit = false;
			this.colYakinlik.StatusBarAciklama = null;
			this.colYakinlik.StatusBarKisayol = null;
			this.colYakinlik.StatusBarKisayolAciklama = null;
			this.colYakinlik.Visible = true;
			this.colYakinlik.Width = 100;
			// 
			// colMeslek
			// 
			this.colMeslek.Caption = "Meslek";
			this.colMeslek.FieldName = "VeliMeslekAdi";
			this.colMeslek.Name = "colMeslek";
			this.colMeslek.OptionsColumn.AllowEdit = false;
			this.colMeslek.StatusBarAciklama = null;
			this.colMeslek.StatusBarKisayol = null;
			this.colMeslek.StatusBarKisayolAciklama = null;
			this.colMeslek.Visible = true;
			this.colMeslek.Width = 100;
			// 
			// gridBand3
			// 
			this.gridBand3.Caption = "Kayıt Bilgileri";
			this.gridBand3.Columns.Add(this.colKayitTarihi);
			this.gridBand3.Columns.Add(this.colKayitSekli);
			this.gridBand3.Columns.Add(this.colKayitDurumu);
			this.gridBand3.Columns.Add(this.colIptalDurumu);
			this.gridBand3.Name = "gridBand3";
			this.gridBand3.VisibleIndex = 2;
			this.gridBand3.Width = 400;
			// 
			// colKayitTarihi
			// 
			this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
			this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKayitTarihi.Caption = "Kayıt Tarihi";
			this.colKayitTarihi.ColumnEdit = this.repositoryTarih;
			this.colKayitTarihi.FieldName = "KayitTarihi";
			this.colKayitTarihi.Name = "colKayitTarihi";
			this.colKayitTarihi.OptionsColumn.AllowEdit = false;
			this.colKayitTarihi.StatusBarAciklama = null;
			this.colKayitTarihi.StatusBarKisayol = null;
			this.colKayitTarihi.StatusBarKisayolAciklama = null;
			this.colKayitTarihi.Visible = true;
			this.colKayitTarihi.Width = 100;
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
			// colKayitSekli
			// 
			this.colKayitSekli.Caption = "Kayıt Şekli";
			this.colKayitSekli.FieldName = "KayitSekli";
			this.colKayitSekli.Name = "colKayitSekli";
			this.colKayitSekli.OptionsColumn.AllowEdit = false;
			this.colKayitSekli.StatusBarAciklama = null;
			this.colKayitSekli.StatusBarKisayol = null;
			this.colKayitSekli.StatusBarKisayolAciklama = null;
			this.colKayitSekli.Visible = true;
			this.colKayitSekli.Width = 100;
			// 
			// colKayitDurumu
			// 
			this.colKayitDurumu.Caption = "Kayıt Durumu";
			this.colKayitDurumu.FieldName = "KayitDurumu";
			this.colKayitDurumu.Name = "colKayitDurumu";
			this.colKayitDurumu.OptionsColumn.AllowEdit = false;
			this.colKayitDurumu.StatusBarAciklama = null;
			this.colKayitDurumu.StatusBarKisayol = null;
			this.colKayitDurumu.StatusBarKisayolAciklama = null;
			this.colKayitDurumu.Visible = true;
			this.colKayitDurumu.Width = 100;
			// 
			// colIptalDurumu
			// 
			this.colIptalDurumu.Caption = "İptal Durumu";
			this.colIptalDurumu.FieldName = "IptalDurumu";
			this.colIptalDurumu.Name = "colIptalDurumu";
			this.colIptalDurumu.OptionsColumn.AllowEdit = false;
			this.colIptalDurumu.StatusBarAciklama = null;
			this.colIptalDurumu.StatusBarKisayol = null;
			this.colIptalDurumu.StatusBarKisayolAciklama = null;
			this.colIptalDurumu.Visible = true;
			this.colIptalDurumu.Width = 100;
			// 
			// gridBand4
			// 
			this.gridBand4.Caption = "Hizmet Bilgileri";
			this.gridBand4.Columns.Add(this.colBrutTutar);
			this.gridBand4.Columns.Add(this.colIndirim);
			this.gridBand4.Columns.Add(this.colNetTutar);
			this.gridBand4.Name = "gridBand4";
			this.gridBand4.VisibleIndex = 3;
			this.gridBand4.Width = 300;
			// 
			// colBrutTutar
			// 
			this.colBrutTutar.Caption = "Tutar";
			this.colBrutTutar.ColumnEdit = this.repositoryDecimal;
			this.colBrutTutar.CustomizationCaption = "Brüt Tutar";
			this.colBrutTutar.FieldName = "HizmetTutar";
			this.colBrutTutar.Name = "colBrutTutar";
			this.colBrutTutar.OptionsColumn.AllowEdit = false;
			this.colBrutTutar.StatusBarAciklama = null;
			this.colBrutTutar.StatusBarKisayol = null;
			this.colBrutTutar.StatusBarKisayolAciklama = null;
			this.colBrutTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HizmetTutar", "{0:n2}")});
			this.colBrutTutar.Visible = true;
			this.colBrutTutar.Width = 100;
			// 
			// colIndirim
			// 
			this.colIndirim.Caption = "İndirim";
			this.colIndirim.ColumnEdit = this.repositoryDecimal;
			this.colIndirim.FieldName = "HizmetIndirim";
			this.colIndirim.Name = "colIndirim";
			this.colIndirim.OptionsColumn.AllowEdit = false;
			this.colIndirim.StatusBarAciklama = null;
			this.colIndirim.StatusBarKisayol = null;
			this.colIndirim.StatusBarKisayolAciklama = null;
			this.colIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HizmetIndirim", "{0:n2}")});
			this.colIndirim.Visible = true;
			this.colIndirim.Width = 100;
			// 
			// gridBand5
			// 
			this.gridBand5.Caption = "Fatura Planı";
			this.gridBand5.Columns.Add(this.colPlanTutar);
			this.gridBand5.Columns.Add(this.colPlanIndirim);
			this.gridBand5.Columns.Add(this.colPlanNetTutar);
			this.gridBand5.Name = "gridBand5";
			this.gridBand5.VisibleIndex = 4;
			this.gridBand5.Width = 300;
			// 
			// colPlanTutar
			// 
			this.colPlanTutar.Caption = "Tutar";
			this.colPlanTutar.ColumnEdit = this.repositoryDecimal;
			this.colPlanTutar.CustomizationCaption = "Plan Tutar";
			this.colPlanTutar.FieldName = "PlanTutar";
			this.colPlanTutar.Name = "colPlanTutar";
			this.colPlanTutar.OptionsColumn.AllowEdit = false;
			this.colPlanTutar.StatusBarAciklama = null;
			this.colPlanTutar.StatusBarKisayol = null;
			this.colPlanTutar.StatusBarKisayolAciklama = null;
			this.colPlanTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanTutar", "{0:n2}")});
			this.colPlanTutar.Visible = true;
			this.colPlanTutar.Width = 100;
			// 
			// colPlanIndirim
			// 
			this.colPlanIndirim.Caption = "İndirim";
			this.colPlanIndirim.ColumnEdit = this.repositoryDecimal;
			this.colPlanIndirim.CustomizationCaption = "Plan İndirim";
			this.colPlanIndirim.FieldName = "PlanIndirim";
			this.colPlanIndirim.Name = "colPlanIndirim";
			this.colPlanIndirim.OptionsColumn.AllowEdit = false;
			this.colPlanIndirim.StatusBarAciklama = null;
			this.colPlanIndirim.StatusBarKisayol = null;
			this.colPlanIndirim.StatusBarKisayolAciklama = null;
			this.colPlanIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanIndirim", "{0:n2}")});
			this.colPlanIndirim.Visible = true;
			this.colPlanIndirim.Width = 100;
			// 
			// colPlanNetTutar
			// 
			this.colPlanNetTutar.Caption = "Net Tutar";
			this.colPlanNetTutar.ColumnEdit = this.repositoryDecimal;
			this.colPlanNetTutar.CustomizationCaption = "Plan Net Tutar";
			this.colPlanNetTutar.FieldName = "PlanNetTutar";
			this.colPlanNetTutar.Name = "colPlanNetTutar";
			this.colPlanNetTutar.OptionsColumn.AllowEdit = false;
			this.colPlanNetTutar.StatusBarAciklama = null;
			this.colPlanNetTutar.StatusBarKisayol = null;
			this.colPlanNetTutar.StatusBarKisayolAciklama = null;
			this.colPlanNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanNetTutar", "{0:n2}")});
			this.colPlanNetTutar.Visible = true;
			this.colPlanNetTutar.Width = 100;
			// 
			// gridBand6
			// 
			this.gridBand6.Caption = "Özel Kod";
			this.gridBand6.Columns.Add(this.colOzelKod1);
			this.gridBand6.Columns.Add(this.colOzelKod2);
			this.gridBand6.Columns.Add(this.colOzelKod3);
			this.gridBand6.Columns.Add(this.colOzelKod4);
			this.gridBand6.Columns.Add(this.colOzelKod5);
			this.gridBand6.Name = "gridBand6";
			this.gridBand6.VisibleIndex = 5;
			this.gridBand6.Width = 550;
			// 
			// colOzelKod1
			// 
			this.colOzelKod1.Caption = "Özel Kod - 1";
			this.colOzelKod1.FieldName = "OzelKod1";
			this.colOzelKod1.Name = "colOzelKod1";
			this.colOzelKod1.OptionsColumn.AllowEdit = false;
			this.colOzelKod1.StatusBarAciklama = null;
			this.colOzelKod1.StatusBarKisayol = null;
			this.colOzelKod1.StatusBarKisayolAciklama = null;
			this.colOzelKod1.Visible = true;
			this.colOzelKod1.Width = 110;
			// 
			// colOzelKod2
			// 
			this.colOzelKod2.Caption = "Özel Kod - 2";
			this.colOzelKod2.FieldName = "OzelKod2";
			this.colOzelKod2.Name = "colOzelKod2";
			this.colOzelKod2.OptionsColumn.AllowEdit = false;
			this.colOzelKod2.StatusBarAciklama = null;
			this.colOzelKod2.StatusBarKisayol = null;
			this.colOzelKod2.StatusBarKisayolAciklama = null;
			this.colOzelKod2.Visible = true;
			this.colOzelKod2.Width = 110;
			// 
			// colOzelKod3
			// 
			this.colOzelKod3.Caption = "Özel Kod - 3";
			this.colOzelKod3.FieldName = "OzelKod3";
			this.colOzelKod3.Name = "colOzelKod3";
			this.colOzelKod3.OptionsColumn.AllowEdit = false;
			this.colOzelKod3.StatusBarAciklama = null;
			this.colOzelKod3.StatusBarKisayol = null;
			this.colOzelKod3.StatusBarKisayolAciklama = null;
			this.colOzelKod3.Visible = true;
			this.colOzelKod3.Width = 110;
			// 
			// colOzelKod4
			// 
			this.colOzelKod4.Caption = "Özel Kod - 4";
			this.colOzelKod4.FieldName = "OzelKod4";
			this.colOzelKod4.Name = "colOzelKod4";
			this.colOzelKod4.OptionsColumn.AllowEdit = false;
			this.colOzelKod4.StatusBarAciklama = null;
			this.colOzelKod4.StatusBarKisayol = null;
			this.colOzelKod4.StatusBarKisayolAciklama = null;
			this.colOzelKod4.Visible = true;
			this.colOzelKod4.Width = 110;
			// 
			// colOzelKod5
			// 
			this.colOzelKod5.Caption = "Özel Kod - 5";
			this.colOzelKod5.FieldName = "OzelKod5";
			this.colOzelKod5.Name = "colOzelKod5";
			this.colOzelKod5.OptionsColumn.AllowEdit = false;
			this.colOzelKod5.StatusBarAciklama = null;
			this.colOzelKod5.StatusBarKisayol = null;
			this.colOzelKod5.StatusBarKisayolAciklama = null;
			this.colOzelKod5.Visible = true;
			this.colOzelKod5.Width = 110;
			// 
			// progressBarControl
			// 
			this.progressBarControl.Location = new System.Drawing.Point(378, 255);
			this.progressBarControl.MenuManager = this.ribbonControl;
			this.progressBarControl.Name = "progressBarControl";
			this.progressBarControl.Properties.ShowTitle = true;
			this.progressBarControl.Size = new System.Drawing.Size(342, 32);
			this.progressBarControl.TabIndex = 4;
			this.progressBarControl.Visible = false;
			// 
			// FaturaPlaniListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 561);
			this.Controls.Add(this.progressBarControl);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.longNavigator1);
			this.IconOptions.ShowIcon = false;
			this.Name = "FaturaPlaniListForm";
			this.Text = "Fatura Planı Kartları";
			this.Controls.SetChildIndex(this.ribbonControl, 0);
			this.Controls.SetChildIndex(this.ribbonStatusBar1, 0);
			this.Controls.SetChildIndex(this.longNavigator1, 0);
			this.Controls.SetChildIndex(this.grid, 0);
			this.Controls.SetChildIndex(this.progressBarControl, 0);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sagTikMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grid.MyBandedGridColumn colOgrenciNo;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colSinif;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grid.MyBandedGridColumn colVeliAdi;
        private UserControls.Grid.MyBandedGridColumn colVeliSoyadi;
        private UserControls.Grid.MyBandedGridColumn colYakinlik;
        private UserControls.Grid.MyBandedGridColumn colMeslek;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grid.MyBandedGridColumn colKayitTarihi;
        private UserControls.Grid.MyBandedGridColumn colKayitSekli;
        private UserControls.Grid.MyBandedGridColumn colKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colIptalDurumu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grid.MyBandedGridColumn colBrutTutar;
        private UserControls.Grid.MyBandedGridColumn colIndirim;
        private UserControls.Grid.MyBandedGridColumn colNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private UserControls.Grid.MyBandedGridColumn colPlanTutar;
        private UserControls.Grid.MyBandedGridColumn colPlanIndirim;
        private UserControls.Grid.MyBandedGridColumn colPlanNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2;
        private UserControls.Grid.MyBandedGridColumn colOzelKod3;
        private UserControls.Grid.MyBandedGridColumn colOzelKod4;
        private UserControls.Grid.MyBandedGridColumn colOzelKod5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
    }
}