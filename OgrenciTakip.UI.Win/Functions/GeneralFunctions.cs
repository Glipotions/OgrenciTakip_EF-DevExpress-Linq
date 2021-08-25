using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Message;
using OgrenciYazilim.Model.Entities.Base;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Functions
{
	public static class GeneralFunctions
	{
		public static long GetRowId(this GridView tablo)
		{
			if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
			Messages.KartSecmemeUyariMesaji();
			return -1;
		}

		public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
		{
			if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

			if (mesajVer)
				Messages.KartSecmemeUyariMesaji();

			return default(T);
		}

		public static T GetRow<T>(this GridView tablo, int rowHandle)
		{
			if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);
			Messages.KartSecmemeUyariMesaji();
			tablo.FocusedRowHandle = 0;  //seçim yapılan list formlarda filtre sekmesi yoksa silinebilir sonradan eklendi.
			return default(T);
		}

		private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
		{
			foreach (var prop in currentEntity.GetType().GetProperties())
			{
				if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
				var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
				var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

				if (prop.PropertyType == typeof(byte[]))
				{
					if (string.IsNullOrEmpty(oldValue.ToString()))
						oldValue = new byte[] { };
					if (string.IsNullOrEmpty(currentValue.ToString()))
						currentValue = new byte[] { };
					if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
						return VeriDegisimYeri.Alan;

				}
				else if (!currentValue.Equals(oldValue))
					return VeriDegisimYeri.Alan;
			}
			return VeriDegisimYeri.VeriDegisimiYok;
		}

		public static void ButtonEnabledDurum<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity)
		{
			var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
			var buttonEnableDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

			btnKaydet.Enabled = buttonEnableDurum;
			btnGeriAl.Enabled = buttonEnableDurum;
			btnYeni.Enabled = !buttonEnableDurum;
			btnSil.Enabled = !buttonEnableDurum;
		}

		public static void ButtonEnabledDurum(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil)
		{
			btnKaydet.Enabled = false;
			btnGeriAl.Enabled = false;
			btnYeni.Enabled = false;
			btnSil.Enabled = false;
		}

		public static void ButtonEnabledDurum<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity, bool tableValueChanged)
		{
			var veriDegisimYeri = tableValueChanged ? VeriDegisimYeri.Tablo : VeriDegisimYeriGetir(oldEntity, currentEntity);
			var buttonEnableDurum = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo;

			btnKaydet.Enabled = buttonEnableDurum;
			btnGeriAl.Enabled = buttonEnableDurum;
			btnYeni.Enabled = !buttonEnableDurum;
			btnSil.Enabled = !buttonEnableDurum;
		}

		public static void ButtonEnabledDurum<T>(BarButtonItem btnKaydet, BarButtonItem btnFarklıKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T currentEntity)
		{
			var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
			var buttonEnableDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

			btnKaydet.Enabled = buttonEnableDurum;
			btnFarklıKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
			btnSil.Enabled = !buttonEnableDurum;
		}

		public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
		{

			string SifirEkle(string deger)
			{
				if (deger.Length == 1)
					return "0" + deger;
				return deger;
			}
			string UcBasamakYap(string deger)
			{
				switch (deger.Length)
				{
					case 1:
						return "00" + deger;
					case 2:
						return "0" + deger;
				}
				return deger;
			}
			string Id()
			{
				var yil = SifirEkle(DateTime.Now.Date.Year.ToString());
				var ay = SifirEkle(DateTime.Now.Date.Month.ToString());
				var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
				var saat = SifirEkle(DateTime.Now.Hour.ToString());
				var dakika = SifirEkle(DateTime.Now.Minute.ToString());
				var saniye = SifirEkle(DateTime.Now.Second.ToString());
				var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
				var randomYap = SifirEkle(new Random().Next(0, 99).ToString());
				return yil + ay + gun + saat + dakika + saniye + milisaniye + randomYap;
			}

			return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
		}

		public static void ControlEnableChanged(this MyButtonEdit baseEdit, Control prmEdit)
		{
			switch (prmEdit)
			{
				case MyButtonEdit edt:
					edt.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
					edt.Id = null;
					edt.EditValue = null;
					break;
			}
		}

		public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
		{
			var rowHandle = 0;

			for (int i = 0; i < tablo.RowCount; i++)
			{
				var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);

				if (aranacakDeger.Equals(bulunanDeger)) rowHandle = i;
			}

			tablo.FocusedRowHandle = rowHandle;
		}

		public static void RowFocus(this GridView tablo, int rowHandle)
		{
			if (rowHandle <= 0) return;
			if (rowHandle == tablo.RowCount - 1)
				tablo.FocusedRowHandle = rowHandle;
			else
				tablo.FocusedRowHandle = rowHandle - 1;
		}

		public static void SagTikMenuGoster(this MouseEventArgs e, PopupMenu sagTikMenu)
		{
			if (e.Button != MouseButtons.Right) return;
			sagTikMenu.ShowPopup(Control.MousePosition);
		}

		public static List<string> YazicilariListele()
		{
			return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
		}

		public static string DefaultYazici()
		{
			var settings = new PrinterSettings();
			return settings.PrinterName;
		}

		public static void ShowPopupMenu(this MouseEventArgs e, PopupMenu popupMenu)
		{
			if (e.Button != MouseButtons.Right) return; //mouse sağ tuşu değilse return yap
			popupMenu.ShowPopup(Control.MousePosition);  //mouse nerdeyse orda aç
		}

		public static byte[] ResimYukle()    //ÖNEMLİ
		{
			var dialog = new OpenFileDialog
			{
				Title = "Resim Seç",
				Filter = "Resim Dosyaları (*.bmp, *.gif, *.jpg, *.png)|*.bmp; *.gif; *.jpg; *.png|Bmp Dosyaları|*.bmp|Gif Dosyaları|*.gif|Jpg Dosyları|*.jpg|Png Dosyaları|*.png",
				InitialDirectory = @"C:\"
			};

			byte[] Resim()
			{
				using (var stream = new MemoryStream())
				{
					Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
					return stream.ToArray();
				}
			}

			return dialog.ShowDialog() != DialogResult.OK ? null : Resim();
		}

		public static void RefreshDataSource(this GridView tablo)
		{
			var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();//(3/6 5. video 23:00)
			if (!source.Any(x => x.Delete)) return;  //satırda durumu delete olarak işaretlenmiş satır yoksa return yap
			var rowHandle = tablo.FocusedRowHandle;

			tablo.CustomRowFilter += Tablo_CustomRowFilter;
			tablo.RefreshData();
			tablo.CustomRowFilter -= Tablo_CustomRowFilter;
			tablo.RowFocus(rowHandle);

			void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
			{
				var entity = source[e.ListSourceRow];
				if (entity == null) return;

				if (!entity.Delete) return;

				e.Visible = false;
				e.Handled = true;
			}
		}

		public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity> list)
		{
			return new BindingList<T>((IList<T>)list);
		}

		public static BaseTablo AddTable(this BaseTablo tablo, BaseEditForm form)
		{
			tablo.Dock = DockStyle.Fill;
			tablo.OwnerForm = form;
			return tablo;
		}

		public static void LayoutControlInsert(this LayoutGroup grup, Control control, int columnIndex, int rowIndex, int columnSpan, int rowSpan)
		{
			var item = new LayoutControlItem
			{
				Control = control,
				Parent = grup
			};

			item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
			item.OptionsTableLayoutItem.RowIndex = rowIndex;
			item.OptionsTableLayoutItem.ColumnSpan = columnSpan;
			item.OptionsTableLayoutItem.RowSpan = rowSpan;
		}

	}
}
