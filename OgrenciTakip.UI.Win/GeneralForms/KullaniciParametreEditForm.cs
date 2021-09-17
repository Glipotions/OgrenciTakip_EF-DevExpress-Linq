using System;
using DevExpress.XtraBars;
using System.Drawing;
using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class KullaniciParametreEditForm : BaseEditForm
    {
        private readonly long _kullaniciId;

        public KullaniciParametreEditForm(params object[] prm)
        {
            InitializeComponent();

            _kullaniciId = (long)prm[0];
            DataLayoutControl = myDataLayoutControl1;
            Business = new KullaniciParametreBusiness();
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = ((KullaniciParametreBusiness)Business).Single(x => x.KullaniciId == _kullaniciId) ?? new KullaniciParametreS();
            //kullanıci parametreleri vt de yoksa new KullaniciParametreS() yap
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciParametreS)OldEntity;

            Id = entity.Id;
            txtVarsayilanAvukatHesap.Id = entity.DefaultAvukatHesapId;
            txtVarsayilanBankaHesap.Text = entity.DefaultBankaHesapAdi;
            txtVarsayilanBankaHesap.Id = entity.DefaultBankaHesapId;
            txtVarsayilanAvukatHesap.Text = entity.DefaultBankaHesapAdi;
            txtVarsayilanKasaHesap.Id = entity.DefaultKasaHesapId;
            txtVarsayilanKasaHesap.Text = entity.DefaultKasaHesapAdi;
            txtRaporlariOnayAlmadanKapat.Checked = entity.RaporlariOnayAlmadanKapat;
            txtTableViewCaptionForeColor.Color = Color.FromArgb(entity.TableViewCaptionForeColor); //RGB den Renge çevirme kısmı. normalde bu rgb kodu int olarak geliyor Color a çeviriyoruz
            txtTableColumnHeaderForeColor.Color = Color.FromArgb(entity.TableColumnHeaderForeColor);
            txtTableBandPanelForeColor.Color = Color.FromArgb(entity.TableBandPanelForeColor);
            imgArkaPlanResim.EditValue = entity.ArkaPlanResim;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KullaniciParametre
            {
                Id = Id,
                Kod = "Params-0001", //is unique false olduğu için çakışma olmaz
                KullaniciId = AnaForm.KullaniciId,
                DefaultAvukatHesapId = txtVarsayilanAvukatHesap.Id,
                DefaultBankaHesapId = txtVarsayilanBankaHesap.Id,
                DefaultKasaHesapId = txtVarsayilanKasaHesap.Id,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtTableBandPanelForeColor.Color.ToArgb(),
                ArkaPlanResim = (byte[])imgArkaPlanResim.EditValue
            };

            ButtonEnabledDurumu();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            // ana forma gönderme işlemleri
            var entity = new KullaniciParametreS
            {
                DefaultAvukatHesapId = txtVarsayilanAvukatHesap.Id,
                DefaultAvukatHesapAdi = txtVarsayilanAvukatHesap.Text,
                DefaultBankaHesapId = txtVarsayilanBankaHesap.Id,
                DefaultBankaHesapAdi = txtVarsayilanBankaHesap.Text,
                DefaultKasaHesapId = txtVarsayilanKasaHesap.Id,
                DefaultKasaHesapAdi = txtVarsayilanKasaHesap.Text,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtTableBandPanelForeColor.Color.ToArgb(),
                ArkaPlanResim = (byte[])imgArkaPlanResim.EditValue
            };

            return entity;
        }

        protected override bool EntityInsert()
        {
            // override etmemizin sebebi değişiklik yapılmadığında ana forma gönderilmemesi için override edilir.
            var result = base.EntityInsert();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override bool EntityUpdate()
        {
            // override etmemizin sebebi değişiklik yapılmadığında ana forma gönderilmemesi için override edilir.
            var result = base.EntityUpdate();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtVarsayilanAvukatHesap)
                    sec.Sec(txtVarsayilanAvukatHesap);

                else if (sender == txtVarsayilanBankaHesap)
                    sec.Sec(txtVarsayilanBankaHesap);

                else if (sender == txtVarsayilanKasaHesap)
                    sec.Sec(txtVarsayilanKasaHesap);
            }
        }
    }
}