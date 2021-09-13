using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class TahakkukBilgileriTable : BaseTablo
    {
        public TahakkukBilgileriTable()
        {
            InitializeComponent();

            Business = new TahakkukBusiness();
            Tablo = tablo;
            EventsLoad();

            insUptNavigator.Navigator.Buttons.Append.Visible = false;
            insUptNavigator.Navigator.Buttons.Remove.Visible = false;

            insUptNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUptNavigator.Navigator.Buttons.NextPage.Visible = true;

            HideItems = new BarItem[] { btnHareketEkle, btnHareketSil };
            ShowItems = new BarItem[] { btnKartDuzenle }; ;
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((TahakkukBusiness)Business).OgrenciTahakkukList(x => x.OgrenciId == OwnerForm.Id);
        }

        protected override void OpenEntity()
        {
            //Burası Tablodaki tahakkuk a tıklandığında o tahakkuk bilgilerini açar

            var entity = tablo.GetRow<OgrenciTahakkukL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }
    }
}