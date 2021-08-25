using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Message;
using OgrenciYazilim.Model.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
	public partial class AileBilgiListForm : BaseListForm
	{
        private readonly Expression<Func<AileBilgi, bool>> _filter;

        public AileBilgiListForm()
        {
            InitializeComponent();

            Business = new AileBilgiBusiness();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public AileBilgiListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AileBilgi;
            FormShow = new ShowEditForms<AileBilgiEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((AileBilgiBusiness)Business).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}