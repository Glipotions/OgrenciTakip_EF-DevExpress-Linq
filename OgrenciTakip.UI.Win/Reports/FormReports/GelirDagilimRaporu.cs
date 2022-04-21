using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using System;
using System.Linq;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class GelirDagilimRaporu : BaseRapor
    {
        public GelirDagilimRaporu()
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnKartAc };
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl1;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Odemeler = txtOdemeler;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;
            HesaplamaSekli = txtHesaplamaSekli;

            SubeKartlariYukle();
            OdemeTurleriYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            txtHesaplamaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<GruplamaTuru>());
            txtHesaplamaSekli.SelectedItem = GruplamaTuru.VadeyeGore.ToName();
            RaporTuru = KartTuru.GelirDagilimRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var odemeler = txtOdemeler.CheckedComboBoxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboBoxList<IptalDurumu>();
            var hesaplamaSekli = txtHesaplamaSekli.Text.GetEnum<GruplamaTuru>();

            using (var Business = new GelirDagilimRaporuBusiness())
            {
                tablo.GridControl.DataSource = Business.List(x =>
                  subeler.Contains(x.Tahakkuk.SubeId) &&
                  odemeler.Contains(x.OdemeTipi) &&
                  kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                  kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                  iptalDurumu.Contains(x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                  x.Tahakkuk.DonemId == AnaForm.DonemId, hesaplamaSekli);

                base.Listele();
            }
        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;
            if (item.FieldName != "colTahsilatOrani") return;

            if (e.IsGroupSummary)
            {
                var odemelerToplami = Convert.ToDecimal(tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)tablo.GroupSummary["NetOdeme"]));
                var tahsilatlarToplami = Convert.ToDecimal(tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)tablo.GroupSummary["Tahsil"]));

                e.TotalValue = odemelerToplami == 0 ? 0 : tahsilatlarToplami / odemelerToplami * 100;
            }
            else if (e.IsTotalSummary)
            {
                var odemelerToplami = Convert.ToDecimal(colNetOdeme.SummaryItem.SummaryValue);
                var tahsilatlarToplami = Convert.ToDecimal(colTahsilEdilen.SummaryItem.SummaryValue);

                e.TotalValue = odemelerToplami == 0 ? 0 : tahsilatlarToplami / odemelerToplami * 100;
            }
        }
    }
}