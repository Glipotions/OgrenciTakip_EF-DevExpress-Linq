using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
	public partial class BilgiNotlariTable : BaseTablo
	{
		public BilgiNotlariTable()
		{
			InitializeComponent();

			Business = new BilgiNotlariBusiness();
			Tablo = tablo;
			EventsLoad();
		}

		protected internal override void Listele()
		{
			tablo.GridControl.DataSource = ((BilgiNotlariBusiness)Business).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<BilgiNotlariL>();
		}

		protected override void HareketEkle()
		{
			var source = tablo.DataController.ListSource;

			var row = new BilgiNotlariL
			{
				TahakkukId = OwnerForm.Id,
				Tarih = DateTime.Now,
				Insert = true
			};

			source.Add(row);

			tablo.Focus();
			tablo.RefreshDataSource();
			tablo.FocusedRowHandle = tablo.DataRowCount - 1;
			tablo.FocusedColumn = colBilgiNotu;

			ButonEnabledDurumu(true);
		}

		protected internal override bool HataliGiris()
		{
			if (!TableValueChanged) return false;
			if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

			for (int i = 0; i < tablo.DataRowCount; i++)
			{
				var entity = tablo.GetRow<BilgiNotlariL>(i);
				if (string.IsNullOrEmpty(entity.BilgiNotu))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colBilgiNotu;
					tablo.SetColumnError(colBilgiNotu, "Bilgi Notu Alanına Geçerli Bir Değer Giriniz.");
				}

				if (!tablo.HasColumnErrors) continue;
				Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
				return true;
			}

			return false;
		}

		private void Grid_Click(object sender, EventArgs e)
		{
		}
	}
}