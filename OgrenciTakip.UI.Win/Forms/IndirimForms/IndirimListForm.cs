using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IndirimForms
{
	public partial class IndirimListForm : BaseListForm
	{
		public IndirimListForm()
		{
			InitializeComponent();
			Business = new IndirimBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Indirim;
			FormShow = new ShowEditForms<IndirimEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IndirimBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}
	}
}