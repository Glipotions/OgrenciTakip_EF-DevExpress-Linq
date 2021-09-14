using System;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariEditForm : BaseEditForm
    {
        private readonly int _portfoyNo;  //OdemeBilgileriId  aynıdır

        public GecikmeAciklamalariEditForm(params object[] prm)
        {
            InitializeComponent();

            _portfoyNo = (int)prm[0];

            DataLayoutControl = myDataLayoutControl1;
            Business = new GecikmeAciklamalariBusiness(myDataLayoutControl1);
            BaseKartTuru = KartTuru.GecikmeAciklamalari;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new GecikmeAciklamalariS() : ((GecikmeAciklamalariBusiness)Business).Single(FilterFunctions.Filter<GecikmeAciklamalari>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((GecikmeAciklamalariBusiness)Business).YeniKodVer(x => x.OdemeBilgileriId == _portfoyNo);
            txtAciklama.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (GecikmeAciklamalariS)OldEntity;

            txtKod.Text = entity.Kod;
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciAdi : entity.KullaniciAdi;
            txtTarihSaat.DateTime = BaseIslemTuru == IslemTuru.EntityInsert ? DateTime.Now : entity.TarihSaat;
            txtAciklama.Text = entity.Aciklama;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new GecikmeAciklamalari
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeBilgileriId = _portfoyNo,
                KullaniciId = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciId : 0,
                TarihSaat = txtTarihSaat.DateTime,
                Aciklama = txtAciklama.Text
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((GecikmeAciklamalariBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.OdemeBilgileriId == _portfoyNo);
        }

        protected override bool EntityUpdate()
        {
            return ((GecikmeAciklamalariBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.OdemeBilgileriId == _portfoyNo);
        }
    }
}