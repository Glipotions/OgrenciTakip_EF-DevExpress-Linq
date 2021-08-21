using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BankaSubeForms;
//using OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.BankaForms
{
	public partial class BankaListForm : BaseListForm
	{
		public BankaListForm()
		{
			InitializeComponent();
			Business = new BankaBusiness();

			btnBagliKartlar.Caption = "Şube Kartları";
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Banka;
			FormShow = new ShowEditForms<BankaEditForm>();
			Navigator = longNavigator.Navigator;

			if (IsMdiChild)
				ShowItems = new BarItem[] { btnBagliKartlar };
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((BankaBusiness)Business).List(FilterFunctions.Filter<Banka>(AktifKartlariGoster));
		}

		protected override void BagliKartAc()
		{
			var entity = Tablo.GetRow<BankaL>();
			if (entity == null) return;
			ShowListForms<BankaSubeListForm>.ShowListForm(KartTuru.BankaSube, entity.Id, entity.BankaAdi);
		}
	}
}