using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.KontenjanForms
{
	public partial class KontenjanListForm : BaseListForm
	{
		public KontenjanListForm()
		{
			InitializeComponent();

			Business = new KontenjanBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Kontenjan;
			FormShow = new ShowEditForms<KontenjanEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((KontenjanBusiness)Business).List(FilterFunctions.Filter<Kontenjan>(AktifKartlariGoster));
		}
	}
}