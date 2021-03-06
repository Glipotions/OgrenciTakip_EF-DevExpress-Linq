using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.GorevForms
{
	public partial class GorevListForm : BaseListForm
	{
		public GorevListForm()
		{
			InitializeComponent();

			Business = new GorevBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Gorev;
			FormShow = new ShowEditForms<GorevEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((GorevBusiness)Business).List(FilterFunctions.Filter<Gorev>(AktifKartlariGoster));
		}
	}
}