using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Message;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
	public partial class IletisimListForm : BaseListForm
	{
		private readonly Expression<Func<Iletisim, bool>> _filter;

		public IletisimListForm()
		{
			InitializeComponent();
			Business = new IletisimBusiness();
			_filter = x => x.Durum == AktifKartlariGoster;
		}

		public IletisimListForm(params object[] prm) : this()
		{
			_filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Iletisim;
			FormShow = new ShowEditForms<IletisimEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			var list = ((IletisimBusiness)Business).List(_filter);
			Tablo.GridControl.DataSource = list;

			if (!MultiSelect) return;
			if (list.Any())
				EklenebilecekEntityVar = true;
			else
				Messages.KartBulunamadiMesaji("Kart");
		}
	}
}