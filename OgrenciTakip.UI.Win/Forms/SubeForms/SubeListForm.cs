using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.SubeForms
{
	public partial class SubeListForm : BaseListForm
    {
        private readonly Expression<Func<Sube, bool>> _filter;

        public SubeListForm()
        {
            InitializeComponent();
            Business = new SubeBusiness();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public SubeListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sube;
            FormShow = new ShowEditForms<SubeEditForm>();
            Navigator = longNavigator1.Navigator;
        }

        protected override void Listele()
        {
            var list = ((SubeBusiness)Business).List(_filter);
            tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}