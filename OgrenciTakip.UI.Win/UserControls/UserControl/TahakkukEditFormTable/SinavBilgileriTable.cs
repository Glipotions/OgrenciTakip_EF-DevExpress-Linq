using OgrenciTakip.Business.General;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciYazilim.Common.Message;
using System;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
	public partial class SinavBilgileriTable : BaseTablo
	{
		public SinavBilgileriTable()
		{
			InitializeComponent();

			Business = new SinavBilgileriBusiness();
			Tablo = tablo;
			EventsLoad();
		}

		protected internal override void Listele()
		{
			tablo.GridControl.DataSource = ((SinavBilgileriBusiness)Business).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<SinavBilgileriL>();
		}

		protected override void HareketEkle()
		{
			var source = tablo.DataController.ListSource;

			var row = new SinavBilgileriL
			{
				TahakkukId = OwnerForm.Id,
				Tarih = DateTime.Now.Date,
				Insert = true
			};

			source.Add(row);

			tablo.Focus();
			tablo.RefreshDataSource();
			tablo.FocusedRowHandle = tablo.DataRowCount - 1;
			tablo.FocusedColumn = colSinavAdi;

			ButonEnabledDurumu(true);
		}

		protected internal override bool HataliGiris()
		{
			if (!TableValueChanged) return false;
			if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

			for (int i = 0; i < tablo.DataRowCount; i++)
			{
				var entity = tablo.GetRow<SinavBilgileriL>(i);

				if (string.IsNullOrEmpty(entity.SinavAdi))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colSinavAdi;
					tablo.SetColumnError(colSinavAdi, "Sınav Adı Alanına Geçerli Bir Değer Giriniz.");
				}

				if (string.IsNullOrEmpty(entity.PuanTuru))
				{
					tablo.FocusedRowHandle = i;
					tablo.FocusedColumn = colPuanTuru;
					tablo.SetColumnError(colPuanTuru, "Puan Türü Alanına Geçerli Bir Değer Giriniz.");
				}

				if (!tablo.HasColumnErrors) continue;
				Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
				return true;
			}

			return false;
		}
	}
}