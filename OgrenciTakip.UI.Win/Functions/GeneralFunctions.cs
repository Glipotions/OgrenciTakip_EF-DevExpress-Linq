using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Common.Message;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Functions
{
	public static class GeneralFunctions
	{
		public static long GetRowId(this GridView tablo)
		{
			if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
			Messages.KartSecmemeUyarıMesaji();
			return -1;
		}

		public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
		{
			if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

			if (mesajVer)
				Messages.KartSecmemeUyarıMesaji();

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
					if (string.IsNullOrEmpty(currentEntity.ToString()))
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

		public static void SagTikMenuGoster(this MouseEventArgs e,PopupMenu sagTikMenu)
		{
			if (e.Button != MouseButtons.Right) return;
			sagTikMenu.ShowPopup(Control.MousePosition);
		}
	}
}
