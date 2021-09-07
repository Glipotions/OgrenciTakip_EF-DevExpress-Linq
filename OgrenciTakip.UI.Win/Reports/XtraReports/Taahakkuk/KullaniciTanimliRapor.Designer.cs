
namespace OgrenciTakip.UI.Win.Reports.XtraReports.Taahakkuk
{
	partial class KullaniciTanimliRapor
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

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.Epos_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Geri_Odeme_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Hizmet_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Iletisim_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Indirim_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Makbuz_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Odeme_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Ogrenci_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Epos_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Geri_Odeme_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Hizmet_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Iletisim_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Indirim_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Makbuz_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Odeme_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ogrenci_Bilgileri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Name = "BottomMargin";
			// 
			// Detail
			// 
			this.Detail.Name = "Detail";
			// 
			// Epos_Bilgileri
			// 
			this.Epos_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.EposBilgileriR);
			this.Epos_Bilgileri.Name = "Epos_Bilgileri";
			// 
			// Geri_Odeme_Bilgileri
			// 
			this.Geri_Odeme_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.GeriOdemeBilgileriR);
			this.Geri_Odeme_Bilgileri.Name = "Geri_Odeme_Bilgileri";
			// 
			// Hizmet_Bilgileri
			// 
			this.Hizmet_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.HizmetBilgileriR);
			this.Hizmet_Bilgileri.Name = "Hizmet_Bilgileri";
			// 
			// Iletisim_Bilgileri
			// 
			this.Iletisim_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.IletisimBilgileriR);
			this.Iletisim_Bilgileri.Name = "Iletisim_Bilgileri";
			// 
			// Indirim_Bilgileri
			// 
			this.Indirim_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.IndirimBilgileriR);
			this.Indirim_Bilgileri.Name = "Indirim_Bilgileri";
			// 
			// Makbuz_Bilgileri
			// 
			this.Makbuz_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.MakbuzHareketleriR);
			this.Makbuz_Bilgileri.Name = "Makbuz_Bilgileri";
			// 
			// Odeme_Bilgileri
			// 
			this.Odeme_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.OdemeBilgileriR);
			this.Odeme_Bilgileri.Name = "Odeme_Bilgileri";
			// 
			// Ogrenci_Bilgileri
			// 
			this.Ogrenci_Bilgileri.DataSource = typeof(OgrenciTakip.Model.Dto.OgrenciR);
			this.Ogrenci_Bilgileri.Name = "Ogrenci_Bilgileri";
			// 
			// KullaniciTanimliR
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
			this.Baslik = "Kullanıcı Tanımlı Rapor";
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Epos_Bilgileri,
            this.Geri_Odeme_Bilgileri,
            this.Hizmet_Bilgileri,
            this.Iletisim_Bilgileri,
            this.Indirim_Bilgileri,
            this.Makbuz_Bilgileri,
            this.Odeme_Bilgileri,
            this.Ogrenci_Bilgileri});
			this.DataSource = this.Ogrenci_Bilgileri;
			this.Font = new System.Drawing.Font("Arial", 9.75F);
			this.Version = "20.2";
			((System.ComponentModel.ISupportInitialize)(this.Epos_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Geri_Odeme_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Hizmet_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Iletisim_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Indirim_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Makbuz_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Odeme_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ogrenci_Bilgileri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Epos_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Geri_Odeme_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Hizmet_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Iletisim_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Indirim_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Makbuz_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Odeme_Bilgileri;
		protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Ogrenci_Bilgileri;
	}
}
