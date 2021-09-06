using OgrenciTakip.Business.General;
using OgrenciYazilim.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.RaporForms
{
    public partial class RaporEditForm : BaseEditForm
    {
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;

        public RaporEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Business = new RaporBusiness(myDataLayoutControl);
            BaseKartTuru = KartTuru.Rapor;
            EventsLoad();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rapor() : ((RaporBusiness)Business).Single(FilterFunctions.Filter<Rapor>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RaporBusiness)Business).YeniKodVer(x => x.RaporBolumTuru == _raporBolumTuru && x.RaporTuru == _raporTuru);
            txtRaporAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rapor)OldEntity;

            txtKod.Text = entity.Kod;
            txtRaporAdi.Text = entity.RaporAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Rapor
            {
                Id = Id,
                Kod = txtKod.Text,
                RaporAdi = txtRaporAdi.Text,
                RaporTuru = _raporTuru,
                RaporBolumTuru = _raporBolumTuru,
                Dosya = _dosya,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((RaporBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RaporBolumTuru == _raporBolumTuru && x.RaporTuru == _raporTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((RaporBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RaporBolumTuru == _raporBolumTuru && x.RaporTuru == _raporTuru);
        }
    }
}