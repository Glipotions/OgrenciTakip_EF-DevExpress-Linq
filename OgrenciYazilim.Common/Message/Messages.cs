using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace OgrenciTakip.Common.Message
{
	public class Messages
	{
		public static void HataMesaji(string hataMesaji)
		{
			XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static void UyariMesaji(string uyariMesaji)
		{
			XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
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

		public static void KartSecmemeUyariMesaji()
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

		public static void KartBulunamadiMesaji(string kartTuru)
		{
			UyariMesaji($"İşlem Yapılabilecek {kartTuru} Türü Bulunamadı!");
		}

		public static void TabloEksikBilgiMesaji(string tabloAdi)
		{
			UyariMesaji($"{tabloAdi}'nda Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz.");
		}

		public static void IptalHareketSilinemezMesaji()
		{
			HataMesaji("İptal Edilen Hareketler Silinemez.");
		}

		public static DialogResult IptalMesaj(string kartAdi)
		{
			return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} iptal edilecektir onaylıyor musunuz?", "İptal Onayı");
		}

		public static DialogResult IptalGeriAlMesajMesaj(string kartAdi)
		{
			return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır Onaylıyor Musunuz?", "İptal Geri Al Onayı");
		}

		public static void SecimHataMesaji(string alanAdi)
		{
			HataMesaji($"{alanAdi} Seçimi Yapmalısınız");
		}

		public static void OdemeBelgesiSilinemezMesaji(bool dahaSonra)
		{
			UyariMesaji(dahaSonra ? "Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var. Ödeme Belgesi Silinemez." : "Ödeme Belgesinin İşlem Görmüş Hareketleri Var Ödeme Belgesi Silinemez.");
		}

		public static DialogResult RaporuTasarimaGonderMesaj()
		{
			return HayirSeciliEvetHayir("Rapor Tasarım Görünümünde Açılacaktır. Onaylıyor musunuz?", "Onay");
		}

		public static DialogResult RaporKapatmaMesaj()
		{
			return HayirSeciliEvetHayir("Rapor Kapatılacaktır. Onaylıyor musunuz?", "Onay");
		}

		public static DialogResult EmailGonderimOnayi()
		{
			return HayirSeciliEvetHayir("Kullanıcı Şifresi Sıfırlanarak, Kullanıcı Bilgilerini İçeren Yeni Bir E-Mail Gönderilecektir. Onaylıyor musunuz", "Onay");
		}
	}
}
