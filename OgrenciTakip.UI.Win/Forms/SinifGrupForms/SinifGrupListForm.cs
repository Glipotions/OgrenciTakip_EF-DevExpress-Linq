using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;

namespace OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
	public partial class SinifGrupListForm : BaseListForm
	{
		public SinifGrupListForm()
		{
			InitializeComponent();

			Business = new SinifGrupBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.SinifGrup;
			FormShow = new ShowEditForms<SinifGrupEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((SinifGrupBusiness)Business).List(FilterFunctions.Filter<SinifGrup>(AktifKartlariGoster));
		}
	}
}