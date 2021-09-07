using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
	public partial class IptalNedeniListForm : BaseListForm
	{
		public IptalNedeniListForm()
		{
			InitializeComponent();
			Business = new IptalNedeniBusiness();
		}
		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.IptalNedeni;
			FormShow = new ShowEditForms<IptalNedeniEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IptalNedeniBusiness)Business).List(FilterFunctions.Filter<IptalNedeni>(AktifKartlariGoster));
		}


	}
}