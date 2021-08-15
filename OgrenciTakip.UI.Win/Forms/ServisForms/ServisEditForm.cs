using OgrenciTakip.Business.General;
using OgrenciYazilim.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl1;
            Business = new ServisBusiness(myDataLayoutControl1);
            BaseKartTuru = KartTuru.Servis;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Servis() : ((ServisBusiness)Business).Single(FilterFunctions.Filter<Servis>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ServisBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeri.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Servis)OldEntity;

            txtKod.Text = entity.Kod;
            txtServisYeri.Text = entity.ServisYeri;
            txtUcret.Value = entity.Ucret; //sayısal değer atanacağı için value'ya atanır
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Servis
            {
                Id = Id,
                Kod = txtKod.Text,
                ServisYeri = txtServisYeri.Text,
                Ucret = txtUcret.Value,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((ServisBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((ServisBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}