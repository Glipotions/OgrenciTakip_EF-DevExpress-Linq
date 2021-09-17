using System;
using System.Security;
using DevExpress.XtraEditors;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.Functions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Yonetim.Forms.GenelForms
{
    public partial class KurumEditForm : BaseEditForm
    {
        #region Veriables

        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private readonly YetkilendirmeTuru _yetkilendirmeTuru;

        #endregion

        public KurumEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl1;
            Business = new KurumBusiness(myDataLayoutControl1);
            BaseKartTuru = KartTuru.Kurum;
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            txtYetkilendirmeTuru.SelectedItem = _yetkilendirmeTuru.ToName();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert
                ? new Kurum()
                : ((KurumBusiness)Business).Single(FilterFunctions.Filter<Kurum>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = "Yeni_Kurum";
            txtKod.Enabled = true;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kurum)OldEntity;

            txtKod.Text = entity.Kod;
            txtKurumAdi.Text = entity.KurumAdi;
            txtServer.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _server : entity.Server;
            txtYetkilendirmeTuru.SelectedItem = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert
                ? _kullaniciAdi.ConvertToUnSecureString()
                : entity.KullaniciAdi.Decrypt(entity.Id + entity.Kod);
            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert
                ? _sifre.ConvertToUnSecureString()
                : entity.Sifre.Decrypt(entity.Id + entity.Kod);
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kurum
            {
                Id = Id,
                Kod = txtKod.Text,
                KurumAdi = txtKurumAdi.Text,
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
            };

            //Bu kısmı Current Entity dışına almamızın nedeni CurrentEntity den Id çekmek için tamamlanması gerekiyor. İçerde yaparsak null gelirdi.
            ((Kurum)CurrentEntity).KullaniciAdi = txtKullaniciAdi.Text.Encrypt(CurrentEntity.Id + CurrentEntity.Kod);
            ((Kurum)CurrentEntity).Sifre = txtSifre.Text.Encrypt(CurrentEntity.Id + CurrentEntity.Kod);

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text,
                txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(),
                txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>()))
                return false;

            Win.Functions.GeneralFunctions.CreateConnectionString(txtKod.Text, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            if (!Functions.GeneralFunctions.CreateDatabase<OgrenciTakipContext>("Lütfen Bekleyiniz.",
                "Kurum Veritabanı Oluşturuluyor.", "Kurum Veritabanı Oluşturulacaktır Onaylıyor musunuz?",
                "Kurum Veritabanı Başarılı Bir Şekilde Olşturuldu")) return false;

            Win.Functions.GeneralFunctions.CreateConnectionString("OgrenciTakip_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            return base.EntityInsert();
        }

        protected override bool EntityUpdate()
        {
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text,
                txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(),
                txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>()))
                return false;

            Win.Functions.GeneralFunctions.CreateConnectionString("OgrenciTakip_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());
            return base.EntityUpdate();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }
    }
}