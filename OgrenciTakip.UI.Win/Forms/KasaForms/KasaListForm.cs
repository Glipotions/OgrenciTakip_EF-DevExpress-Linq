using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.KasaForms
{
	public partial class KasaListForm : BaseListForm
	{
		public KasaListForm()
		{
			InitializeComponent();

			Business = new KasaBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Kasa;
			FormShow = new ShowEditForms<KasaEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((KasaBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}
	}
}