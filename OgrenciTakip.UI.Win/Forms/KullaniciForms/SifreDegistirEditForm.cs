using System.Windows.Forms;
using DevExpress.XtraBars;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.Functions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class SifreDegistirEditForm : BaseEditForm
    {
        public SifreDegistirEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl1;
            Business = new KullaniciBusiness(myDataLayoutControl1);
            HideItems = new BarItem[] { btnYeni, btnGeriAl, btnSil };
            EventsLoad();
        }

        private void SifreDegistir()
        {
            if (Messages.KayitMesaj() != DialogResult.Yes) return;

            var entity = ((KullaniciBusiness)Business).SingleDetail(x => x.Id == AnaForm.KullaniciId).EntityConvert<Kullanici>();
            if (entity == null) return;

            if (HataliGiris()) return;

            if (entity.Sifre == txtEskiSifre.Text.Md5Sifrele())
            {
                var currentEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    RolId = entity.RolId,
                    Sifre = txtYeniSifre.Text.Md5Sifrele(),
                    GizliKelime = string.IsNullOrEmpty(txtGizliKelime.Text) ? entity.GizliKelime : txtGizliKelime.Text.Md5Sifrele(),
                    Aciklama = entity.Aciklama,
                    Durum = entity.Durum,
                    Email = entity.Email
                };

                if (!((KullaniciBusiness)Business).Update(entity, currentEntity)) return;
                Messages.BilgiMesaji("Şifreniz Başarılı Bir Şekilde Değiştirilmiştir.");
                //btnKaydet.Enabled = false; //eğer form closin event'ını override etmezsek buda işimizi görür
                Close();
            }

            else
            {
                Messages.HataMesaji("Girilen Eski Şifre Bilgisi Hatalıdır. Lütfen Kontrol Edip Tekrar Deneyiniz.");
                txtEskiSifre.Focus();
            }
        }

        private bool HataliGiris()
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                Messages.HataMesaji("Girilen Yeni Şifre, Yeni Şifre Tekrar İle Uyuşmuyor");
                txtYeniSifre.Focus();
                return true;
            }

            if (txtYeniSifre.Text.Length < 8)
            {
                Messages.HataMesaji("Girilen Yeni Şifrenin Uzunluğu En Az 8 Karakter Olmalıdır.");
                txtYeniSifre.Focus();
                return true;
            }

            if (!string.IsNullOrEmpty(txtGizliKelime.Text) && txtGizliKelime.Text.Length < 10)
            {
                Messages.HataMesaji("Girilen Gizli Kelimenin Uzunluğu En Az 10 Karakter Olmalıdır.");
                txtGizliKelime.Focus();
                return true;
            }

            return false;
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnKaydet)
                SifreDegistir();
            else if (e.Item == btnCikis)
                Close();
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }
    }
}