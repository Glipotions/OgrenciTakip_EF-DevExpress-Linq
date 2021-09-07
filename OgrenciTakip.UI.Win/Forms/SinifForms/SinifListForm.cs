using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.SinifForms
{
	public partial class SinifListForm : BaseListForm
	{
		public SinifListForm()
		{
			InitializeComponent();
			Business = new SinifBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Sinif;
			FormShow = new ShowEditForms<SinifEditForm>();
			Navigator = longNavigator1.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((SinifBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId);
		}
	}
}