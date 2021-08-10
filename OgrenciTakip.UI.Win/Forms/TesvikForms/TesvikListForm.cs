using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.TesvikForms
{
	public partial class TesvikListForm : BaseListForm
	{
		public TesvikListForm()
		{
			InitializeComponent();

			Business = new TesvikBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Tesvik;
			FormShow = new ShowEditForms<TesvikEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((TesvikBusiness)Business).List(FilterFunctions.Filter<Tesvik>(AktifKartlariGoster));
		}
	}
}