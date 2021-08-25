using DevExpress.XtraBars;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.OgrenciForms
{
	public partial class OgrenciListForm : BaseListForm
	{
		public OgrenciListForm()
		{
			InitializeComponent();
			Business = new OgrenciBusiness();
			ShowItems = new BarItem[] { btnTahakkukYap };
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Ogrenci;
			FormShow = new ShowEditForms<OgrenciEditForm>();
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((OgrenciBusiness)Business).List(FilterFunctions.Filter<Ogrenci>(AktifKartlariGoster));
		}

		protected override void TahakkukYap()
		{
			var entity = tablo.GetRow<OgrenciL>().EntityConvert<Ogrenci>();

			using (var Business = new TahakkukBusiness())
			{
				var tahakkuk = Business.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

				if (tahakkuk != null)
					ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, tahakkuk.Id, null);
				else
					ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, -1, entity);   //yeni kayıt olduğu için -1 (3/6) 13. video 43:30
			}
		}
	}
}