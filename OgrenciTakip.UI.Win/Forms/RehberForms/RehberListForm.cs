using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.RehberForms
{
	public partial class RehberListForm : BaseListForm
	{
		public RehberListForm()
		{
			InitializeComponent();

			Business = new RehberBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Rehber;
			FormShow = new ShowEditForms<RehberEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((RehberBusiness)Business).List(FilterFunctions.Filter<Rehber>(AktifKartlariGoster));
		}
	}
}