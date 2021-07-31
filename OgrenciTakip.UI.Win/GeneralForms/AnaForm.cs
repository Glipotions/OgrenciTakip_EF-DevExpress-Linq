using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms.OkulForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.GeneralForms
{
	public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public AnaForm()
		{
			InitializeComponent();
			EventsLoad();
		}

		private void EventsLoad()
		{
			foreach (var item in ribbonControl.Items)
			{
				switch (item)
				{
					case BarButtonItem btn:
						btn.ItemClick += Butonlar_ItemClick;
						break;
				}
			}
		}

		private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (e.Item == btnOkulKartlari)
				ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
			else if(e.Item==btnIlKartlari)
				ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);

		}
	}
}