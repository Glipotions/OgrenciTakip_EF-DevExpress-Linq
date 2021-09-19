using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
    public partial class KullaniciTable : BaseTablo
    {
        public KullaniciTable()
        {
            InitializeComponent();

            Business = new KullaniciBusiness();
            Tablo = tablo;
            EventsLoad();

            HideItems = new BarItem[] { btnHareketEkle, btnHareketSil };
            insUptNavigator.Navigator.Buttons.Append.Visible = false;
            insUptNavigator.Navigator.Buttons.Remove.Visible = false;
            insUptNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUptNavigator.Navigator.Buttons.NextPage.Visible = true;
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((KullaniciBusiness)Business).List(null);
        }

        protected override void HareketSil()
        {
            //override etmemizin sebebi shift+delete'ye bastığımız zaman kartı silmeye çalışmaması için
        }

        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            //(6/6) 29.video 12:00
            //bu tablodaki griddeki hangi satır seçilirse o satırın yetkilerini getirmesi için değişikliği yakalamak için 
            var entity = tablo.GetRow<KullaniciL>();
            if (entity == null) return;

            //Fokuslandığımız satır değiştiğinde dönem ve şube table larını seçilene göre yükler
            OwnerForm.Id = entity.Id;  //owner forma kullanıcının id'si atanır sube ve donem table'da ona göre filtrelenir
            ((KullaniciBirimYetkileriEditForm)OwnerForm).Yukle();
        }
    }
}