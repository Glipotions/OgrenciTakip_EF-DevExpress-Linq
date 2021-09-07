using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.RaporForms
{
	public partial class RaporListForm : BaseListForm
	{
		private readonly KartTuru _raporTuru;
		private readonly RaporBolumTuru _raporBolumTuru;
		private readonly byte[] _dosya;

		public RaporListForm(params object[] prm)
		{
			InitializeComponent();

			Business = new RaporBusiness();

			_raporTuru = (KartTuru)prm[0];
			_raporBolumTuru = (RaporBolumTuru)prm[1];
			_dosya = (byte[])prm[2];
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Rapor;
			FormShow = new ShowEditForms<RaporEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			tablo.GridControl.DataSource = ((RaporBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.RaporTuru == _raporTuru);
		}

		protected override void ShowEditForm(long id)
		{
			var result = ShowEditForms<RaporEditForm>.ShowDialogEditForm(KartTuru.Rapor, id, _raporTuru, _raporBolumTuru, _dosya);
			ShowEditFormDefault(result);
		}
	}
}