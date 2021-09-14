using DevExpress.Data;
using DevExpress.XtraGrid;
using System;
using System.Linq;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
	public partial class GenelAmacliRapor : BaseRapor
	{
		public GenelAmacliRapor()
		{
			InitializeComponent();
		}

		protected override void DegiskenleriDoldur()
		{
			DataLayoutControl = myDataLayoutControl;
			Tablo = tablo;
			Navigator = longNavigator.Navigator;
			Subeler = txtSubeler;
			KayitSekilleri = txtKayitSekli;
			KayitDurumlari = txtKayitDurumu;
			IptalDurumlari = txtIptalDurumu;

			SubeKartlariYukle();
			KayitSekliYukle();
			KayitDurumuYukle();
			IptalDurumuYukle();
			RaporTuru = KartTuru.GenelAmacliRapor;
		}

		protected override void Listele()
		{
			var subeler = txtSubeler.CheckedComboBoxList<long>();
			var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
			var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
			var iptalDurumu = txtIptalDurumu.CheckedComboBoxList<IptalDurumu>();

			using (var Business = new GenelAmacliRaporBusiness())
			{
				tablo.GridControl.DataSource = Business.List(x =>
					subeler.Contains(x.SubeId) &&
					kayitSekli.Contains(x.KayitSekli) &&
					kayitDurumu.Contains(x.KayitDurumu) &&
					iptalDurumu.Contains(x.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
					x.DonemId == AnaForm.DonemId);

				base.Listele();
			}
		}

		protected override void ShowEditForm()
		{
			var entity = tablo.GetRow<GenelAmacliRaporL>();
			if (entity == null) return;
			ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
		}

		protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
		{
			//Bu alanda Groupta İndirim oranıyla alakalı Hesap işlemleri yapılır

			if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

			var item = (GridSummaryItem)e.Item;
			if (item.FieldName != "IndirimOrani") return;

			if (e.IsGroupSummary)
			{
				var hizmetlerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetHizmet"]));
				var indirimToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetIndirim"]));

				// İndirim Hesaplaması yapılır. (Grouplarda)
				e.TotalValue = hizmetlerToplami == 0 ? 0 : indirimToplami / hizmetlerToplami * 100;
			}
			else if (e.IsTotalSummary)
			{
				var hizmetlerToplami = Convert.ToDecimal(colNetHizmet.SummaryItem.SummaryValue);
				var indirimToplami = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);

				// İndirim Hesaplaması yapılır. (Tüm Tablonun)
				e.TotalValue = hizmetlerToplami == 0 ? 0 : indirimToplami / hizmetlerToplami * 100;
			}

		}

	}

}