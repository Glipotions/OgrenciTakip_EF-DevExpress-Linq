using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
	public partial class OdemeTuruListForm : BaseListForm
	{
		public OdemeTuruListForm()
		{
			InitializeComponent();

			Business = new OdemeTuruBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.OdemeTuru;
			FormShow = new ShowEditForms<OdemeTuruEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((OdemeTuruBusiness)Business).List(FilterFunctions.Filter<OdemeTuru>(AktifKartlariGoster));
		}
	}
}