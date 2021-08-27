using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Message;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
	public partial class TahakkukListForm : BaseListForm
	{
		private readonly Expression<Func<Tahakkuk, bool>> _filter;

		public TahakkukListForm()
		{
			InitializeComponent();

			Business = new TahakkukBusiness();
			HideItems = new BarItem[] { btnYeni };
			_filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
		}

		public TahakkukListForm(params object[] prm) : this()
		{
			_filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId && x.Durum == AktifKartlariGoster;
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Tahakkuk;
			FormShow = new ShowEditForms<TahakkukEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			var list = ((TahakkukBusiness)Business).List(_filter);
			Tablo.GridControl.DataSource = list;

			if (!MultiSelect) return;
			if (list.Any())
				EklenebilecekEntityVar = true;
			else
				Messages.KartBulunamadiMesaji("Kart");
		}
	}
}