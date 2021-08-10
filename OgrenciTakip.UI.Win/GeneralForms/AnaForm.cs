using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Forms.GorevForms;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakip.UI.Win.Forms.IsyeriForms;
using OgrenciTakip.UI.Win.Forms.KontenjanForms;
using OgrenciTakip.UI.Win.Forms.MeslekForms;
using OgrenciTakip.UI.Win.Forms.OkulForms;
using OgrenciTakip.UI.Win.Forms.RehberForms;
using OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OgrenciTakip.UI.Win.Forms.TesvikForms;
using OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.GeneralForms
{
	public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
		public static string SubeAdi = "Şube Bilgisi Bekleniyor...";

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


		}
	}
}