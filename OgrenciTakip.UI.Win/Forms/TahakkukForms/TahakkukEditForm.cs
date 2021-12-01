﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using OgrenciTakip.Business.Function;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;
using System;
using System.Drawing;
using System.Linq;
using Convert = System.Convert;
//using OgrenciTakip.UI.Win.UserControls.UserControl.KardesTahakkukEditFormTable;
//using OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;

namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
	public partial class TahakkukEditForm : BaseEditForm
	{
		private readonly Ogrenci _ogrenci;
		private BaseTablo _kardesBilgileriTable;
		private BaseTablo _aileBilgileriTable;
		private BaseTablo _sinavBilgileriTable;
		private BaseTablo _evrakBilgileriTable;
		private BaseTablo _promosyonBilgileriTable;
		private BaseTablo _iletisimBilgileriTable;
		private BaseTablo _ePosBilgileriTable;
		private BaseTablo _bilgiNotlariTable;

		public TahakkukEditForm()
		{
			InitializeComponent();

			DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
			Business = new TahakkukBusiness(DataLayoutGenelBilgiler);
			BaseKartTuru = KartTuru.Tahakkuk;
			EventsLoad();

			HideItems = new BarItem[] { btnYeni };
			ShowItems = new BarItem[] { btnYazdir };

			txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>());
			txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());
			txtSonrakiDonemKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SonrakiDonemKayitDurumu>());

			txtKayitTarihi.Properties.MinValue = AnaForm.DonemParametre.EgitimBaslamaTarihi;
			txtKayitTarihi.Properties.MaxValue = AnaForm.DonemParametre.DonemBitisTarihi;

			btnYazdir.Caption = "Kayıt Evrakları";
			KayitSonrasiFormuKapat = false;
		}

		public TahakkukEditForm(params object[] prm) : this()
		{
			if (prm[0] is Ogrenci ogr)
				_ogrenci = ogr;
			else if (prm[0] is bool yesNo)
				FarkliSubeIslemi = yesNo;

			//BAŞKA BİR KULLANIM

			//if (prm[0] is Ogrenci)
			//	_ogrenci = (Ogrenci)prm[0];

			//else if (prm[0] is bool)
			//	FarkliSubeIslemi = (bool)prm[0];
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new TahakkukS() : ((TahakkukBusiness)Business).Single(FilterFunctions.Filter<Tahakkuk>(Id));
			NesneyiKontrollereBagla();
			BagliTabloYukle();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((TahakkukBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
		}

		protected override void BagliTabloYukle()
		{
			bool TableValueChanged(BaseTablo tablo)
			{
				return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
			}

			if (_kardesBilgileriTable != null && TableValueChanged(_kardesBilgileriTable))
				_kardesBilgileriTable.Yukle();

			if (_aileBilgileriTable != null && TableValueChanged(_aileBilgileriTable))
				_aileBilgileriTable.Yukle();

			if (_sinavBilgileriTable != null && TableValueChanged(_sinavBilgileriTable))
				_sinavBilgileriTable.Yukle();

			if (_evrakBilgileriTable != null && TableValueChanged(_evrakBilgileriTable))
				_evrakBilgileriTable.Yukle();

			if (_promosyonBilgileriTable != null && TableValueChanged(_promosyonBilgileriTable))
				_promosyonBilgileriTable.Yukle();

			if (_iletisimBilgileriTable != null && TableValueChanged(_iletisimBilgileriTable))
				_iletisimBilgileriTable.Yukle();

			if (_ePosBilgileriTable != null && TableValueChanged(_ePosBilgileriTable))
				_ePosBilgileriTable.Yukle();

			if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
				_bilgiNotlariTable.Yukle();

			if (hizmetBilgileriTable.OwnerForm == null)
			{
				hizmetBilgileriTable.OwnerForm = this;
				hizmetBilgileriTable.Yukle();
			}

			if (indirimBilgileriTable.OwnerForm == null)
			{
				indirimBilgileriTable.OwnerForm = this;
				indirimBilgileriTable.Yukle();
			}

			if (odemeBilgileriTable.OwnerForm == null)
			{
				odemeBilgileriTable.OwnerForm = this;
				odemeBilgileriTable.Yukle();
				odemeBilgileriTable.insUptNavigator.Navigator.TextLocation = NavigatorButtonsTextLocation.Begin;
				odemeBilgileriTable.insUptNavigator.Navigator.TextStringFormat = "Taksit ( {0} / {1} )"; // alttarafta yazı
				odemeBilgileriTable.insUptNavigator.Navigator.Appearance.ForeColor = SystemColors.HotTrack; //renk ataması
			}

			if (geriOdemeBilgileriTable.OwnerForm == null)
			{
				geriOdemeBilgileriTable.OwnerForm = this;
				geriOdemeBilgileriTable.Yukle();
			}

			if (TableValueChanged(hizmetBilgileriTable))
			{
				var rowHandle = hizmetBilgileriTable.Tablo.FocusedRowHandle;
				hizmetBilgileriTable.Yukle();
				hizmetBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
			}

			if (TableValueChanged(indirimBilgileriTable))
			{
				var rowHandle = indirimBilgileriTable.Tablo.FocusedRowHandle;
				indirimBilgileriTable.Yukle();
				indirimBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
			}

			if (TableValueChanged(odemeBilgileriTable))
			{
				var rowHandle = odemeBilgileriTable.Tablo.FocusedRowHandle;
				odemeBilgileriTable.Yukle();
				odemeBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
			}

			if (TableValueChanged(geriOdemeBilgileriTable))
			{
				var rowHandle = geriOdemeBilgileriTable.Tablo.FocusedRowHandle;
				geriOdemeBilgileriTable.Yukle();
				geriOdemeBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
			}

			Toplamlar();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (TahakkukS)OldEntity;

			txtTcKimlikNo.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.TcKimlikNo : entity.TcKimlikNo;
			txtAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
			txtSoyadi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Soyadi : entity.Soyadi;
			txtBabaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.BabaAdi;
			txtAnaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
			txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.ToName() : IptalDurumu.IptalEdildi.ToName();

			txtKod.Text = entity.Kod;
			txtOkulNo.Text = entity.OkulNo;
			txtKayitTarihi.DateTime = entity.KayitTarihi;
			txtKayitSekli.SelectedItem = entity.KayitSekli.ToName();
			txtKayitDurumu.SelectedItem = entity.KayitDurumu.ToName();

			txtSinif.Id = entity.SinifId;
			txtSinif.Text = entity.SinifAdi;

			txtYabanciDil.Id = entity.YabanciDilId;
			txtYabanciDil.Text = entity.YabanciDilAdi;

			txtGeldigiOkul.Id = entity.GeldigiOkulId;
			txtGeldigiOkul.Text = entity.GeldigiOkulAdi;

			txtKontenjan.Id = entity.KontenjanId;
			txtKontenjan.Text = entity.KontenjanAdi;

			txtTesvik.Id = entity.TesvikId;
			txtTesvik.Text = entity.TesvikAdi;

			txtRehber.Id = entity.RehberId;
			txtRehber.Text = entity.RehberAdi;

			txtSonrakiDonemKayitDurumu.SelectedItem = entity.SonrakiDonemKayitDurumu.ToName();
			txtSonrakiDonemKayitDurumuAciklama.Text = entity.SonrakiDonemKayitDurumuAciklama;

			txtOzelKod1.Id = entity.OzelKod1Id;
			txtOzelKod1.Text = entity.OzelKod1Adi;
			txtOzelKod2.Id = entity.OzelKod2Id;
			txtOzelKod2.Text = entity.OzelKod2Adi;
			txtOzelKod3.Id = entity.OzelKod3Id;
			txtOzelKod3.Text = entity.OzelKod3Adi;
			txtOzelKod4.Id = entity.OzelKod4Id;
			txtOzelKod4.Text = entity.OzelKod4Adi;
			txtOzelKod5.Id = entity.OzelKod5Id;
			txtOzelKod5.Text = entity.OzelKod5Adi;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Tahakkuk
			{
				Id = Id,
				Kod = txtKod.Text,
				OgrenciId = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((Tahakkuk)OldEntity).OgrenciId,
				OkulNo = txtOkulNo.Text,
				KayitTarihi = txtKayitTarihi.DateTime.Date,
				KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
				KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
				SinifId = Convert.ToInt64(txtSinif.Id),
				YabanciDilId = txtYabanciDil.Id,
				GeldigiOkulId = txtGeldigiOkul.Id,
				KontenjanId = txtKontenjan.Id,
				TesvikId = txtTesvik.Id,
				RehberId = txtRehber.Id,
				SonrakiDonemKayitDurumu = txtSonrakiDonemKayitDurumu.Text.GetEnum<SonrakiDonemKayitDurumu>(),
				SonrakiDonemKayitDurumuAciklama = txtSonrakiDonemKayitDurumuAciklama.Text,

				OzelKod1Id = txtOzelKod1.Id,
				OzelKod2Id = txtOzelKod2.Id,
				OzelKod3Id = txtOzelKod3.Id,
				OzelKod4Id = txtOzelKod4.Id,
				OzelKod5Id = txtOzelKod5.Id,

				Durum = txtDurum.Text.GetEnum<IptalDurumu>() == IptalDurumu.DevamEdiyor,
				SubeId = AnaForm.SubeId,
				DonemId = AnaForm.DonemId,
			};

			ButtonEnabledDurumu();
		}

		protected override bool EntityInsert()
		{
			if (!DurumKontrol()) return false;

			if (BagliTabloHataliGirisKontrol()) return false;
			var result = ((TahakkukBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

			if (result && !KayitSonrasiFormuKapat)
				BagliTabloYukle();

			return result;
		}

		protected override bool EntityUpdate()
		{
			if (!DurumKontrol()) return false;

			if (BagliTabloHataliGirisKontrol()) return false;
			var result = ((TahakkukBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

			if (result && !KayitSonrasiFormuKapat)
				BagliTabloYukle();

			return result;
		}

		protected override bool BagliTabloHataliGirisKontrol()
		{
			if (_sinavBilgileriTable != null && _sinavBilgileriTable.HataliGiris())
			{
				tabUst.SelectedPage = pageAileSinavBilgileri;
				_sinavBilgileriTable.Tablo.GridControl.Focus();
				return true;
			}

			if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HataliGiris())
			{
				tabUst.SelectedPage = pageIletisimBilgileri;
				_iletisimBilgileriTable.Tablo.GridControl.Focus();
				return true;
			}

			if (_ePosBilgileriTable != null && _ePosBilgileriTable.HataliGiris())
			{
				tabUst.SelectedPage = pageEposBilgileri;
				_ePosBilgileriTable.Tablo.GridControl.Focus();
				return true;
			}

			if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
			{
				tabUst.SelectedPage = pageNotlar;
				_bilgiNotlariTable.Tablo.GridControl.Focus();
				return true;
			}

			if (hizmetBilgileriTable.HataliGiris())
			{
				tabAlt.SelectedPage = pageHizmetBilgileri;
				hizmetBilgileriTable.Tablo.GridControl.Focus();
				return true;
			}

			if (odemeBilgileriTable.HataliGiris())
			{
				tabAlt.SelectedPage = pageOdemeBilgileri;
				odemeBilgileriTable.Tablo.GridControl.Focus();
				return true;
			}

			if (geriOdemeBilgileriTable.HataliGiris())
			{
				tabAlt.SelectedPage = pageGeriOdemeBilgileri;
				geriOdemeBilgileriTable.Tablo.GridControl.Focus();
				return true;
			}

			return false;
		}

		protected override void SecimYap(object sender)
		{
			if (!(sender is ButtonEdit)) return;

			using (var sec = new SelectFunctions())
			{
				if (sender == txtSinif)
					sec.Sec(txtSinif);
				else if (sender == txtYabanciDil)
					sec.Sec(txtYabanciDil);
				else if (sender == txtGeldigiOkul)
					sec.Sec(txtGeldigiOkul);
				else if (sender == txtKontenjan)
					sec.Sec(txtKontenjan);
				else if (sender == txtTesvik)
					sec.Sec(txtTesvik);
				else if (sender == txtRehber)
					sec.Sec(txtRehber);
				else if (sender == txtOzelKod1)
					sec.Sec(txtOzelKod1, KartTuru.Tahakkuk);
				else if (sender == txtOzelKod2)
					sec.Sec(txtOzelKod2, KartTuru.Tahakkuk);
				else if (sender == txtOzelKod3)
					sec.Sec(txtOzelKod3, KartTuru.Tahakkuk);
				else if (sender == txtOzelKod4)
					sec.Sec(txtOzelKod4, KartTuru.Tahakkuk);
				else if (sender == txtOzelKod5)
					sec.Sec(txtOzelKod5, KartTuru.Tahakkuk);
			}
		}

		protected internal override void ButtonEnabledDurumu()
		{
			if (!IsLoaded) return;

			bool TableValueChanged()
			{
				//Tabloda yapılan değişiklikler sonrası kaydet butonunun gelmesi işlemleri
				if (_kardesBilgileriTable != null && _kardesBilgileriTable.TableValueChanged) return true;
				if (_aileBilgileriTable != null && _aileBilgileriTable.TableValueChanged) return true;
				if (_sinavBilgileriTable != null && _sinavBilgileriTable.TableValueChanged) return true;
				if (_evrakBilgileriTable != null && _evrakBilgileriTable.TableValueChanged) return true;
				if (_promosyonBilgileriTable != null && _promosyonBilgileriTable.TableValueChanged) return true;
				if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.TableValueChanged) return true;
				if (_ePosBilgileriTable != null && _ePosBilgileriTable.TableValueChanged) return true;
				if (_bilgiNotlariTable != null && _bilgiNotlariTable.TableValueChanged) return true;
				if (hizmetBilgileriTable.TableValueChanged) return true;
				if (indirimBilgileriTable.TableValueChanged) return true;
				if (odemeBilgileriTable.TableValueChanged) return true;
				if (geriOdemeBilgileriTable.TableValueChanged) return true;

				return false;
			}

			if (hizmetBilgileriTable.TableValueChanged || indirimBilgileriTable.TableValueChanged || odemeBilgileriTable.TableValueChanged || geriOdemeBilgileriTable.TableValueChanged) Toplamlar();


			if (FarkliSubeIslemi)
				Functions.GeneralFunctions.ButtonEnabledDurum(btnYeni, btnKaydet, btnGeriAl, btnSil);
			else
				Functions.GeneralFunctions.ButtonEnabledDurum(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, TableValueChanged());
		}

		protected override bool BagliTabloKaydet()
		{
			if (_kardesBilgileriTable != null && !_kardesBilgileriTable.Kaydet()) return false;
			if (_aileBilgileriTable != null && !_aileBilgileriTable.Kaydet()) return false;
			if (_sinavBilgileriTable != null && !_sinavBilgileriTable.Kaydet()) return false;
			if (_evrakBilgileriTable != null && !_evrakBilgileriTable.Kaydet()) return false;
			if (_promosyonBilgileriTable != null && !_promosyonBilgileriTable.Kaydet()) return false;
			if (_iletisimBilgileriTable != null && !_iletisimBilgileriTable.Kaydet()) return false;
			if (_ePosBilgileriTable != null && !_ePosBilgileriTable.Kaydet()) return false;
			if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;
			if (!hizmetBilgileriTable.Kaydet()) return false;
			if (!indirimBilgileriTable.Kaydet()) return false;
			if (!odemeBilgileriTable.Kaydet()) return false;
			if (!geriOdemeBilgileriTable.Kaydet()) return false;

			return true;
		}

		private void Toplamlar()
		{
			var hizmetBilgileriToplami = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Where(x => !x.Delete).Sum(x => x.BrutUcret - x.KistDonemDusulenUcret);

			var indirimBilgileriToplami = indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => !x.Delete).Sum(x => x.BrutIndirim - x.KistDonemDusulenIndirim);

			var odemeBilgileriToplami = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<OdemeBilgileriL>().Where(x => !x.Delete).Sum(x => x.Tutar);

			var iadelerToplami = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<OdemeBilgileriL>().Where(x => !x.Delete).Sum(x => x.Iade);

			var geriOdemelerToplami = geriOdemeBilgileriTable.Tablo.DataController.ListSource.Cast<GeriOdemeBilgileriL>().Where(x => !x.Delete).Sum(x => x.Tutar);

			txtHizmetBilgileriToplami.Value = hizmetBilgileriToplami;
			txtIndirimBilgileriToplami.Value = indirimBilgileriToplami;
			txtOdemeBilgileriToplami.Value = odemeBilgileriToplami;
			txtGeriIadelerToplami.Value = iadelerToplami;
			txtGeriOdemelerToplami.Value = geriOdemelerToplami;

			txtFark.Value = hizmetBilgileriToplami - indirimBilgileriToplami - (odemeBilgileriToplami - (iadelerToplami + geriOdemelerToplami));
			txtFark.Properties.Appearance.BackColor = txtFark.Value != 0 ? Color.IndianRed : Color.GreenYellow;
		}

		private bool DurumKontrol()
		{

			if (txtFark.Value != 0)
			{
				Messages.HataMesaji("Ücret Toplamları Farkı Sıfır ( 0 ) Olmalıdır");
				return false;
			}

			var source = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>();

			if (!source.Any(x => !x.Delete && !x.IptalEdildi && x.HizmetTipi == HizmetTipi.Egitim))
			{
				Messages.UyariMesaji("Eğitim Alınmadığı İçin Tahakkuk Pasif Duruma Alınacaktır.");
				txtDurum.Text = IptalDurumu.IptalEdildi.ToName();
			}
			else
				txtDurum.Text = IptalDurumu.DevamEdiyor.ToName();

			return true;
		}

		protected override void Yazdir()
		{
			if (pageIletisimBilgileri.Controls.Count == 0)
			{
				_iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
				pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
				_iletisimBilgileriTable.Yukle();
			}

			if (pageEposBilgileri.Controls.Count == 0)
			{
				_ePosBilgileriTable = new EposBilgileriTable().AddTable(this);
				pageEposBilgileri.Controls.Add(_ePosBilgileriTable);
				_ePosBilgileriTable.Yukle();
			}

			var ogrenciBilgileri = ((TahakkukBusiness)Business).SingleDetail(x => x.Id == Id);
			var iletisimBilgileri = _iletisimBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<IletisimBilgileriR>();
			//(4/6) 20.video 41:00  EntityListConvert IBaseEntity türündeki verilerden convert yapabiliyor o yüzden Cast ediyoruz
			var hizmetBilgileri = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<HizmetBilgileriR>();
			var indirimBilgileri = indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<IndirimBilgileriR>();
			var odemeBilgileri = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<OdemeBilgileriR>();
			var geriOdemeBilgileri = geriOdemeBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<GeriOdemeBilgileriR>();
			var ePosBilgileri = _ePosBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<EposBilgileriR>();

			ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.TahakkukRaporlari, ogrenciBilgileri, iletisimBilgileri, hizmetBilgileri, indirimBilgileri, odemeBilgileri, geriOdemeBilgileri, ePosBilgileri);
		}

		protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
		{
			if (e.Page == pageGenelBilgiler)
			{
				txtOkulNo.Focus();
				txtOkulNo.SelectAll();
			}
			else if (e.Page == pageKardesBilgileri)
			{
				if (pageKardesBilgileri.Controls.Count == 0)
				{
					_kardesBilgileriTable = new KardesBilgileriTable().AddTable(this);
					pageKardesBilgileri.Controls.Add(_kardesBilgileriTable);
					_kardesBilgileriTable.Yukle();
				}

				_kardesBilgileriTable.Tablo.GridControl.Focus();
			}
			else if (e.Page == pageAileSinavBilgileri)
			{
				if (layoutControlAileSinavBilgileri.Items.Count == 0)
				{
					_aileBilgileriTable = new AileBilgileriTable().AddTable(this);
					//pageAileSinavBilgileri.Controls.Add(_AileBilgileriTable);  hata verir 2 parçalı olduğu için
					layoutControlAileSinavBilgileri.LayoutControlInsert(_aileBilgileriTable, 0, 0, 0, 0);
					_aileBilgileriTable.Yukle();

					_sinavBilgileriTable = new SinavBilgileriTable().AddTable(this);
					layoutControlAileSinavBilgileri.LayoutControlInsert(_sinavBilgileriTable, 1, 0, 0, 0);
					_sinavBilgileriTable.Yukle();
				}

				_aileBilgileriTable.Tablo.GridControl.Focus();
			}
			else if (e.Page == pageEvrakPromosyonBilgileri)
			{
				if (layoutControlEvrakPromosyonBilgileri.Items.Count == 0)
				{
					_evrakBilgileriTable = new EvrakBilgileriTable().AddTable(this);
					layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_evrakBilgileriTable, 0, 0, 0, 0);
					_evrakBilgileriTable.Yukle();

					_promosyonBilgileriTable = new PromosyonBilgileriTable().AddTable(this);
					layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_promosyonBilgileriTable, 1, 0, 0, 0);
					_promosyonBilgileriTable.Yukle();
				}

				_evrakBilgileriTable.Tablo.GridControl.Focus();
			}
			else if (e.Page == pageIletisimBilgileri)
			{
				if (pageIletisimBilgileri.Controls.Count == 0)
				{
					_iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
					pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
					_iletisimBilgileriTable.Yukle();
				}

				_iletisimBilgileriTable.Tablo.GridControl.Focus();
			}
			else if (e.Page == pageEposBilgileri)
			{
				if (pageEposBilgileri.Controls.Count == 0)
				{
					_ePosBilgileriTable = new EposBilgileriTable().AddTable(this);
					pageEposBilgileri.Controls.Add(_ePosBilgileriTable);
					_ePosBilgileriTable.Yukle();
				}

				_ePosBilgileriTable.Tablo.GridControl.Focus();
			}
			else if (e.Page == pageNotlar)
			{
				if (pageNotlar.Controls.Count == 0)
				{
					_bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
					pageNotlar.Controls.Add(_bilgiNotlariTable);
					_bilgiNotlariTable.Yukle();
				}

				_bilgiNotlariTable.Tablo.GridControl.Focus();
			}
			else if (e.Page == pageHizmetBilgileri)
				hizmetBilgileriTable.Tablo.GridControl.Focus();
			else if (e.Page == pageIndirimBilgileri)
				indirimBilgileriTable.Tablo.GridControl.Focus();
			else if (e.Page == pageOdemeBilgileri)
				odemeBilgileriTable.Tablo.GridControl.Focus();
			else if (e.Page == pageGeriOdemeBilgileri)
				geriOdemeBilgileriTable.Tablo.GridControl.Focus();
		}
	}
}