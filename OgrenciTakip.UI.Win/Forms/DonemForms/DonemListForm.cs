using DevExpress.XtraBars;
using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.DonemForms
{
    public partial class DonemListForm : BaseListForm
    {
        private readonly Expression<Func<Donem, bool>> _filter;

        public DonemListForm()
        {
            InitializeComponent();

            Business = new DonemBusiness();
            _filter = x => x.Durum == AktifKartlariGoster;
            ShowItems = new BarItem[] { btnParametreler, barF4, barF4Aciklama };
        }

        public DonemListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Donem;
            FormShow = new ShowEditForms<DonemEditForm>();
            Navigator = longNavigator1.Navigator;
        }

        protected override void Listele()
        {
            var list = ((DonemBusiness)Business).List(_filter);
            tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        protected override void BagliKartAc()
        {
            var entity = tablo.GetRow<Donem>();
            if (entity == null) return;
            ShowEditForms<DonemParametreEditForm>.ShowDialogEditForm(null, entity.Id);
        }
    }
}