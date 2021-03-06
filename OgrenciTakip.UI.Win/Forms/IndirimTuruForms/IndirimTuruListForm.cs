using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
	public partial class IndirimTuruListForm : BaseListForm
	{
		public IndirimTuruListForm()
		{
			InitializeComponent();

			Business = new IndirimTuruBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.IndirimTuru;
			FormShow = new ShowEditForms<IndirimTuruEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IndirimTuruBusiness)Business).List(FilterFunctions.Filter<IndirimTuru>(AktifKartlariGoster));
		}
	}
}