using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports.UI;
using DevExpress.XtraVerticalGrid;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.Functions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Properties;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Security.Cryptography;
using System.Text;
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

		public static long GetRowCellId(this GridView tablo, GridColumn idColumn)
		{
			var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
			return (long?)value ?? -1;  //value null ise -1 gönder
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
		public static void ButtonEnabledDurum(BarButtonItem btnKaydet, BarButtonItem btnGerial, bool tableValueChanged)
		{
			var butonEnabledDurumu = tableValueChanged;

			btnKaydet.Enabled = butonEnabledDurumu;
			btnGerial.Enabled = butonEnabledDurumu;
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

				case PropertyGridControl propertyGridControl:
					propertyGridControl.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
					if (!propertyGridControl.Enabled) // enable durumu false ise null olarak ata
						propertyGridControl.SelectedObject = null; 
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

		public static void RowCellEnabled(this GridView tablo)
		{
			var rowHandle = tablo.FocusedRowHandle;

			tablo.FocusedRowHandle = 0;
			tablo.ClearSelection();

			tablo.FocusedRowHandle = rowHandle;
		}

		public static void CreateDropDownMenu(this BarButtonItem baseButton, BarItem[] buttonItems)
		{
			baseButton.ButtonStyle = BarButtonStyle.CheckDropDown;
			var popupMenu = new PopupMenu();
			buttonItems.ForEach(x => x.Visibility = BarItemVisibility.Always);
			popupMenu.ItemLinks.AddRange(buttonItems);
			baseButton.DropDownControl = popupMenu;
		}

		public static MyXtraReport StreamToReport(this MemoryStream stream)
		{
			return (MyXtraReport)XtraReport.FromStream(stream, true);
		}

		public static MemoryStream ByteToStream(this byte[] report)
		{
			return new MemoryStream(report);
		}

		public static MemoryStream ReportToStream(this XtraReport rapor)
		{
			var stream = new MemoryStream();
			rapor.SaveLayout(stream);  //rapor dizaynı kayıt edilir
			return stream;
		}

		public static IEnumerable<T> CheckedComboBoxList<T>(this MyCheckedComboBoxEdit comboBox)
		{
			return comboBox.Properties.Items.Where(x => x.CheckState == CheckState.Checked).Select(x => (T)x.Value);
		}

		public static void AppSettingsWrite(string key, string value)
		{
			// Bu alan skin seçiminin kalıcı olması için yapılan bir fonksiyon, App.config dosyası içindeki appSettingse yazabilme işi görür.

			var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			configuration.AppSettings.Settings[key].Value = value;  //atama işlemi
			configuration.Save(ConfigurationSaveMode.Modified);     //kaydetme işlemi. modified diyerek değiştirmiş oluruz
			ConfigurationManager.RefreshSection("appSettings");     //reflesh atma yani değişimi gösterme kısmı
		}

		public static void CreateConnectionString(string initialCatalog, string server, SecureString kullaniciAdi,
			SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru)
		{
			SqlConnectionStringBuilder builder = null;

			switch (yetkilendirmeTuru)
			{
				case YetkilendirmeTuru.SqlServer:
					builder = new SqlConnectionStringBuilder
					{
						DataSource = server,
						UserID = kullaniciAdi.ConvertToUnSecureString(),
						Password = sifre.ConvertToUnSecureString(),
						InitialCatalog = initialCatalog,
						MultipleActiveResultSets = true //Aynı Connectiondan birden fazla sorgulama işlemi yapılır. Sürekli aç kapat yapmaya gerek yok.
					};
					break;

				case YetkilendirmeTuru.Windows:
					builder = new SqlConnectionStringBuilder
					{
						DataSource = server,
						InitialCatalog = initialCatalog,
						IntegratedSecurity = true,
						MultipleActiveResultSets = true
					};
					break;
			}

			//BURAYI PROJEYE GÖRE DEĞİŞTİRMEK GEREKİYOR
			var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			configuration.ConnectionStrings.ConnectionStrings["OgrenciTakipContext"].ConnectionString =
				builder?.ConnectionString;
			configuration.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("connectionStrings");
			Settings.Default.Reset();
			Settings.Default.Save();
		}

		public static bool BaglantiKontrolu(string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru, bool genelMesajVer = false)
        {
            CreateConnectionString("", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var con = new SqlConnection(Business.Function.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (con.ConnectionString == "") return false;
                    con.Open();
                    return true;
                }
                catch (SqlException exception)
                {
                    if (genelMesajVer)
                    {
                        Messages.HataMesaji("Server Bağlantı Ayarlarınız Hatalıdır. Lütfen Kontrol Ediniz.");
                        return false;
                    }

                    switch (exception.Number)
                    {
                        case 18456:
                            Messages.HataMesaji("Server Kullanıcı Adı veya Şifresi Hatalıdır.");
                            break;

                        default:
                            Messages.HataMesaji(exception.Message);
                            break;
                    }
                }

                return false;
            }
        }

		public static string Md5Sifrele(this string value)
		{
			//geri getirilemeye bir şifreleme
			var md5 = new MD5CryptoServiceProvider();
			var byteDiziBuffer = Encoding.UTF8.GetBytes(value);
			byteDiziBuffer = md5.ComputeHash(byteDiziBuffer);

			var md5Sifre = BitConverter.ToString(byteDiziBuffer).Replace("-", ""); //- karakteri koymasını istemiyoruz

			return md5Sifre;
		}

		public static (SecureString secureSifre, SecureString secureGizliKelime, string sifre, string gizliKelime) SifreUret()
		{
			string RandomDegerUret(int minValue, int count)
			{
				var random = new Random();
				const string karakterTablosu = "0123456789ABCDEFGHIJKLMNOPRSTUVWXQZabcdefghijklmnoprstuvwxqz"; //sabit hiçbir zaman değişmeyecek (const)
				string sonuc = null;

				for (int i = 0; i < count; i++)
					sonuc += karakterTablosu[random.Next(minValue, karakterTablosu.Length - 1)].ToString();

				return sonuc;
			}

			var secureSifre = RandomDegerUret(0, 8).ConvertToSecureString();
			var secureGizliKelime = RandomDegerUret(9, 10).ConvertToSecureString();
			var sifre = secureSifre.ConvertToUnSecureString().Md5Sifrele();
			var gizliKelime = secureGizliKelime.ConvertToUnSecureString().Md5Sifrele();

			return (secureSifre, secureGizliKelime, sifre, gizliKelime);
		}

		public static bool SifreMailiGonder(this string kullaniciAdi, string rol, string email, SecureString secureSifre, SecureString secureGizliKelime)
		{
			using (var Business = new MailParametreBusiness())
			{
				var entity = (MailParametre)Business.Single(null);
				if (entity == null)
				{
					Messages.HataMesaji("E-Mail Gönderilemedi Kurumun E-mail parametreleri Girilmemiş Olabilir. Lütfen Kontrol Edip Tekrar Deneyiniz.");
					return false;
				}

				var client = new SmtpClient
				{
					Port = entity.PortNo,
					Host = entity.Host,
					EnableSsl = entity.SslKullan == EvetHayir.Evet,
					UseDefaultCredentials = true,   //mail adresi ve şifresinin doğrulanmasını sağla
					Credentials = new NetworkCredential(entity.Email, entity.Sifre.Decrypt(entity.Id + entity.Kod).ConvertToSecureString())
				};

				var message = new MailMessage
				{
					From = new MailAddress(entity.Email, "Öğrenci Takip Programı"),
					To = { email },    //hangi mail adresine gidecek
					Subject = "Öğrenci Takip Programı Kullanıcı Bilgileri",   //Konu
					IsBodyHtml = true, //html tag kullanacağız o yüzden true  <br/> gibi
					Body = "Öğrenci Takip Programına Giriş İçin Gereken Kullanıcı Adı, Şifre ve Gizli Kelime Bilgileri Aşağıdadır.<br/>" +
						   "Lütfen Giriş Yaptıktan Sonra Bu Bilgileri Değiştiriniz.<br/><br/><br/>" +
						   $"<b>Kullanıcı Adı :</b> {kullaniciAdi}<br/>" +
						   $"<b>Yetki Türü    :</b> {rol}<br/>" +
						   $"<b>Şifre         :</b> {secureSifre.ConvertToUnSecureString()}<br/>" +
						   $"<b>Gizli Kelime  :</b> {secureGizliKelime.ConvertToUnSecureString()}"
				};

				try
				{
					Cursor.Current = Cursors.WaitCursor;

					client.Send(message);

					Cursor.Current = Cursors.Default;
					return true;
				}
				catch (Exception exception)
				{
					Messages.HataMesaji(exception.Message);
					return false;
				}
			}
		}
	}
}
