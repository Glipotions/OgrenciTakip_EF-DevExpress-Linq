using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using OgrenciTakip.Business.Functions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciTakip.Business.Function;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class GirisForm : XtraForm
    {
        private Point _mouseLocation;
        private List<Kurum> _source;

        public GirisForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            //Control events
            foreach (Control control in Controls)
            {
                if (!(control is MyDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in control.Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;

                    switch (ctrl)
                    {
                        case MySimpleButton btn:
                            btn.Click += Btn_Click;
                            break;

                        case MyHyperlinkLabelControl hyp:
                            hyp.Click += Btn_Click;
                            break;
                    }
                }
            }

            //Form events
            Shown += GirisForm_Shown;
            Load += GirisForm_Load;
        }

        private void Yukle()
        {
            txtVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

            var server = ConfigurationManager.AppSettings["Server"];
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString();
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru, true))
            {
                txtKurum.Properties.DataSource = null;
				if (ShowEditForms<BaglantiAyarlariEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
					Yukle();
				return;
            }

            Functions.GeneralFunctions.CreateConnectionString("OgrenciTakip_Yonetim", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var Business = new KurumBusiness())
            {
                _source = Business.List(null).Cast<Kurum>().ToList();

                txtKurum.Properties.DataSource = _source;
                txtKurum.Properties.ValueMember = "Kod";
                txtKurum.Properties.DisplayMember = "KurumAdi";
                txtKurum.ItemIndex = 0;
            }
        }

        private void CreateConnection()
        {
            if (txtKurum.Text == "")
            {
                Messages.HataMesaji("Kurum Seçimi Yapmalısınız");
                txtKurum.Focus();
                return;
            }

            var kurum = _source[txtKurum.ItemIndex];  //seçtiğimiz kurumun index ile kurumu alıyoruz
            var kod = kurum.Kod;
            var server = kurum.Server;
            var yetkilendirmeTuru = kurum.YetkilendirmeTuru;
            var kullaniciAdi = kurum.KullaniciAdi.Decrypt(kurum.Id + kurum.Kod).ConvertToSecureString();
            var sifre = kurum.Sifre.Decrypt(kurum.Id + kurum.Kod).ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru)) return;

            //Seçtiğimiz Servera bağlanma kısmı -> kod yazan yer bağlanacağımız server olacak
            Functions.GeneralFunctions.CreateConnectionString(kod, server, kullaniciAdi, sifre, yetkilendirmeTuru);
        }

        private void Giris()
        {
            CreateConnection();

            using (var kullaniciBusiness = new KullaniciBusiness())
            {
                var kullanici = (KullaniciS)kullaniciBusiness.SingleDetail(x => x.Kod == txtKullaniciAdi.Text);

                if (kullanici == null || txtSifre.Text.Md5Sifrele() != kullanici.Sifre)
                {
                    Messages.HataMesaji("Kullanıcı Adı veya Şifreniz Hatalıdır.");
                    txtKullaniciAdi.Focus();
                    return;
                }

                if (!kullanici.Durum)
                {
                    Messages.HataMesaji("Pasif Durumdaki Kullanıcı ile Giriş Yapamazsınız.");
                    txtKullaniciAdi.Focus();
                    return;
                }

                using (var kullaniciParametreBusiness = new KullaniciParametreBusiness())
                {
                    var entity = (KullaniciParametreS)kullaniciParametreBusiness.Single(x => x.KullaniciId == kullanici.Id);
                    AnaForm.KullaniciParametreleri = entity ?? new KullaniciParametreS();  //entity dolu geliyorsa onu al null işe new yap

					AnaForm.KurumAdi = txtKurum.Text;
					AnaForm.KullaniciId = kullanici.Id;
					AnaForm.KullaniciAdi = kullanici.Adi;
					AnaForm.KullaniciRolId = kullanici.RolId;
					AnaForm.KullaniciRolAdi = kullanici.RolAdi;

					Hide();
                    ShowRibbonForms<AnaForm>.ShowForm(false);
                }
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var position = MousePosition;
            position.Offset(_mouseLocation.X, _mouseLocation.Y);
            Location = position;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            switch (sender)
            {
                case MySimpleButton btn:
                    if (btn == btnGiris)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        Giris();

                        Cursor.Current = Cursors.Default;
                    }
                    else if (btn == btnVazgec)
                        Close();
                    break;

				case MyHyperlinkLabelControl hyp:
					if (hyp == btnBaglantiAyarlari)
					{
						if (ShowEditForms<BaglantiAyarlariEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
							Yukle();
					}
					else if (hyp == btnSifremiUnuttum)
					{
						CreateConnection();
						ShowEditForms<SifremiUnuttumEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate, txtKullaniciAdi.Text);
					}
					break;
			}
        }

        private void GirisForm_Shown(object sender, System.EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void GirisForm_Load(object sender, System.EventArgs e)
        {
			SplashScreenManager.ShowForm(typeof(Baslatiliyor));
			Yukle();
            SplashScreenManager.CloseForm();
        }
    }
}