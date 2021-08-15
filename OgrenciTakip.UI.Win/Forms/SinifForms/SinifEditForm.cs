using DevExpress.XtraEditors;
using System;
using OgrenciTakip.Business.General;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifEditForm : BaseEditForm
    {
        public SinifEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Business = new SinifBusiness(myDataLayoutControl);
            BaseKartTuru = KartTuru.Sinif;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinifS() : ((SinifBusiness)Business).Single(FilterFunctions.Filter<Sinif>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinifBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtSinifAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinifS)OldEntity;

            txtKod.Text = entity.Kod;
            txtSinifAdi.Text = entity.SinifAdi;
            txtGrup.Id = entity.GrupId;
            txtGrup.Text = entity.GrupAdi;
            txtHedefOgrenciSayisi.Value = entity.HedefOgrenciSayisi;
            txtHedefCiro.Value = entity.HedefCiro;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sinif
            {
                Id = Id,
                Kod = txtKod.Text,
                SinifAdi = txtSinifAdi.Text,
                GrupId = Convert.ToInt64(txtGrup.Id),//convert kullanılmazsa ctrl del ile içerik silinince hata alınır
                HedefOgrenciSayisi = (int)txtHedefOgrenciSayisi.Value,
                HedefCiro = txtHedefCiro.Value,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((SinifBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((SinifBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtGrup)
                    sec.Sec(txtGrup);
            }
        }
    }
}