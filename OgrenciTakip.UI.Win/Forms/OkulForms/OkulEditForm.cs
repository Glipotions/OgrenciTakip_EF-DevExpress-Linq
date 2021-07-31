using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Dto;
using OgrenciYazilim.Model.Entities;
using System;

namespace OgrenciTakip.UI.Win.Forms.OkulForms
{
	public partial class OkulEditForm : BaseEditForm
	{
		public OkulEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new OkulBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.Okul;
			EventsLoad();
		}
		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
				new OkulS() : ((OkulBusiness)Business).Single(FilterFunctions.Filter<Okul>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((OkulBusiness)Business).YeniKodVer();
			txtOkulAdi.Focus();

		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (OkulS)OldEntity;

			txtKod.Text = entity.Kod;
			txtOkulAdi.Text = entity.OkulAdi;
			txtIl.Id = entity.IlId;
			txtIl.Text = entity.IlAdi;
			txtIlce.Id = entity.IlceId;
			txtIlce.Text = entity.IlceAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new Okul
			{
				Id = Id,
				Kod = txtKod.Text,
				OkulAdi = txtOkulAdi.Text,
				IlId = Convert.ToInt64(txtIl.Id),
				IlceId = Convert.ToInt64(txtIlce.Id),
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}

		protected override void SecimYap(object sender)
		{
			if (!(sender is ButtonEdit)) return;

			using (var sec = new SelectFunction())
			{
				if (sender == txtIl)
					sec.Sec(txtIl);
				else if (sender == txtIlce)
					sec.Sec(txtIlce, txtIl);
			}
		}

		protected override void Control_EnabledChanged(object sender, EventArgs e)
		{
			if (sender != txtIl) return;
			txtIl.ControlEnableChanged(txtIlce);
		}
	}
}