using DevExpress.XtraEditors;
using System;
using OgrenciTakip.Business.General;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Business = new BankaHesapBusiness(myDataLayoutControl);
            BaseKartTuru = KartTuru.BankaHesap;
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaHesapS() : ((BankaHesapBusiness)Business).Single(FilterFunctions.Filter<BankaHesap>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();//toname önemli
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdı;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsyeriNo.Text = entity.IsyeriNo;
            txtTerminalNo.Text = entity.TerminalNo;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcılısTarihi;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),//önemli
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                BlokeGunSayisi = (byte)txtBlokeGunSayisi.Value,
                IsyeriNo = txtIsyeriNo.Text,
                TerminalNo = txtTerminalNo.Text,
                HesapAcılısTarihi = txtHesapAcilisTarihi.DateTime.Date,
                HesapNo = txtHesapNo.Text,
                IbanNo = txtIbanNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((BankaHesapBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaHesapBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
            }
        }

        //bankayı silice banka subelerinide silmesi için gereken kodlar
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            //bankayı silice banka subelerinide silmesi için gereken kodlar
            if (sender != txtBanka) return;
            txtBanka.ControlEnableChanged(txtBankaSube);
        }

        //vadeli hesap vs seçince bloke gün sayısını devre dışı bırakacak
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            //vadeli hesap vs seçince bloke gün sayısını devre dışı bırakacak
            if (!(sender is ComboBoxEdit edt)) return;

            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();

            if (hesapTuru == BankaHesapTuru.EposBlokeHesabi || hesapTuru == BankaHesapTuru.OtsBlokeHesabi || hesapTuru == BankaHesapTuru.PosBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtIsyeriNo.Enabled = true;
                txtTerminalNo.Enabled = true;
            }
            else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtIsyeriNo.Enabled = false;
                txtTerminalNo.Enabled = false;

                txtBlokeGunSayisi.Value = 0;
                txtIsyeriNo.Text = null;
                txtTerminalNo.Text = null;
            }
        }
    }
}