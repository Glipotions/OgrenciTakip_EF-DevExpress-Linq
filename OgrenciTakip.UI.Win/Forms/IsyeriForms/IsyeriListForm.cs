using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IsyeriForms
{
	public partial class IsyeriListForm : BaseListForm
	{
		public IsyeriListForm()
		{
			InitializeComponent();

			Business = new IsyeriBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Isyeri;
			FormShow = new ShowEditForms<IsyeriEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IsyeriBusiness)Business).List(FilterFunctions.Filter<Isyeri>(AktifKartlariGoster));
		}
	}
}