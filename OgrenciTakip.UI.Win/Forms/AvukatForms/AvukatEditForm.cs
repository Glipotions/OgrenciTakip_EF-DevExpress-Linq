using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.Forms.AvukatForms
{
	public partial class AvukatEditForm : BaseEditForm
	{
		public AvukatEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new AvukatBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Avukat;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AvukatS() : ((AvukatBusiness)Business).Single(FilterFunctions.Filter<Avukat>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((AvukatBusiness)Business).YeniKodVer();
			txtAdiSoyadi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (AvukatS)OldEntity;

			txtKod.Text = entity.Kod;
			txtAdiSoyadi.Text = entity.AdiSoyadi;
			txtSozlesmeNo.Text = entity.SozlesmeNo;
			txtBaslamaTarihi.EditValue = entity.SozlesmeBaslamaTarihi;//datetime?(nullable)(boş geçilebilir) ise editvalue kullanılır
			txtBitisTarihi.EditValue = entity.SozlesmeBitisTarihi;//datetime?(nullable)(boş geçilebilir) ise editvalue kullanılır
			txtOzelKod1.Id = entity.OzelKod1Id;
			txtOzelKod1.Text = entity.OzelKod1Adi;
			txtOzelKod2.Id = entity.OzelKod2Id;
			txtOzelKod2.Text = entity.OzelKod2Adi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Avukat
			{
				Id = Id,
				Kod = txtKod.Text,
				AdiSoyadi = txtAdiSoyadi.Text,
				SozlesmeNo = txtSozlesmeNo.Text,
				SozlesmeBaslamaTarihi = (DateTime?)txtBaslamaTarihi.EditValue,
				SozlesmeBitisTarihi = (DateTime?)txtBitisTarihi.EditValue,
				OzelKod1Id = txtOzelKod1.Id,
				OzelKod2Id = txtOzelKod2.Id,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};
		}

		protected override void SecimYap(object sender)
		{
			if (!(sender is ButtonEdit)) return;

			using (var sec = new SelectFunctions())
			{
				if (sender == txtOzelKod1)
					sec.Sec(txtOzelKod1, KartTuru.Avukat);
				else if (sender == txtOzelKod2)
					sec.Sec(txtOzelKod2, KartTuru.Avukat);
			}
		}
	}
}