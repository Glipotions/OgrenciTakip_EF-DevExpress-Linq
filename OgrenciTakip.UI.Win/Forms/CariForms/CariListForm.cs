using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.CariForms
{
	public partial class CariListForm : BaseListForm
	{
		public CariListForm()
		{
			InitializeComponent();
			Business = new CariBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Cari;
			FormShow = new ShowEditForms<CariEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((CariBusiness)Business).List(FilterFunctions.Filter<Cari>(AktifKartlariGoster));
		}
	}
}