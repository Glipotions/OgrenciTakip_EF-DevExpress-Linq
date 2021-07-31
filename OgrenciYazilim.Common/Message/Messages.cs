using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace OgrenciYazilim.Common.Message
{
	public class Messages
	{
		public static void HataMesaji(string hataMesaji)
		{
			XtraMessageBox.Show(hataMesaji,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		public static void UyariMesaji(string uyariMesaji)
		{
			XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static DialogResult EvetSeciliEvetHayir(string mesaj,string baslik)
		{
			return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
		}

		public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
		{
			return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
		}

		public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
		{
			return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
		}

		public static DialogResult SilMesaj(string kartAdi)
		{
			return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Silinecektir. Onaylıyor musunuz?", "Silme Onayı");
		}

		public static DialogResult KayitMesaj()
		{
			return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin Mi?", "Kayıt Onay");
		}

		public static DialogResult KapanisMesaj()
		{
			return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin Mi?", "Çıkış Onay");
		}

		public static void KartSecmemeUyarıMesaji()
		{
			UyariMesaji("Lüfen bir Kart Seçiniz!");
		}

		public static void MukerrerKayitHataMesaji(string alan)
		{
			HataMesaji($"Girmiş olduğunuz {alan} Daha Önce Kullanılmıştır!");
		}

		public static void HataliVeriHataMesaji(string alan)
		{
			HataMesaji($"{alan} Alanına Geçerli Bir Değer Girmelisiniz!");
		}

		public static DialogResult TabloExportMessage(string dosyaFormati)
		{
			return EvetSeciliEvetHayir($"İlgili Tablo, {dosyaFormati} Olarak Dışarı Aktarılacaktır Onaylıyor musunuz?", "Aktarım Onay");
		}
	}
}
