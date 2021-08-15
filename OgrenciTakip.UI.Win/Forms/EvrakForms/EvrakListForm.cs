using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakListForm : BaseListForm
    {
        private readonly Expression<Func<Evrak, bool>> _filter;

        public EvrakListForm()
        {
            InitializeComponent();

            Business = new EvrakBusiness();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Evrak;
            FormShow = new ShowEditForms<EvrakEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((EvrakBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

            //if (!MultiSelect) return;
            //if (list.Any())
            //    EklenebilecekEntityVar = true;
            //else
            //    Messages.KartBulunamadiMesaji("Kart");
        }
    }
}