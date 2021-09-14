using DevExpress.XtraBars;
using System.Linq;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class OdemeBelgeleriRaporu : BaseRapor
    {
        public OdemeBelgeleriRaporu()
        {
            InitializeComponent();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl1;
            Tablo = tablo;
            Navigator = longNavigator1.Navigator;
            Subeler = txtSubeler;
            Odemeler = txtOdemeler;
            BelgeDurumlari = txtBelgeDurumlari;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;

            SubeKartlariYukle();
            OdemeTurleriYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            BelgeDurumuYukle();
            RaporTuru = KartTuru.OdemeBelgeleriRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var odemeler = txtOdemeler.CheckedComboBoxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboBoxList<IptalDurumu>();
            var belgeDurumlari = txtBelgeDurumlari.CheckedComboBoxList<BelgeDurumu>();

            using (var Business = new OdemeBelgeleriRaporuBusiness())
            {
                tablo.GridControl.DataSource = Business.List(x =>
                  subeler.Contains(x.Tahakkuk.SubeId) &&
                  odemeler.Contains(x.OdemeTipi) &&
                  kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                  kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                  iptalDurumu.Contains(x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                  x.Tahakkuk.DonemId == AnaForm.DonemId, belgeDurumlari);

                base.Listele();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<OdemeBelgeleriRaporL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }

        protected override void BelgeHareketleri()
        {
            var entity = tablo.GetRow<OdemeBelgeleriRaporL>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.PortfoyNo);
        }
    }
}