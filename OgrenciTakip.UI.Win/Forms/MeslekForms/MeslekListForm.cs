using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.MeslekForms
{
	public partial class MeslekListForm : BaseListForm
	{
		public MeslekListForm()
		{
			InitializeComponent();

			Business = new MeslekBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Meslek;
			FormShow = new ShowEditForms<MeslekEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((MeslekBusiness)Business).List(FilterFunctions.Filter<Meslek>(AktifKartlariGoster));
		}
	}
}