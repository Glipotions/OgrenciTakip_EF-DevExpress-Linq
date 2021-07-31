using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.OkulForms
{
	public partial class OkulListForm : BaseListForm
	{
		public OkulListForm()
		{
			InitializeComponent();

			//OkulBusiness business = new OkulBusiness();
			//grid.DataSource=business.List(null);
			Business = new OkulBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Okul;
			FormShow = new ShowEditForms<OkulEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((OkulBusiness)Business).List(FilterFunctions.Filter<Okul>(AktifKartlariGoster));
		}

	}
}