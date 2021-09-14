using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Windows.Forms;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.Business.Function;
using OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
	public partial class OdemesiGecikenAlacaklarRaporu : BaseRapor
    {
        public OdemesiGecikenAlacaklarRaporu()
        {
            InitializeComponent();
            ShowItems = new BarItem[] { btnBelgeHareketleri, btnTumDetaylariGenislet, btnTumDetaylariDaralt };
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
            IlkTarih = txtIlkTarih;
            SonTarih = txtSonTarih;

            SubeKartlariYukle();
            OdemeTurleriYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            BelgeDurumuYukle();
            txtIlkTarih.DateTime = AnaForm.DonemBaslamaTarihi;
            txtSonTarih.DateTime = DateTime.Now.Date;
            RaporTuru = KartTuru.OdemesiGecikenAlacaklarRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var odemeler = txtOdemeler.CheckedComboBoxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboBoxList<IptalDurumu>();
            var belgeDurumlari = txtBelgeDurumlari.CheckedComboBoxList<BelgeDurumu>();

            using (var Business = new OdemesiGecikenAlacaklarRaporuBusiness())
            {
                tablo.GridControl.DataSource = Business.List(x =>
                  subeler.Contains(x.Tahakkuk.SubeId) &&
                  odemeler.Contains(x.OdemeTipi) &&
                  kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                  kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                  iptalDurumu.Contains(x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                  x.Vade >= txtIlkTarih.DateTime.Date &&
                  x.Vade <= txtSonTarih.DateTime.Date &&
                  x.Tahakkuk.DonemId == AnaForm.DonemId, belgeDurumlari);

                base.Listele();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<OdemesiGecikenAlacaklarRaporL>();
            if (entity == null) return;
            ShowListForms<GecikmeAciklamalariListForm>.ShowDialogListForm(KartTuru.GecikmeAciklamalari, null, entity.PortfoyNo);
        }

        protected override void BelgeHareketleri()
        {
            var entity = tablo.GetRow<OdemesiGecikenAlacaklarRaporL>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.PortfoyNo);
        }

        protected override void BelgeDurumuYukle()
        {
            var enums = Enum.GetValues(typeof(BelgeDurumu));

            foreach (BelgeDurumu entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = entity.ToName(),
                    Value = entity
                };

                if (entity == BelgeDurumu.Portfoyde ||
                    entity == BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                    entity == BelgeDurumu.KismiTahsilEdildi ||
                    entity == BelgeDurumu.BankayaTahsileGonderme ||
                    entity == BelgeDurumu.AvukataGonderme ||
                    entity == BelgeDurumu.CiroEtme ||
                    entity == BelgeDurumu.BlokeyeAlma ||
                    entity == BelgeDurumu.OnayBekliyor ||
                    entity == BelgeDurumu.PortfoyeGeriIade ||
                    entity == BelgeDurumu.PortfoyeKarsiliksizIade ||
                    entity == BelgeDurumu.TahsiliImkansizHaleGelme)

                    BelgeDurumlari.Properties.Items.Add(item);
            }
        }

        protected override void Tablo_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        protected override void Tablo_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "altGrid";
        }

        protected override void Tablo_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            // alt tablonun verilerini getiren bölüm burası
            var entity = tablo.GetRow<OdemesiGecikenAlacaklarRaporL>(e.RowHandle);
            if (entity == null) return;

            using (var Business = new GecikmeAciklamalariBusiness())
            {
                var list = Business.List(x => x.OdemeBilgileriId == entity.PortfoyNo).EntityListConvert<GecikmeAciklamalariL>().ToList();
                if (list.Any())
                    e.ChildList = list;
            }
        }
    }
}