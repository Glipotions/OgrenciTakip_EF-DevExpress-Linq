using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Dto;
using OgrenciYazilim.Model.Entities;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
	public partial class AileBilgileriTable : BaseTablo
	{
		public AileBilgileriTable()
		{
			InitializeComponent();

			Business = new AileBilgileriBusiness();
			Tablo = tablo;
			EventsLoad();
		}

		protected internal override void Listele()
		{
			tablo.GridControl.DataSource = ((AileBilgileriBusiness)Business).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<AileBilgileriL>();
		}

		protected override void HareketEkle()
		{
			var source = tablo.DataController.ListSource;
			ListeDisiTutulacakKayitlar = source.Cast<AileBilgileriL>().Where(x => !x.Delete).Select(x => x.AileBilgiId).ToList();

			var entities = ShowListForms<AileBilgiListForm>.ShowDialogListForm(KartTuru.AileBilgi, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<AileBilgi>();
			if (entities == null) return;

			foreach (var entity in entities)
			{
				var row = new AileBilgileriL
				{
					TahakkukId = OwnerForm.Id,
					AileBilgiId = entity.Id,
					BilgiAdi = entity.BilgiAdi,
					Aciklama = null,
					Insert = true
				};

				source.Add(row);
			}

			tablo.Focus();
			tablo.RefreshDataSource();
			tablo.FocusedRowHandle = tablo.DataRowCount - 1;
			tablo.FocusedColumn = colBilgiAdi;

			ButonEnabledDurumu(true);
		}
	}
}