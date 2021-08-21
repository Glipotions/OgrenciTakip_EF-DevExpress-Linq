using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.AvukatForms
{
	public partial class AvukatListForm : BaseListForm
	{
		public AvukatListForm()
		{
			InitializeComponent();
			Business = new AvukatBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Avukat;
			FormShow = new ShowEditForms<AvukatEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((AvukatBusiness)Business).List(FilterFunctions.Filter<Avukat>(AktifKartlariGoster));
		}
	}
}