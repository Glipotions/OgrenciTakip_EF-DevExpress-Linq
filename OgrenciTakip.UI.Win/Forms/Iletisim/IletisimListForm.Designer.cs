
namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
	partial class IletisimListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IletisimListForm));
			this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
			this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
			this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
			this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colMeslek = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colWeb = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colEmail = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colEvTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIsTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colCepTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colEvAdres = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colEvAdresIlAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colEvAdresIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIsAdres = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIsAdresIlAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIsAdresIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colIsyeriAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colGorevAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colOzelKod1Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colOzelKod2Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
			this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
			this.gridBand4,
			this.gridBand5,
			this.gridBand6});
			this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
			this.colId,
			this.colKod,
			this.colTcKimlikNo,
			this.colAdi,
			this.colSoyadi,
			this.colMeslek,
			this.colWeb,
			this.colEmail,
			this.colEvTelefonu1,
			this.colIsTelefonu1,
			this.colCepTelefonu1,
			this.colEvAdres,
			this.colEvAdresIlAdi,
			this.colEvAdresIlceAdi,
			this.colIsAdres,
			this.colIsAdresIlAdi,
			this.colIsAdresIlceAdi,
			this.colIsyeriAdi,
			this.colGorevAdi,
			this.colOzelKod1Adi,
			this.colOzelKod2Adi,
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
			this.tablo.OptionsView.ShowAutoFilterRow = true;
			this.tablo.OptionsView.ShowGroupPanel = false;
			this.tablo.OptionsView.ShowViewCaption = true;
			this.tablo.StatusBarAciklama = null;
			this.tablo.StatusBarKisayol = null;
			this.tablo.StatusBarKisayolAciklama = null;
			this.tablo.ViewCaption = "İletişim Kartları";
			// 
			// colKod
			// 
			this.colKod.AppearanceCell.Options.UseTextOptions = true;
			this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKod.Caption = "Kod";
			this.colKod.FieldName = "Kod";
			this.colKod.Name = "colKod";
			this.colKod.OptionsColumn.AllowEdit = false;
			this.colKod.Visible = true;
			this.colKod.Width = 120;
			// 
			// colTcKimlikNo
			// 
			this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
			this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTcKimlikNo.Caption = "Tc Kimlik No";
			this.colTcKimlikNo.FieldName = "TcKimlikNo";
			this.colTcKimlikNo.Name = "colTcKimlikNo";
			this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
			this.colTcKimlikNo.StatusBarAciklama = null;
			this.colTcKimlikNo.StatusBarKisayol = null;
			this.colTcKimlikNo.StatusBarKisayolAciklama = null;
			this.colTcKimlikNo.Visible = true;
			this.colTcKimlikNo.Width = 110;
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
			this.colAdi.Width = 120;
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
			this.colSoyadi.Width = 120;
			// 
			// colMeslek
			// 
			this.colMeslek.Caption = "Meslek";
			this.colMeslek.FieldName = "MeslekAdi";
			this.colMeslek.Name = "colMeslek";
			this.colMeslek.OptionsColumn.AllowEdit = false;
			this.colMeslek.StatusBarAciklama = null;
			this.colMeslek.StatusBarKisayol = null;
			this.colMeslek.StatusBarKisayolAciklama = null;
			this.colMeslek.Visible = true;
			this.colMeslek.Width = 120;
			// 
			// colWeb
			// 
			this.colWeb.Caption = "Web Adresi";
			this.colWeb.FieldName = "Web";
			this.colWeb.Name = "colWeb";
			this.colWeb.OptionsColumn.AllowEdit = false;
			this.colWeb.StatusBarAciklama = null;
			this.colWeb.StatusBarKisayol = null;
			this.colWeb.StatusBarKisayolAciklama = null;
			this.colWeb.Visible = true;
			this.colWeb.Width = 150;
			// 
			// colEmail
			// 
			this.colEmail.Caption = "E-Mail";
			this.colEmail.FieldName = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.OptionsColumn.AllowEdit = false;
			this.colEmail.StatusBarAciklama = null;
			this.colEmail.StatusBarKisayol = null;
			this.colEmail.StatusBarKisayolAciklama = null;
			this.colEmail.Visible = true;
			this.colEmail.Width = 150;
			// 
			// colEvTelefonu1
			// 
			this.colEvTelefonu1.AppearanceCell.Options.UseTextOptions = true;
			this.colEvTelefonu1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colEvTelefonu1.Caption = "Ev";
			this.colEvTelefonu1.CustomizationCaption = "Ev Telefonu";
			this.colEvTelefonu1.FieldName = "EvTelefonu";
			this.colEvTelefonu1.Name = "colEvTelefonu1";
			this.colEvTelefonu1.OptionsColumn.AllowEdit = false;
			this.colEvTelefonu1.StatusBarAciklama = null;
			this.colEvTelefonu1.StatusBarKisayol = null;
			this.colEvTelefonu1.StatusBarKisayolAciklama = null;
			this.colEvTelefonu1.Visible = true;
			this.colEvTelefonu1.Width = 120;
			// 
			// colIsTelefonu1
			// 
			this.colIsTelefonu1.AppearanceCell.Options.UseTextOptions = true;
			this.colIsTelefonu1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colIsTelefonu1.Caption = "İş";
			this.colIsTelefonu1.CustomizationCaption = "İş Telefonu";
			this.colIsTelefonu1.FieldName = "IsTelefonu1";
			this.colIsTelefonu1.Name = "colIsTelefonu1";
			this.colIsTelefonu1.OptionsColumn.AllowEdit = false;
			this.colIsTelefonu1.StatusBarAciklama = null;
			this.colIsTelefonu1.StatusBarKisayol = null;
			this.colIsTelefonu1.StatusBarKisayolAciklama = null;
			this.colIsTelefonu1.Visible = true;
			this.colIsTelefonu1.Width = 120;
			// 
			// colCepTelefonu1
			// 
			this.colCepTelefonu1.AppearanceCell.Options.UseTextOptions = true;
			this.colCepTelefonu1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCepTelefonu1.Caption = "Cep";
			this.colCepTelefonu1.CustomizationCaption = "Cep Telefonu";
			this.colCepTelefonu1.FieldName = "CepTelefonu1";
			this.colCepTelefonu1.Name = "colCepTelefonu1";
			this.colCepTelefonu1.OptionsColumn.AllowEdit = false;
			this.colCepTelefonu1.StatusBarAciklama = null;
			this.colCepTelefonu1.StatusBarKisayol = null;
			this.colCepTelefonu1.StatusBarKisayolAciklama = null;
			this.colCepTelefonu1.Visible = true;
			this.colCepTelefonu1.Width = 120;
			// 
			// colEvAdres
			// 
			this.colEvAdres.Caption = "Ev";
			this.colEvAdres.CustomizationCaption = "Ev Adresi";
			this.colEvAdres.FieldName = "EvAdres";
			this.colEvAdres.Name = "colEvAdres";
			this.colEvAdres.OptionsColumn.AllowEdit = false;
			this.colEvAdres.StatusBarAciklama = null;
			this.colEvAdres.StatusBarKisayol = null;
			this.colEvAdres.StatusBarKisayolAciklama = null;
			this.colEvAdres.Visible = true;
			this.colEvAdres.Width = 250;
			// 
			// colEvAdresIlAdi
			// 
			this.colEvAdresIlAdi.Caption = "İl";
			this.colEvAdresIlAdi.CustomizationCaption = "Ev Adres İl Adı";
			this.colEvAdresIlAdi.FieldName = "EvAdresIlAdi";
			this.colEvAdresIlAdi.Name = "colEvAdresIlAdi";
			this.colEvAdresIlAdi.OptionsColumn.AllowEdit = false;
			this.colEvAdresIlAdi.StatusBarAciklama = null;
			this.colEvAdresIlAdi.StatusBarKisayol = null;
			this.colEvAdresIlAdi.StatusBarKisayolAciklama = null;
			this.colEvAdresIlAdi.Visible = true;
			this.colEvAdresIlAdi.Width = 110;
			// 
			// colEvAdresIlceAdi
			// 
			this.colEvAdresIlceAdi.Caption = "İlçe";
			this.colEvAdresIlceAdi.CustomizationCaption = "Ev Adres İlçe Adı";
			this.colEvAdresIlceAdi.FieldName = "EvAdresIlceAdi";
			this.colEvAdresIlceAdi.Name = "colEvAdresIlceAdi";
			this.colEvAdresIlceAdi.OptionsColumn.AllowEdit = false;
			this.colEvAdresIlceAdi.StatusBarAciklama = null;
			this.colEvAdresIlceAdi.StatusBarKisayol = null;
			this.colEvAdresIlceAdi.StatusBarKisayolAciklama = null;
			this.colEvAdresIlceAdi.Visible = true;
			this.colEvAdresIlceAdi.Width = 110;
			// 
			// colIsAdres
			// 
			this.colIsAdres.Caption = "İş";
			this.colIsAdres.CustomizationCaption = "İş Adresi";
			this.colIsAdres.FieldName = "IsAdres";
			this.colIsAdres.Name = "colIsAdres";
			this.colIsAdres.OptionsColumn.AllowEdit = false;
			this.colIsAdres.StatusBarAciklama = null;
			this.colIsAdres.StatusBarKisayol = null;
			this.colIsAdres.StatusBarKisayolAciklama = null;
			this.colIsAdres.Visible = true;
			this.colIsAdres.Width = 250;
			// 
			// colIsAdresIlAdi
			// 
			this.colIsAdresIlAdi.Caption = "İl";
			this.colIsAdresIlAdi.CustomizationCaption = "İş Adres İl Adı";
			this.colIsAdresIlAdi.FieldName = "IsAdresIlAdi";
			this.colIsAdresIlAdi.Name = "colIsAdresIlAdi";
			this.colIsAdresIlAdi.OptionsColumn.AllowEdit = false;
			this.colIsAdresIlAdi.StatusBarAciklama = null;
			this.colIsAdresIlAdi.StatusBarKisayol = null;
			this.colIsAdresIlAdi.StatusBarKisayolAciklama = null;
			this.colIsAdresIlAdi.Visible = true;
			this.colIsAdresIlAdi.Width = 110;
			// 
			// colIsAdresIlceAdi
			// 
			this.colIsAdresIlceAdi.Caption = "İlçe";
			this.colIsAdresIlceAdi.CustomizationCaption = "İş Adres İlçe Adı";
			this.colIsAdresIlceAdi.FieldName = "IsAdresIlceAdi";
			this.colIsAdresIlceAdi.Name = "colIsAdresIlceAdi";
			this.colIsAdresIlceAdi.OptionsColumn.AllowEdit = false;
			this.colIsAdresIlceAdi.StatusBarAciklama = null;
			this.colIsAdresIlceAdi.StatusBarKisayol = null;
			this.colIsAdresIlceAdi.StatusBarKisayolAciklama = null;
			this.colIsAdresIlceAdi.Visible = true;
			this.colIsAdresIlceAdi.Width = 110;
			// 
			// colIsyeriAdi
			// 
			this.colIsyeriAdi.Caption = "Adı";
			this.colIsyeriAdi.CustomizationCaption = "İşyeri Adı";
			this.colIsyeriAdi.FieldName = "IsyeriAdi";
			this.colIsyeriAdi.Name = "colIsyeriAdi";
			this.colIsyeriAdi.OptionsColumn.AllowEdit = false;
			this.colIsyeriAdi.StatusBarAciklama = null;
			this.colIsyeriAdi.StatusBarKisayol = null;
			this.colIsyeriAdi.StatusBarKisayolAciklama = null;
			this.colIsyeriAdi.Visible = true;
			this.colIsyeriAdi.Width = 150;
			// 
			// colGorevAdi
			// 
			this.colGorevAdi.Caption = "Görevi";
			this.colGorevAdi.CustomizationCaption = "Görev Adı";
			this.colGorevAdi.FieldName = "GorevAdi";
			this.colGorevAdi.Name = "colGorevAdi";
			this.colGorevAdi.OptionsColumn.AllowEdit = false;
			this.colGorevAdi.StatusBarAciklama = null;
			this.colGorevAdi.StatusBarKisayol = null;
			this.colGorevAdi.StatusBarKisayolAciklama = null;
			this.colGorevAdi.Visible = true;
			this.colGorevAdi.Width = 150;
			// 
			// colOzelKod1Adi
			// 
			this.colOzelKod1Adi.Caption = "Özel Kod-1";
			this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
			this.colOzelKod1Adi.Name = "colOzelKod1Adi";
			this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
			this.colOzelKod1Adi.StatusBarAciklama = null;
			this.colOzelKod1Adi.StatusBarKisayol = null;
			this.colOzelKod1Adi.StatusBarKisayolAciklama = null;
			this.colOzelKod1Adi.Visible = true;
			this.colOzelKod1Adi.Width = 120;
			// 
			// colOzelKod2Adi
			// 
			this.colOzelKod2Adi.Caption = "Özel Kod-2";
			this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
			this.colOzelKod2Adi.Name = "colOzelKod2Adi";
			this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
			this.colOzelKod2Adi.StatusBarAciklama = null;
			this.colOzelKod2Adi.StatusBarKisayol = null;
			this.colOzelKod2Adi.StatusBarKisayolAciklama = null;
			this.colOzelKod2Adi.Visible = true;
			this.colOzelKod2Adi.Width = 120;
			// 
			// colAciklama
			// 
			this.colAciklama.Caption = "Açıklama";
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.OptionsColumn.AllowEdit = false;
			this.colAciklama.StatusBarAciklama = null;
			this.colAciklama.StatusBarKisayol = null;
			this.colAciklama.StatusBarKisayolAciklama = null;
			this.colAciklama.Visible = true;
			this.colAciklama.Width = 350;
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			this.colId.OptionsColumn.AllowEdit = false;
			this.colId.OptionsColumn.ShowInCustomizationForm = false;
			// 
			// bndSecim
			// 
			this.bndSecim.Caption = "Seç";
			this.bndSecim.Name = "bndSecim";
			this.bndSecim.Visible = false;
			this.bndSecim.VisibleIndex = -1;
			this.bndSecim.Width = 50;
			// 
			// gridBand1
			// 
			this.gridBand1.Caption = "Genel Bilgiler";
			this.gridBand1.Columns.Add(this.colKod);
			this.gridBand1.Columns.Add(this.colTcKimlikNo);
			this.gridBand1.Columns.Add(this.colAdi);
			this.gridBand1.Columns.Add(this.colSoyadi);
			this.gridBand1.Columns.Add(this.colMeslek);
			this.gridBand1.Columns.Add(this.colWeb);
			this.gridBand1.Columns.Add(this.colEmail);
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.VisibleIndex = 0;
			this.gridBand1.Width = 890;
			// 
			// gridBand2
			// 
			this.gridBand2.Caption = "Telefon";
			this.gridBand2.Columns.Add(this.colEvTelefonu1);
			this.gridBand2.Columns.Add(this.colIsTelefonu1);
			this.gridBand2.Columns.Add(this.colCepTelefonu1);
			this.gridBand2.Name = "gridBand2";
			this.gridBand2.VisibleIndex = 1;
			this.gridBand2.Width = 360;
			// 
			// gridBand3
			// 
			this.gridBand3.Caption = "Adres";
			this.gridBand3.Columns.Add(this.colEvAdres);
			this.gridBand3.Columns.Add(this.colEvAdresIlAdi);
			this.gridBand3.Columns.Add(this.colEvAdresIlceAdi);
			this.gridBand3.Columns.Add(this.colIsAdres);
			this.gridBand3.Columns.Add(this.colIsAdresIlAdi);
			this.gridBand3.Columns.Add(this.colIsAdresIlceAdi);
			this.gridBand3.Name = "gridBand3";
			this.gridBand3.VisibleIndex = 2;
			this.gridBand3.Width = 940;
			// 
			// gridBand4
			// 
			this.gridBand4.Caption = "İşyeri / Firma";
			this.gridBand4.Columns.Add(this.colIsyeriAdi);
			this.gridBand4.Columns.Add(this.colGorevAdi);
			this.gridBand4.Name = "gridBand4";
			this.gridBand4.VisibleIndex = 3;
			this.gridBand4.Width = 300;
			// 
			// gridBand5
			// 
			this.gridBand5.Caption = "Özel Kod";
			this.gridBand5.Columns.Add(this.colOzelKod1Adi);
			this.gridBand5.Columns.Add(this.colOzelKod2Adi);
			this.gridBand5.Name = "gridBand5";
			this.gridBand5.VisibleIndex = 4;
			this.gridBand5.Width = 240;
			// 
			// gridBand6
			// 
			this.gridBand6.Caption = "Ek Bilgiler";
			this.gridBand6.Columns.Add(this.colAciklama);
			this.gridBand6.Name = "gridBand6";
			this.gridBand6.VisibleIndex = 5;
			this.gridBand6.Width = 350;
			// 
			// IletisimListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 561);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.longNavigator);
			this.Name = "IletisimListForm";
			this.Text = "İletişim Kartları";
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
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
		private UserControls.Grid.MyBandedGridColumn colTcKimlikNo;
		private UserControls.Grid.MyBandedGridColumn colAdi;
		private UserControls.Grid.MyBandedGridColumn colSoyadi;
		private UserControls.Grid.MyBandedGridColumn colMeslek;
		private UserControls.Grid.MyBandedGridColumn colWeb;
		private UserControls.Grid.MyBandedGridColumn colEmail;
		private UserControls.Grid.MyBandedGridColumn colEvTelefonu1;
		private UserControls.Grid.MyBandedGridColumn colIsTelefonu1;
		private UserControls.Grid.MyBandedGridColumn colCepTelefonu1;
		private UserControls.Grid.MyBandedGridColumn colEvAdres;
		private UserControls.Grid.MyBandedGridColumn colEvAdresIlAdi;
		private UserControls.Grid.MyBandedGridColumn colEvAdresIlceAdi;
		private UserControls.Grid.MyBandedGridColumn colIsAdres;
		private UserControls.Grid.MyBandedGridColumn colIsAdresIlAdi;
		private UserControls.Grid.MyBandedGridColumn colIsAdresIlceAdi;
		private UserControls.Grid.MyBandedGridColumn colIsyeriAdi;
		private UserControls.Grid.MyBandedGridColumn colGorevAdi;
		private UserControls.Grid.MyBandedGridColumn colOzelKod1Adi;
		private UserControls.Grid.MyBandedGridColumn colOzelKod2Adi;
		private UserControls.Grid.MyBandedGridColumn colAciklama;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
	}
}