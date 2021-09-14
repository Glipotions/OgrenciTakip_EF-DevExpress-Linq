using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using System;
using System.Linq;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class MesleklereGoreKayitRaporu : BaseRapor
    {
        public MesleklereGoreKayitRaporu()
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnKartAc };
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl1;
            Tablo = tablo;
            Navigator = longNavigator1.Navigator;
            Subeler = txtSubeler;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            RaporTuru = KartTuru.MesleklereGoreKayitRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboBoxList<IptalDurumu>();

            using (var Business = new MesleklereGoreKayitRaporuBusiness())
            {
                tablo.GridControl.DataSource = Business.List(x =>
                  subeler.Contains(x.SubeId) &&
                  kayitSekli.Contains(x.KayitSekli) &&
                  kayitDurumu.Contains(x.KayitDurumu) &&
                  iptalDurumu.Contains(x.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                  x.DonemId == AnaForm.DonemId);

                base.Listele();
            }
        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;
            if (item.FieldName == "colIndirimOrani")
            {
                if (e.IsGroupSummary)
                {
                    var hizmetlerToplami = Convert.ToDecimal(tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)tablo.GroupSummary["NetHizmet"]));
                    var indirimlerToplami = Convert.ToDecimal(tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)tablo.GroupSummary["NetIndirim"]));

                    e.TotalValue = hizmetlerToplami == 0 ? 0 : indirimlerToplami / hizmetlerToplami * 100;
                }
                else if (e.IsTotalSummary)
                {
                    var hizmetlerToplami = Convert.ToDecimal(colNetHizmet.SummaryItem.SummaryValue);
                    var indirimlerToplamı = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);

                    e.TotalValue = hizmetlerToplami == 0 ? 0 : indirimlerToplamı / hizmetlerToplami * 100;
                }
            }

            if (item.FieldName != "colOrtalama") return;
            {
                if (e.IsGroupSummary)
                {
                    var toplamKayit = Convert.ToDecimal(tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)tablo.GroupSummary["ToplamKayit"]));
                    var netUcret = Convert.ToDecimal(tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)tablo.GroupSummary["NetUcret"]));

                    e.TotalValue = toplamKayit == 0 ? 0 : netUcret / toplamKayit;
                }
                else if (e.IsTotalSummary)
                {
                    var toplamKayit = Convert.ToDecimal(colToplamKayit.SummaryItem.SummaryValue);
                    var netUcret = Convert.ToDecimal(colNetUcret.SummaryItem.SummaryValue);

                    e.TotalValue = toplamKayit == 0 ? 0 : netUcret / toplamKayit;
                }
            }
        }
    }
}