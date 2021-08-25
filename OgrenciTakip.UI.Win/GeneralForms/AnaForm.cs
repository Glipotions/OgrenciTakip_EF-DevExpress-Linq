using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Forms.AvukatForms;
using OgrenciTakip.UI.Win.Forms.BankaForms;
using OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OgrenciTakip.UI.Win.Forms.CariForms;
using OgrenciTakip.UI.Win.Forms.EvrakForms;
using OgrenciTakip.UI.Win.Forms.GorevForms;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using OgrenciTakip.UI.Win.Forms.IletisimForms;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms.IndirimForms;
using OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakip.UI.Win.Forms.IsyeriForms;
using OgrenciTakip.UI.Win.Forms.KasaForms;
using OgrenciTakip.UI.Win.Forms.KontenjanForms;
using OgrenciTakip.UI.Win.Forms.MeslekForms;
using OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using OgrenciTakip.UI.Win.Forms.OgrenciForms;
using OgrenciTakip.UI.Win.Forms.OkulForms;
using OgrenciTakip.UI.Win.Forms.PromosyonForms;
using OgrenciTakip.UI.Win.Forms.RehberForms;
using OgrenciTakip.UI.Win.Forms.ServisForms;
using OgrenciTakip.UI.Win.Forms.SinifForms;
using OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Forms.TesvikForms;
using OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using System;

namespace OgrenciTakip.UI.Win.GeneralForms
{
	public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public static long DonemId = 1;
		public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
		public static long SubeId = 1;
		public static string SubeAdi = "Şube Bilgisi Bekleniyor...";

		public static DateTime EgitimBaslamaTarihi = new DateTime(2017, 09, 15);
		public static DateTime DonemBitisTarihi = new DateTime(2018, 6, 30);
		public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = false;
		public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = false;

		public AnaForm()
		{
			InitializeComponent();
			EventsLoad();
		}

		private void EventsLoad()
		{
			foreach (var item in ribbonControl.Items)
			{
				switch (item)
				{
					case BarButtonItem btn:
						btn.ItemClick += Butonlar_ItemClick;
						break;
				}
			}
		}

		private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (e.Item == btnOkulKartlari)
				ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
			else if (e.Item == btnIlKartlari)
				ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
			else if (e.Item == btnAileBilgiKartlari)
				ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
			else if (e.Item == btnIptalNedeniKartlari)
				ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
			else if (e.Item == btnYabanciDilKartlari)
				ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
			else if (e.Item == btnTesvikKartlari)
				ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
			else if (e.Item == btnKontenjanKartlari)
				ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
			else if (e.Item == btnRehberKartlari)
				ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
			else if (e.Item == btnSinifGrupKartlari)
				ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
			else if (e.Item == btnMeslekKartlari)
				ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
			else if (e.Item == btnYakinlikKartlari)
				ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
			else if (e.Item == btnIsyeriKartlari)
				ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
			else if (e.Item == btnGorevKartlari)
				ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
			else if (e.Item == btnIndirimTuruKartlari)
				ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
			else if (e.Item == btnEvrakKartlari)
				ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
			else if (e.Item == btnPromosyonKartlari)
				ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
			else if (e.Item == btnServisKartlari)
				ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
			else if (e.Item == btnSinifKartlari)
				ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
			else if (e.Item == btnHizmetTuruKartlari)
				ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
			else if (e.Item == btnHizmetKartlari)
				ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
			else if (e.Item == btnKasaKartlari)
				ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
			else if (e.Item == btnBankaKartlari)
				ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
			else if (e.Item == btnAvukatKartlari)
				ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
			else if (e.Item == btnCariKartlari)
				ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
			else if (e.Item == btnOdemeTuruKartlari)
				ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
			else if (e.Item == btnBankaHesapKartlari)
				ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
			else if (e.Item == btnIletisimKartlari)
				ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
			else if (e.Item == btnOgrenciKartlari)
				ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
			else if (e.Item == btnIndirimKartlari)
				ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
			else if (e.Item == btnTahakukKartlari)
				ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
		}
	}
}