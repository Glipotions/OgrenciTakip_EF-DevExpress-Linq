using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
	public partial class IletisimEditForm : BaseEditForm
	{
		public IletisimEditForm()
		{
			InitializeComponent();
			DataLayoutControl = myDataLayoutControl;
			Business = new IletisimBusiness(myDataLayoutControl);
			txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>()); //kan grubu comboboxını Doldurur
			BaseKartTuru = KartTuru.Iletisim;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IletisimS() : ((IletisimBusiness)Business).Single(FilterFunctions.Filter<Iletisim>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IletisimBusiness)Business).YeniKodVer();
			txtTcKimlikNo.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (IletisimS)OldEntity;

			txtKod.Text = entity.Kod;
			txtTcKimlikNo.Text = entity.TcKimlikNo;
			txtAdi.Text = entity.Adi;
			txtSoyadi.Text = entity.Soyadi;
			txtEvTel.Text = entity.EvTelefonu;
			txtIsTel1.Text = entity.IsTelefonu1;
			txtDahili1.Text = entity.Dahili1;
			txtIsTel2.Text = entity.IsTelefonu2;
			txtDahili2.Text = entity.Dahili2;
			txtCepTel1.Text = entity.CepTelefonu1;
			txtCepTel2.Text = entity.CepTelefonu2;
			txtWeb.Text = entity.Web;
			txtEmail.Text = entity.Email;
			txtIbanNo.Text = entity.IbanNo;
			txtKartNo.Text = entity.KartNo;

			txtEvAdres.Text = entity.EvAdres;
			txtEvAdresIl.Id = entity.EvAdresIlId;
			txtEvAdresIl.Text = entity.EvAdresIlAdi;
			txtEvAdresIlce.Id = entity.EvAdresIlceId;
			txtEvAdresIlce.Text = entity.EvAdresIlceAdi;

			txtIsAdres.Text = entity.IsAdres;
			txtIsAdresIl.Id = entity.IsAdresIlId;
			txtIsAdresIl.Text = entity.IsAdresIlAdi;
			txtIsAdresIlce.Id = entity.IsAdresIlceId;
			txtIsAdresIlce.Text = entity.IsAdresIlceAdi;

			txtMeslek.Id = entity.MeslekId;
			txtMeslek.Text = entity.MeslekAdi;

			txtIsyeri.Id = entity.IsyeriId;
			txtIsyeri.Text = entity.IsyeriAdi;

			txtGorev.Id = entity.GorevId;
			txtGorev.Text = entity.GorevAdi;

			txtBabaAdi.Text = entity.BabaAdi;
			txtAnaAdi.Text = entity.AnaAdi;
			txtDogumYeri.Text = entity.DogumYeri;
			txtDogumTarihi.EditValue = entity.DogumTarihi;          //önemli
			txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();        //ÖNEMLİ

			txtKimlikSeri.Text = entity.KimlikSeri;
			txtKimlikSiraNo.Text = entity.KimlikSiraNo;
			txtKimlikIl.Id = entity.KimlikIlId;
			txtKimlikIl.Text = entity.KimlikIlAdi;

			txtKimlikIlce.Id = entity.KimlikIlceId;
			txtKimlikIlce.Text = entity.KimlikIlceAdi;

			txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
			txtKimlikCiltNo.Text = entity.KimlikCiltNo;
			txtKimlikAileSiraNo.Text = entity.KimlikAileSiraNo;
			txtKimlikBireySiraNo.Text = entity.KimlikBireySiraNo;
			txtKimlikVerildigiYer.Text = entity.KimlikVerildigiYer;
			txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
			txtKimlikKayitNo.Text = entity.KimlikKayitNo;
			txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;

			txtOzelKod1.Id = entity.OzelKod1Id;
			txtOzelKod1.Text = entity.OzelKod1Adi;
			txtOzelKod2.Id = entity.OzelKod2Id;
			txtOzelKod2.Text = entity.OzelKod2Adi;

			txtAcıklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Iletisim
			{
				Id = Id,
				Kod = txtKod.Text,
				TcKimlikNo = txtTcKimlikNo.Text,
				Adi = txtAdi.Text,
				Soyadi = txtSoyadi.Text,
				EvTelefonu = txtEvTel.Text,
				IsTelefonu1 = txtIsTel1.Text,
				Dahili1 = txtDahili1.Text,
				IsTelefonu2 = txtIsTel2.Text,
				Dahili2 = txtDahili2.Text,
				CepTelefonu1 = txtCepTel1.Text,
				CepTelefonu2 = txtCepTel2.Text,
				Web = txtWeb.Text,
				Email = txtEmail.Text,
				IbanNo = txtIbanNo.Text,
				KartNo = txtKartNo.Text,
				EvAdres = txtEvAdres.Text,
				EvAdresIlId = txtEvAdresIl.Id,
				EvAdresIlceId = txtEvAdresIlce.Id,
				IsAdres = txtIsAdres.Text,
				IsAdresIlId = txtIsAdresIl.Id,
				IsAdresIlceId = txtIsAdresIlce.Id,
				MeslekId = txtMeslek.Id,
				IsyeriId = txtIsyeri.Id,
				GorevId = txtGorev.Id,
				BabaAdi = txtBabaAdi.Text,
				AnaAdi = txtAnaAdi.Text,
				DogumYeri = txtDogumYeri.Text,
				DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,//null değer alabildiği için böyle yapılacak.
				KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(), //önemli
				KimlikSeri = txtKimlikSeri.Text,
				KimlikSiraNo = txtKimlikSiraNo.Text,
				KimlikIlId = txtKimlikIl.Id,
				KimlikIlceId = txtKimlikIlce.Id,
				KimlikMahalleKoy = txtKimlikMahalleKoy.Text,
				KimlikCiltNo = txtKimlikCiltNo.Text,
				KimlikAileSiraNo = txtKimlikAileSiraNo.Text,
				KimlikBireySiraNo = txtKimlikBireySiraNo.Text,
				KimlikVerildigiYer = txtKimlikVerildigiYer.Text,
				KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
				KimlikKayitNo = txtKimlikKayitNo.Text,
				KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,//null değer alabildiği için böyle yapılacak.
				OzelKod1Id = txtOzelKod1.Id,
				OzelKod2Id = txtOzelKod2.Id,
				Aciklama = txtAcıklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}

		protected override void SecimYap(object sender)
		{
			if (!(sender is ButtonEdit)) return;

			using (var sec = new SelectFunctions())
			{
				if (sender == txtEvAdresIl)
					sec.Sec(txtEvAdresIl);
				else if (sender == txtEvAdresIlce)
					sec.Sec(txtEvAdresIlce, txtEvAdresIl);//ilçe seçmek için il Id de göndermek gerekli
				else if (sender == txtIsAdresIl)
					sec.Sec(txtIsAdresIl);
				else if (sender == txtIsAdresIlce)
					sec.Sec(txtIsAdresIlce, txtIsAdresIl);
				else if (sender == txtMeslek)
					sec.Sec(txtMeslek);
				else if (sender == txtIsyeri)
					sec.Sec(txtIsyeri);
				else if (sender == txtGorev)
					sec.Sec(txtGorev);
				else if (sender == txtKimlikIl)
					sec.Sec(txtKimlikIl);
				else if (sender == txtKimlikIlce)
					sec.Sec(txtKimlikIlce, txtKimlikIl);
				else if (sender == txtOzelKod1)
					sec.Sec(txtOzelKod1, KartTuru.Iletisim);
				else if (sender == txtOzelKod2)
					sec.Sec(txtOzelKod2, KartTuru.Iletisim);
			}
		}

		//ili silince ilçeninde silinmesi için event
		protected override void Control_EnabledChange(object sender, EventArgs e)
		{
			if (sender != txtEvAdresIl && sender != txtIsAdresIl && sender != txtKimlikIl) return;

			if (sender == txtEvAdresIl)
				txtEvAdresIl.ControlEnableChanged(txtEvAdresIlce);
			else if (sender == txtIsAdresIl)
				txtIsAdresIl.ControlEnableChanged(txtIsAdresIlce);
			else if (sender == txtKimlikIl)
				txtKimlikIl.ControlEnableChanged(txtKimlikIlce);
		}
	}
}