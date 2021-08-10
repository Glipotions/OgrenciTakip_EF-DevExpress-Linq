using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.IlceForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.IlForms
{
	public partial class IlListForm : BaseListForm
	{
		public IlListForm()
		{
			InitializeComponent();
			Business = new IlBusiness();
			btnBagliKartlar.Caption = "İlçe Kartları";
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Il;
			FormShow = new ShowEditForms<IlEditForm>();
			Navigator = longNavigator.Navigator;

			if (IsMdiChild)
				ShowItems = new BarItem[] { btnBagliKartlar };
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IlBusiness)Business).List(FilterFunctions.Filter<Il>(AktifKartlariGoster));
		}

		protected override void BagliKartAc()
		{
			var entity = Tablo.GetRow<Il>();
			if (entity == null) return;
			ShowListForms<IlceListForm>.ShowListForm(KartTuru.Ilce, entity.Id, entity.IlAdi);

		}

	}
}