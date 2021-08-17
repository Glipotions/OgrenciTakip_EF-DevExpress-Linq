using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciYazilim.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.KasaForms
{
    public partial class KasaEditForm : BaseEditForm
    {
        public KasaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Business = new KasaBusiness(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kasa;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KasaS() : ((KasaBusiness)Business).Single(FilterFunctions.Filter<Kasa>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KasaBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtKasaAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KasaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtKasaAdi.Text = entity.KasaAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kasa
            {
                Id = Id,
                Kod = txtKod.Text,
                KasaAdi = txtKasaAdi.Text,
                OzelKod1Id = txtOzelKod1.Id,//nullable veri kabul ettiği için convert gerek yok
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((KasaBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((KasaBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Kasa);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Kasa);
            }
        }
    }
}