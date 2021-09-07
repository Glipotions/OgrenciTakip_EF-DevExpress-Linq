using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.OzelKodForms
{
	public partial class OzelKodListForm : BaseListForm
	{
		private readonly OzelKodTuru _ozelKodTuru;
		private readonly KartTuru _ozelKodKartTuru;

		public OzelKodListForm(params object[] prm)
		{
			InitializeComponent();
			Business = new OzelKodBusiness();

			_ozelKodTuru = (OzelKodTuru)prm[0];
			_ozelKodKartTuru = (KartTuru)prm[1];
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.OzelKod;
			Navigator = longNavigator1.Navigator;
			Text = $"{Text} - ( {_ozelKodTuru.ToName()} )";
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((OzelKodBusiness)Business).List(x => x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
		}

		protected override void ShowEditForm(long id)
		{
			var result = ShowEditForms<OzelKodEditForm>.ShowDialogEditForm(KartTuru.OzelKod, id, _ozelKodTuru, _ozelKodKartTuru);
			ShowEditFormDefault(result);
		}
	}
}