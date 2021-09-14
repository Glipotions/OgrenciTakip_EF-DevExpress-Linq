using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariListForm : BaseListForm
    {
        private readonly int _portfoyNo;

        public GecikmeAciklamalariListForm(params object[] prm)
        {
            InitializeComponent();
            Business = new GecikmeAciklamalariBusiness();
            HideItems = new BarItem[] { btnSec };

            _portfoyNo = (int)prm[0];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.GecikmeAciklamalari;
            Navigator = longNavigator1.Navigator;
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((GecikmeAciklamalariBusiness)Business).List(x => x.OdemeBilgileriId == _portfoyNo);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<GecikmeAciklamalariEditForm>.ShowDialogEditForm(KartTuru.GecikmeAciklamalari, id, _portfoyNo);
            ShowEditFormDefault(result);
        }
    }
}