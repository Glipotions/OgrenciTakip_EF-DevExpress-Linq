using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.IlceForms
{
	public partial class IlceListForm : BaseListForm
	{
		#region Variables
		private readonly long _ilId;
		private readonly string _ilAdi;
		#endregion

		public IlceListForm(params object[] prm)
		{
			InitializeComponent();
			Business = new IlceBusiness();

			_ilId = (long)prm[0];
			_ilAdi = prm[1].ToString();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Ilce;
			Navigator = longNavigator.Navigator;
			Text = Text + $" - ( {_ilAdi} ) ";
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IlceBusiness)Business).List(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);
		}

		protected override void ShowEditForm(long id)
		{
			var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilId, _ilAdi);

			ShowEditFormDefault(result);
		}
	}
}