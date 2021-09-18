using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.DonemForms
{
    public partial class DonemEditForm : BaseEditForm
    {
        public DonemEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Business = new DonemBusiness(myDataLayoutControl);
            BaseKartTuru = KartTuru.Donem;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert
                ? new Donem()
                : ((DonemBusiness)Business).Single(FilterFunctions.Filter<Donem>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((DonemBusiness)Business).YeniKodVer();
            txtDonemAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Donem)OldEntity;

            txtKod.Text = entity.Kod;
            txtDonemAdi.Text = entity.DonemAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Donem
            {
                Id = Id,
                Kod = txtKod.Text,
                DonemAdi = txtDonemAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}