using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.FiltreForms
{
	public partial class FiltreListForm : BaseListForm
	{
		#region Variables
		private readonly KartTuru _filtreKartTuru;
		private readonly GridControl _filtreGrid;
		#endregion

		public FiltreListForm(params object[] prm)
		{
			InitializeComponent();
			Business = new FiltreBusiness();

			_filtreKartTuru = (KartTuru)prm[0];
			_filtreGrid = (GridControl)prm[1];

			HideItems = new BarItem[] { btnFiltrele, btnKolonlar, btnGonder, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama, barGonder, barGonderAciklama, barYazdir, barYazdirAciklama };
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Filtre;
			Navigator = longNavigator.Navigator;
		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((FiltreBusiness)Business).List(x => x.KartTuru == _filtreKartTuru);
		}

		protected override void ShowEditForm(long id)
		{
			var result = ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);

			ShowEditFormDefault(result);
		}
	}
}