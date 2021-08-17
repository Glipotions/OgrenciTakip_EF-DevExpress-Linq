using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
	public partial class HizmetTuruListForm : BaseListForm
	{
		public HizmetTuruListForm()
		{
			InitializeComponent();

			Business = new HizmetTuruBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.HizmetTuru;
			FormShow = new ShowEditForms<HizmetTuruEditForm>();
			Navigator = longNavigator1.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((HizmetTuruBusiness)Business).List(FilterFunctions.Filter<HizmetTuru>(AktifKartlariGoster));
		}
	}
}