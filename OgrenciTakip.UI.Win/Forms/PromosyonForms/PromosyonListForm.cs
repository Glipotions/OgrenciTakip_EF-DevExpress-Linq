using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.General;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.PromosyonForms
{
    public partial class PromosyonListForm : BaseListForm
    {
        //private readonly Expression<Func<Promosyon, bool>> _filter;

        public PromosyonListForm()
        {
            InitializeComponent();

            Business = new PromosyonBusiness();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Promosyon;
            FormShow = new ShowEditForms<PromosyonEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PromosyonBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

            //if (!MultiSelect) return;
            //if (list.Any())
            //    EklenebilecekEntityVar = true;
            //else
            //    Messages.KartBulunamadiMesaji("Kart");
        }
    }
}