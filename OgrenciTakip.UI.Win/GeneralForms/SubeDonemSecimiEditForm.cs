using DevExpress.XtraBars;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class SubeDonemSecimiEditForm : BaseEditForm
    {
        private readonly long _kullaniciId;
        private readonly bool _subeSecimButonunaBasildi;
        private readonly long _seciliGelecekSubeId;
        private readonly long _seciliGelecekDonemId;
        private List<long> _yetkiliOlunanSubeler;
        private bool _girisButonunaBasildi;

        public SubeDonemSecimiEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnYeni, btnSil, btnKaydet, btnGeriAl };
            ShowItems = new BarItem[] { btnGiris };
            subeNavigator.Navigator.NavigatableControl = subeGrid;
            donemNavigator.Navigator.NavigatableControl = donemGrid;
            EventsLoad();

            _kullaniciId = (long)prm[0];
            _subeSecimButonunaBasildi = (bool)prm[1];
            _seciliGelecekSubeId = (long)prm[2];
            _seciliGelecekDonemId = (long)prm[3];
        }

        public override void Yukle()
        {
            using (var Business = new KullaniciBirimYetkileriBusiness())
            {
                var yetkiler = Business.List(x => x.KullaniciId == _kullaniciId).Cast<KullaniciBirimYetkileriL>().ToList();
                _yetkiliOlunanSubeler = yetkiler.Where(x => x.SubeId > 0).Select(x => x.SubeId.Value).ToList();

                var subeSource = yetkiler.Where(x => x.SubeId > 0).ToList();
                var donemSource = yetkiler.Where(x => x.DonemId > 0).ToList();

                if (subeSource.Count == 0)
                {
                    Messages.HataMesaji("Kulanıcı Hiçbir Şubede Yetkilendirilmediği İçin Giriş Yapamazsınız.");
                    Application.ExitThread();
                }

                if (donemSource.Count == 0)
                {
                    Messages.HataMesaji("Kulanıcı Hiçbir Dönemde Yetkilendirilmediği İçin Giriş Yapamazsınız.");
                    Application.ExitThread();
                }

                subeGrid.DataSource = subeSource;
                donemGrid.DataSource = donemSource;

                if (!_subeSecimButonunaBasildi) return;
                subeTablo.RowFocus("SubeId", _seciliGelecekSubeId);
                donemTablo.RowFocus("DonemId", _seciliGelecekDonemId);
            }
        }

        public override void Giris()
        {
            var sube = subeTablo.GetRow<KullaniciBirimYetkileriL>();
            var donem = donemTablo.GetRow<KullaniciBirimYetkileriL>();

            using (var Business = new DonemParametreBusiness())
            {
                var entity = (DonemParametre)Business.Single(x => x.SubeId == sube.SubeId && x.DonemId == donem.DonemId);

                if (entity == null)
                {
                    Messages.HataMesaji("Seçtiğiniz Şubenin İlgili Dönemine Ait Parametreler Girilmemiş. Lütfen Sistem Yöneticisine Başvurunuz.");
                    return;
                }

                AnaForm.DonemParametre = entity;
                AnaForm.YetkiliOlunanSubeler = _yetkiliOlunanSubeler;
                AnaForm.SubeId = sube.SubeId.Value;
                AnaForm.SubeAdi = sube.SubeAdi;
                AnaForm.DonemId = donem.DonemId.Value;
                AnaForm.DonemAdi = donem.DonemAdi;
            }

            _girisButonunaBasildi = true;
            Close();
        }

        protected override void Control_KeyDown(object sender, KeyEventArgs e)
        {
            base.Control_KeyDown(sender, e);

            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Right && e.KeyCode != Keys.Left) return;

            if (sender == subeGrid)
                donemGrid.Focus();
            else
                subeGrid.Focus();
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.BaseEditForm_FormClosing(sender, e);

            if (_girisButonunaBasildi || _subeSecimButonunaBasildi) return;

            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor musunuz?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}