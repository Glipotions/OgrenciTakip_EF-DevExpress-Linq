using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.IndirimForms
{
	public partial class IndirimEditForm : BaseEditForm
	{
		public IndirimEditForm()
		{
			InitializeComponent();
			DataLayoutControl = myDataLayoutControl;
			Business = new IndirimBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Indirim;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IndirimS() : ((IndirimBusiness)Business).Single(FilterFunctions.Filter<Indirim>(Id));
			NesneyiKontrollereBagla();
			TabloYukle();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IndirimBusiness)Business).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
			txtIndirimAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (IndirimS)OldEntity;

			txtKod.Text = entity.Kod;
			txtIndirimAdi.Text = entity.IndirimAdi;
			txtIndirimTuru.Id = entity.IndirimTuruId;
			txtIndirimTuru.Text = entity.IndirimTuruAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Indirim
			{
				Id = Id,
				Kod = txtKod.Text,
				IndirimAdi = txtIndirimAdi.Text,
				IndirimTuruId = Convert.ToInt64(txtIndirimTuru.Id),       //ÖNEMLİ
				Aciklama = txtAciklama.Text,
				SubeId = AnaForm.SubeId,
				DonemId = AnaForm.DonemId,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}

		protected internal override void ButtonEnabledDurumu()
		{
			if (!IsLoaded) return;
			GeneralFunctions.ButtonEnabledDurum(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, indirimTablo.TableValueChanged);
		}

		protected override bool EntityInsert()
		{
			if (indirimTablo.HataliGiris()) return false;
			return ((IndirimBusiness)Business).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && indirimTablo.Kaydet();
		}

		protected override bool EntityUpdate()
		{
			if (indirimTablo.HataliGiris()) return false;
			return ((IndirimBusiness)Business).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && indirimTablo.Kaydet();
		}

		protected override void SecimYap(object sender)
		{
			if (!(sender is ButtonEdit)) return;

			using (var sec = new SelectFunctions())
			{
				if (sender == txtIndirimTuru)
					sec.Sec(txtIndirimTuru);
			}
		}

		protected override void TabloYukle()
		{
			indirimTablo.OwnerForm = this;
			indirimTablo.Yukle();
		}
	}
}