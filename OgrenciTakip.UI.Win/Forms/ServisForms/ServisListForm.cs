using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisListForm : BaseListForm
    {
        public ServisListForm()
        {
            InitializeComponent();
            Business = new ServisBusiness();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Servis;
            FormShow = new ShowEditForms<ServisEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ServisBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}