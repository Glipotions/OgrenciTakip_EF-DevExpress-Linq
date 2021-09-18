﻿
namespace OgrenciTakip.UI.Win.GeneralForms
{
	partial class DonemParametreEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtSube = new OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositorySpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.DonemTarihleri = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.DonemBaslamaTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.DonemBitisTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.EgitimTarihleri = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.EgitimBaslamaTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.EgitimBitisTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.category1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GunTarihininOncesineIptalTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GunTarihininOncesineMakbuzTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GunTarihininSonrasinaIptalTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GunTarihininSonrasinaMakbuzTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.HizmetTahakkukKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.IndirimTahakkukKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.OdemePlaniKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.FaturaTahakkukKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.MaksimumTaksitTarihi = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MaksimumTaksitSayisi = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GittigiOkulZorunlu = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.YetkiKontroluAnlikYapilacak = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(505, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtSube);
            this.myDataLayoutControl1.Controls.Add(this.propertyGridControl);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(838, 320, 650, 400);
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(505, 437);
            this.myDataLayoutControl1.TabIndex = 2;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtSube
            // 
            this.txtSube.EditValue = "Lütfen Bir Şube Seçiniz.";
            this.txtSube.EnterMoveNextControl = true;
            this.txtSube.Id = null;
            this.txtSube.Location = new System.Drawing.Point(39, 12);
            this.txtSube.MenuManager = this.ribbonControl;
            this.txtSube.Name = "txtSube";
            this.txtSube.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSube.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSube.Properties.NullText = "Lütfen Bir Şube Seçiniz.";
            this.txtSube.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtSube.Size = new System.Drawing.Size(454, 20);
            this.txtSube.StatusBarAciklama = "Şube Seçiniz";
            this.txtSube.StatusBarKisayol = "F4 :";
            this.txtSube.StatusBarKisayolAciklama = "Seçim Yap";
            this.txtSube.StyleController = this.myDataLayoutControl1;
            this.txtSube.TabIndex = 7;
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.Appearance.RecordValue.Options.UseTextOptions = true;
            this.propertyGridControl.Appearance.RecordValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.propertyGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.propertyGridControl.Enabled = false;
            this.propertyGridControl.Location = new System.Drawing.Point(12, 36);
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort;
            this.propertyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryCheck,
            this.repositoryTarih,
            this.repositorySpinEdit});
            this.propertyGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category,
            this.category1,
            this.category2,
            this.category3,
            this.category4});
            this.propertyGridControl.Size = new System.Drawing.Size(481, 389);
            this.propertyGridControl.TabIndex = 6;
            this.propertyGridControl.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
            // 
            // repositoryCheck
            // 
            this.repositoryCheck.AutoHeight = false;
            this.repositoryCheck.Name = "repositoryCheck";
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
            // repositorySpinEdit
            // 
            this.repositorySpinEdit.AutoHeight = false;
            this.repositorySpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorySpinEdit.DisplayFormat.FormatString = "{0:d0}";
            this.repositorySpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositorySpinEdit.EditFormat.FormatString = "{0:d0}";
            this.repositorySpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositorySpinEdit.Mask.EditMask = "d";
            this.repositorySpinEdit.MaxValue = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.repositorySpinEdit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositorySpinEdit.Name = "repositorySpinEdit";
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.DonemTarihleri,
            this.EgitimTarihleri});
            this.category.Height = 18;
            this.category.Name = "category";
            this.category.Properties.Caption = "Dönem Tarihleri";
            // 
            // DonemTarihleri
            // 
            this.DonemTarihleri.Name = "DonemTarihleri";
            this.DonemTarihleri.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.DonemBaslamaTarihi,
            this.DonemBitisTarihi});
            // 
            // DonemBaslamaTarihi
            // 
            this.DonemBaslamaTarihi.Caption = "Dönem Başlama - Bitiş Tarihleri";
            this.DonemBaslamaTarihi.FieldName = "DonemBaslamaTarihi";
            this.DonemBaslamaTarihi.Name = "DonemBaslamaTarihi";
            this.DonemBaslamaTarihi.RowEdit = this.repositoryTarih;
            // 
            // DonemBitisTarihi
            // 
            this.DonemBitisTarihi.FieldName = "DonemBitisTarihi";
            this.DonemBitisTarihi.Name = "DonemBitisTarihi";
            this.DonemBitisTarihi.RowEdit = this.repositoryTarih;
            // 
            // EgitimTarihleri
            // 
            this.EgitimTarihleri.Name = "EgitimTarihleri";
            this.EgitimTarihleri.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.EgitimBaslamaTarihi,
            this.EgitimBitisTarihi});
            // 
            // EgitimBaslamaTarihi
            // 
            this.EgitimBaslamaTarihi.Caption = "Eğitim Başlama - Bitiş Tarihleri";
            this.EgitimBaslamaTarihi.FieldName = "EgitimBaslamaTarihi";
            this.EgitimBaslamaTarihi.Name = "EgitimBaslamaTarihi";
            this.EgitimBaslamaTarihi.RowEdit = this.repositoryTarih;
            // 
            // EgitimBitisTarihi
            // 
            this.EgitimBitisTarihi.FieldName = "EgitimBitisTarihi";
            this.EgitimBitisTarihi.Name = "EgitimBitisTarihi";
            this.EgitimBitisTarihi.RowEdit = this.repositoryTarih;
            // 
            // category1
            // 
            this.category1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir,
            this.GunTarihininOncesineIptalTarihiGirilebilir,
            this.GunTarihininOncesineMakbuzTarihiGirilebilir});
            this.category1.Name = "category1";
            this.category1.Properties.Caption = "Günün Tarihinden Öncesine Girilebilir";
            // 
            // GunTarihininOncesineHizmetBaslamaTarihiGirilebilir
            // 
            this.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir.Name = "GunTarihininOncesineHizmetBaslamaTarihiGirilebilir";
            this.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.Caption = "Hizmet Başlama Tarihi";
            this.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.FieldName = "GunTarihininOncesineHizmetBaslamaTarihiGirilebilir";
            this.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.RowEdit = this.repositoryCheck;
            // 
            // GunTarihininOncesineIptalTarihiGirilebilir
            // 
            this.GunTarihininOncesineIptalTarihiGirilebilir.Name = "GunTarihininOncesineIptalTarihiGirilebilir";
            this.GunTarihininOncesineIptalTarihiGirilebilir.Properties.Caption = "İptal Tarihi";
            this.GunTarihininOncesineIptalTarihiGirilebilir.Properties.FieldName = "GunTarihininOncesineIptalTarihiGirilebilir";
            this.GunTarihininOncesineIptalTarihiGirilebilir.Properties.RowEdit = this.repositoryCheck;
            // 
            // GunTarihininOncesineMakbuzTarihiGirilebilir
            // 
            this.GunTarihininOncesineMakbuzTarihiGirilebilir.Name = "GunTarihininOncesineMakbuzTarihiGirilebilir";
            this.GunTarihininOncesineMakbuzTarihiGirilebilir.Properties.Caption = "Makbuz Tarihi";
            this.GunTarihininOncesineMakbuzTarihiGirilebilir.Properties.FieldName = "GunTarihininOncesineMakbuzTarihiGirilebilir";
            this.GunTarihininOncesineMakbuzTarihiGirilebilir.Properties.RowEdit = this.repositoryCheck;
            // 
            // category2
            // 
            this.category2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir,
            this.GunTarihininSonrasinaIptalTarihiGirilebilir,
            this.GunTarihininSonrasinaMakbuzTarihiGirilebilir});
            this.category2.Name = "category2";
            this.category2.Properties.Caption = "Günün Tarihinden Sonrasına Girilebilir";
            // 
            // GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir
            // 
            this.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Name = "GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir";
            this.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.Caption = "Hizmet Başlama Tarihi";
            this.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.FieldName = "GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir";
            this.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.RowEdit = this.repositoryCheck;
            // 
            // GunTarihininSonrasinaIptalTarihiGirilebilir
            // 
            this.GunTarihininSonrasinaIptalTarihiGirilebilir.Name = "GunTarihininSonrasinaIptalTarihiGirilebilir";
            this.GunTarihininSonrasinaIptalTarihiGirilebilir.Properties.Caption = "İptal Tarihi";
            this.GunTarihininSonrasinaIptalTarihiGirilebilir.Properties.FieldName = "GunTarihininSonrasinaIptalTarihiGirilebilir";
            this.GunTarihininSonrasinaIptalTarihiGirilebilir.Properties.RowEdit = this.repositoryCheck;
            // 
            // GunTarihininSonrasinaMakbuzTarihiGirilebilir
            // 
            this.GunTarihininSonrasinaMakbuzTarihiGirilebilir.Name = "GunTarihininSonrasinaMakbuzTarihiGirilebilir";
            this.GunTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.Caption = "Makbuz Tarihi";
            this.GunTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.FieldName = "GunTarihininSonrasinaMakbuzTarihiGirilebilir";
            this.GunTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.RowEdit = this.repositoryCheck;
            // 
            // category3
            // 
            this.category3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.HizmetTahakkukKurusKullan,
            this.IndirimTahakkukKurusKullan,
            this.OdemePlaniKurusKullan,
            this.FaturaTahakkukKurusKullan});
            this.category3.Name = "category3";
            this.category3.Properties.Caption = "Kuruş Kullan";
            // 
            // HizmetTahakkukKurusKullan
            // 
            this.HizmetTahakkukKurusKullan.Name = "HizmetTahakkukKurusKullan";
            this.HizmetTahakkukKurusKullan.Properties.Caption = "Hizmet Bilgileri";
            this.HizmetTahakkukKurusKullan.Properties.FieldName = "HizmetTahakkukKurusKullan";
            this.HizmetTahakkukKurusKullan.Properties.RowEdit = this.repositoryCheck;
            // 
            // IndirimTahakkukKurusKullan
            // 
            this.IndirimTahakkukKurusKullan.Name = "IndirimTahakkukKurusKullan";
            this.IndirimTahakkukKurusKullan.Properties.Caption = "İndirim Bilgileri";
            this.IndirimTahakkukKurusKullan.Properties.FieldName = "IndirimTahakkukKurusKullan";
            this.IndirimTahakkukKurusKullan.Properties.RowEdit = this.repositoryCheck;
            // 
            // OdemePlaniKurusKullan
            // 
            this.OdemePlaniKurusKullan.Name = "OdemePlaniKurusKullan";
            this.OdemePlaniKurusKullan.Properties.Caption = "Ödeme Bilgileri";
            this.OdemePlaniKurusKullan.Properties.FieldName = "OdemePlaniKurusKullan";
            this.OdemePlaniKurusKullan.Properties.RowEdit = this.repositoryCheck;
            // 
            // FaturaTahakkukKurusKullan
            // 
            this.FaturaTahakkukKurusKullan.Name = "FaturaTahakkukKurusKullan";
            this.FaturaTahakkukKurusKullan.Properties.Caption = "Fatura Bilgileri";
            this.FaturaTahakkukKurusKullan.Properties.FieldName = "FaturaTahakkukKurusKullan";
            this.FaturaTahakkukKurusKullan.Properties.RowEdit = this.repositoryCheck;
            // 
            // category4
            // 
            this.category4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.MaksimumTaksitTarihi,
            this.MaksimumTaksitSayisi,
            this.GittigiOkulZorunlu,
            this.YetkiKontroluAnlikYapilacak});
            this.category4.Name = "category4";
            this.category4.Properties.Caption = "Diğer Parametreler";
            // 
            // MaksimumTaksitTarihi
            // 
            this.MaksimumTaksitTarihi.Appearance.Options.UseTextOptions = true;
            this.MaksimumTaksitTarihi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaksimumTaksitTarihi.Name = "MaksimumTaksitTarihi";
            this.MaksimumTaksitTarihi.Properties.Caption = "Maksimum Taksit Tarihi";
            this.MaksimumTaksitTarihi.Properties.FieldName = "MaksimumTaksitTarihi";
            this.MaksimumTaksitTarihi.Properties.RowEdit = this.repositoryTarih;
            // 
            // MaksimumTaksitSayisi
            // 
            this.MaksimumTaksitSayisi.Appearance.Options.UseTextOptions = true;
            this.MaksimumTaksitSayisi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaksimumTaksitSayisi.Name = "MaksimumTaksitSayisi";
            this.MaksimumTaksitSayisi.Properties.Caption = "Maksimum Taksit Sayısı";
            this.MaksimumTaksitSayisi.Properties.FieldName = "MaksimumTaksitSayisi";
            this.MaksimumTaksitSayisi.Properties.RowEdit = this.repositorySpinEdit;
            // 
            // GittigiOkulZorunlu
            // 
            this.GittigiOkulZorunlu.Name = "GittigiOkulZorunlu";
            this.GittigiOkulZorunlu.Properties.Caption = "Gittiği Okulun Seçilmesi Zorunlu";
            this.GittigiOkulZorunlu.Properties.FieldName = "GittigiOkulZorunlu";
            this.GittigiOkulZorunlu.Properties.RowEdit = this.repositoryCheck;
            // 
            // YetkiKontroluAnlikYapilacak
            // 
            this.YetkiKontroluAnlikYapilacak.Name = "YetkiKontroluAnlikYapilacak";
            this.YetkiKontroluAnlikYapilacak.Properties.Caption = "Kullanıcı Yetki Kontrolü Anlık Yapılsın";
            this.YetkiKontroluAnlikYapilacak.Properties.FieldName = "YetkiKontroluAnlikYapilacak";
            this.YetkiKontroluAnlikYapilacak.Properties.RowEdit = this.repositoryCheck;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(505, 437);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.propertyGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(485, 393);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtSube;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(485, 24);
            this.layoutControlItem2.Text = "Şube";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(24, 13);
            // 
            // DonemParametreEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 570);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Name = "DonemParametreEditForm";
            this.Text = "Dönem Parametreleri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositorySpinEdit;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow DonemTarihleri;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties DonemBaslamaTarihi;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties DonemBitisTarihi;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow EgitimTarihleri;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties EgitimBaslamaTarihi;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties EgitimBitisTarihi;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GunTarihininOncesineHizmetBaslamaTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GunTarihininOncesineIptalTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GunTarihininOncesineMakbuzTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GunTarihininSonrasinaIptalTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GunTarihininSonrasinaMakbuzTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow HizmetTahakkukKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow IndirimTahakkukKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow OdemePlaniKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow FaturaTahakkukKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MaksimumTaksitTarihi;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MaksimumTaksitSayisi;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GittigiOkulZorunlu;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow YetkiKontroluAnlikYapilacak;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UserControls.Controls.MyButtonEdit txtSube;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}