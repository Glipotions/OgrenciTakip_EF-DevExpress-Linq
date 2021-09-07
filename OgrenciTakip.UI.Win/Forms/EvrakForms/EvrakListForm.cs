using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.EvrakForms
{
	public partial class EvrakListForm : BaseListForm
	{
		private readonly Expression<Func<Evrak, bool>> _filter;

		public EvrakListForm()
		{
			InitializeComponent();

			Business = new EvrakBusiness();
			_filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
		}

		public EvrakListForm(params object[] prm) : this()
		{
			_filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
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
			var list = ((EvrakBusiness)Business).List(_filter);
			Tablo.GridControl.DataSource = list;

			if (!MultiSelect) return;
			if (list.Any())
				EklenebilecekEntityVar = true;
			else
				Messages.KartBulunamadiMesaji("Kart");
		}
	}
}