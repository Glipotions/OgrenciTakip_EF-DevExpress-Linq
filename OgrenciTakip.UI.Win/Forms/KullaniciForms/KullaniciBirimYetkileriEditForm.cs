using DevExpress.XtraBars;
using System;
using OgrenciTakip.UI.Win.Forms.BaseForms;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciBirimYetkileriEditForm : BaseEditForm
    {
        public KullaniciBirimYetkileriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnYeni, btnSil, btnKaydet, btnGeriAl };
            EventsLoad();
            TabloYukle();
        }

        public override void Yukle()
        {
            subeTable.Yukle();
            donemTable.Yukle();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            //devre dışı bırakmak için override ettik
        }

        protected override void TabloYukle()
        {
            kullaniciTable.OwnerForm = this;
            subeTable.OwnerForm = this;
            donemTable.OwnerForm = this;

            kullaniciTable.Yukle();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            kullaniciTable.Tablo.Focus();
        }
    }
}