
namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
	partial class TahakkukListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahakkukListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBabaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAnaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOgrenciNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOkulNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitSekli = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSinif = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colYabanciDil = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colGeldigiOkul = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKontenjan = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTesvik = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colRehber = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonrakiDonemKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonrakiDonemKayitDurumuAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod3 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod4 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod5 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 506);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1088, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
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
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colOgrenciNo,
            this.colOkulNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colSinif,
            this.colGeldigiOkul,
            this.colKontenjan,
            this.colYabanciDil,
            this.colRehber,
            this.colTesvik,
            this.colSonrakiDonemKayitDurumu,
            this.colSonrakiDonemKayitDurumuAciklama,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5,
            this.colSubeAdi});
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
            this.tablo.ViewCaption = "Tahakkuk Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "TC Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisayol = null;
            this.colTcKimlikNo.StatusBarKisayolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
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
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisayol = null;
            this.colBabaAdi.StatusBarKisayolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.Width = 100;
            // 
            // colAnaAdi
            // 
            this.colAnaAdi.Caption = "Ana Adı";
            this.colAnaAdi.FieldName = "AnaAdi";
            this.colAnaAdi.Name = "colAnaAdi";
            this.colAnaAdi.OptionsColumn.AllowEdit = false;
            this.colAnaAdi.StatusBarAciklama = null;
            this.colAnaAdi.StatusBarKisayol = null;
            this.colAnaAdi.StatusBarKisayolAciklama = null;
            this.colAnaAdi.Visible = true;
            this.colAnaAdi.Width = 100;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "Kod";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 85;
            // 
            // colOkulNo
            // 
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.StatusBarAciklama = null;
            this.colOkulNo.StatusBarKisayol = null;
            this.colOkulNo.StatusBarKisayolAciklama = null;
            this.colOkulNo.Visible = true;
            this.colOkulNo.Width = 85;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisayol = null;
            this.colKayitTarihi.StatusBarKisayolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 90;
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
            this.colKayitSekli.Width = 110;
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
            this.colKayitDurumu.Width = 110;
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
            // colYabanciDil
            // 
            this.colYabanciDil.Caption = "Yabanci Dil";
            this.colYabanciDil.FieldName = "YabanciDilAdi";
            this.colYabanciDil.Name = "colYabanciDil";
            this.colYabanciDil.OptionsColumn.AllowEdit = false;
            this.colYabanciDil.StatusBarAciklama = null;
            this.colYabanciDil.StatusBarKisayol = null;
            this.colYabanciDil.StatusBarKisayolAciklama = null;
            this.colYabanciDil.Visible = true;
            this.colYabanciDil.Width = 110;
            // 
            // colGeldigiOkul
            // 
            this.colGeldigiOkul.Caption = "Geldiği Okul";
            this.colGeldigiOkul.FieldName = "GeldigiOkulAdi";
            this.colGeldigiOkul.Name = "colGeldigiOkul";
            this.colGeldigiOkul.OptionsColumn.AllowEdit = false;
            this.colGeldigiOkul.StatusBarAciklama = null;
            this.colGeldigiOkul.StatusBarKisayol = null;
            this.colGeldigiOkul.StatusBarKisayolAciklama = null;
            this.colGeldigiOkul.Visible = true;
            this.colGeldigiOkul.Width = 120;
            // 
            // colKontenjan
            // 
            this.colKontenjan.Caption = "Kontenjan Türü";
            this.colKontenjan.FieldName = "KontenjanAdi";
            this.colKontenjan.Name = "colKontenjan";
            this.colKontenjan.OptionsColumn.AllowEdit = false;
            this.colKontenjan.StatusBarAciklama = null;
            this.colKontenjan.StatusBarKisayol = null;
            this.colKontenjan.StatusBarKisayolAciklama = null;
            this.colKontenjan.Visible = true;
            this.colKontenjan.Width = 120;
            // 
            // colTesvik
            // 
            this.colTesvik.Caption = "Teşvik Türü";
            this.colTesvik.FieldName = "TesvikAdi";
            this.colTesvik.Name = "colTesvik";
            this.colTesvik.OptionsColumn.AllowEdit = false;
            this.colTesvik.StatusBarAciklama = null;
            this.colTesvik.StatusBarKisayol = null;
            this.colTesvik.StatusBarKisayolAciklama = null;
            this.colTesvik.Visible = true;
            this.colTesvik.Width = 120;
            // 
            // colRehber
            // 
            this.colRehber.Caption = "Rehber";
            this.colRehber.FieldName = "RehberAdi";
            this.colRehber.Name = "colRehber";
            this.colRehber.OptionsColumn.AllowEdit = false;
            this.colRehber.StatusBarAciklama = null;
            this.colRehber.StatusBarKisayol = null;
            this.colRehber.StatusBarKisayolAciklama = null;
            this.colRehber.Visible = true;
            this.colRehber.Width = 110;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisayol = null;
            this.colSubeAdi.StatusBarKisayolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.Width = 150;
            // 
            // colSonrakiDonemKayitDurumu
            // 
            this.colSonrakiDonemKayitDurumu.Caption = "Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.CustomizationCaption = "Sonraki Dönem Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.FieldName = "SonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.Name = "colSonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumu.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisayol = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisayolAciklama = null;
            this.colSonrakiDonemKayitDurumu.Visible = true;
            this.colSonrakiDonemKayitDurumu.Width = 150;
            // 
            // colSonrakiDonemKayitDurumuAciklama
            // 
            this.colSonrakiDonemKayitDurumuAciklama.Caption = "Açıklama";
            this.colSonrakiDonemKayitDurumuAciklama.CustomizationCaption = "Sonraki Dönem Kayıt Durumu Açıklama";
            this.colSonrakiDonemKayitDurumuAciklama.FieldName = "SonrakiDonemKayitDurumuAciklama";
            this.colSonrakiDonemKayitDurumuAciklama.Name = "colSonrakiDonemKayitDurumuAciklama";
            this.colSonrakiDonemKayitDurumuAciklama.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarKisayol = null;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarKisayolAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklama.Visible = true;
            this.colSonrakiDonemKayitDurumuAciklama.Width = 250;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1Adi";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisayol = null;
            this.colOzelKod1.StatusBarKisayolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 120;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2Adi";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisayol = null;
            this.colOzelKod2.StatusBarKisayolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 120;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3Adi";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            this.colOzelKod3.StatusBarAciklama = null;
            this.colOzelKod3.StatusBarKisayol = null;
            this.colOzelKod3.StatusBarKisayolAciklama = null;
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.Width = 120;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel kod-4";
            this.colOzelKod4.FieldName = "OzelKod4Adi";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            this.colOzelKod4.StatusBarAciklama = null;
            this.colOzelKod4.StatusBarKisayol = null;
            this.colOzelKod4.StatusBarKisayolAciklama = null;
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.Width = 120;
            // 
            // colOzelKod5
            // 
            this.colOzelKod5.Caption = "Özel Kod-5";
            this.colOzelKod5.FieldName = "OzelKod5Adi";
            this.colOzelKod5.Name = "colOzelKod5";
            this.colOzelKod5.OptionsColumn.AllowEdit = false;
            this.colOzelKod5.StatusBarAciklama = null;
            this.colOzelKod5.StatusBarKisayol = null;
            this.colOzelKod5.StatusBarKisayolAciklama = null;
            this.colOzelKod5.Visible = true;
            this.colOzelKod5.Width = 120;
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            this.bndSecim.Width = 60;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colBabaAdi);
            this.gridBand1.Columns.Add(this.colAnaAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 500;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colOgrenciNo);
            this.gridBand2.Columns.Add(this.colOkulNo);
            this.gridBand2.Columns.Add(this.colKayitTarihi);
            this.gridBand2.Columns.Add(this.colKayitSekli);
            this.gridBand2.Columns.Add(this.colKayitDurumu);
            this.gridBand2.Columns.Add(this.colSinif);
            this.gridBand2.Columns.Add(this.colYabanciDil);
            this.gridBand2.Columns.Add(this.colGeldigiOkul);
            this.gridBand2.Columns.Add(this.colKontenjan);
            this.gridBand2.Columns.Add(this.colTesvik);
            this.gridBand2.Columns.Add(this.colRehber);
            this.gridBand2.Columns.Add(this.colSubeAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1310;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Sonraki Dönem";
            this.gridBand3.Columns.Add(this.colSonrakiDonemKayitDurumu);
            this.gridBand3.Columns.Add(this.colSonrakiDonemKayitDurumuAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Özel Kod";
            this.gridBand4.Columns.Add(this.colOzelKod1);
            this.gridBand4.Columns.Add(this.colOzelKod2);
            this.gridBand4.Columns.Add(this.colOzelKod3);
            this.gridBand4.Columns.Add(this.colOzelKod4);
            this.gridBand4.Columns.Add(this.colOzelKod5);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 600;
            // 
            // TahakkukListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 561);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "TahakkukListForm";
            this.Text = "Tahakkuk Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private UserControls.Grid.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colBabaAdi;
        private UserControls.Grid.MyBandedGridColumn colAnaAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrenciNo;
        private UserControls.Grid.MyBandedGridColumn colOkulNo;
        private UserControls.Grid.MyBandedGridColumn colKayitTarihi;
        private UserControls.Grid.MyBandedGridColumn colKayitSekli;
        private UserControls.Grid.MyBandedGridColumn colKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colSinif;
        private UserControls.Grid.MyBandedGridColumn colYabanciDil;
        private UserControls.Grid.MyBandedGridColumn colGeldigiOkul;
        private UserControls.Grid.MyBandedGridColumn colKontenjan;
        private UserControls.Grid.MyBandedGridColumn colTesvik;
        private UserControls.Grid.MyBandedGridColumn colRehber;
        private UserControls.Grid.MyBandedGridColumn colSubeAdi;
        private UserControls.Grid.MyBandedGridColumn colSonrakiDonemKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colSonrakiDonemKayitDurumuAciklama;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2;
        private UserControls.Grid.MyBandedGridColumn colOzelKod3;
        private UserControls.Grid.MyBandedGridColumn colOzelKod4;
        private UserControls.Grid.MyBandedGridColumn colOzelKod5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}