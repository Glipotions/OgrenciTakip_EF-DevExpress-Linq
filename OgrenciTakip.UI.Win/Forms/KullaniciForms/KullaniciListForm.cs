using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciListForm : BaseListForm
    {
        public KullaniciListForm()
        {
            InitializeComponent();
            Business = new KullaniciBusiness();
            HideItems = new BarItem[] { btnSec };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kullanici;
            FormShow = new ShowEditForms<KullaniciEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((KullaniciBusiness)Business).List(FilterFunctions.Filter<Kullanici>(AktifKartlariGoster));
        }
    }
}