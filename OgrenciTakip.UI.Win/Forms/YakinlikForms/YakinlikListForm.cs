using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.YakinlikForms
{
	public partial class YakinlikListForm : BaseListForm
	{
		public YakinlikListForm()
		{
			InitializeComponent();

			Business = new YakinlikBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Yakinlik;
			FormShow = new ShowEditForms<YakinlikEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((YakinlikBusiness)Business).List(FilterFunctions.Filter<Yakinlik>(AktifKartlariGoster));
		}
	}
}