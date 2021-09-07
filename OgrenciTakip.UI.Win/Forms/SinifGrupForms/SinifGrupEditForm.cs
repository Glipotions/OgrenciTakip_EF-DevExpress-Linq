using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
	public partial class SinifGrupEditForm : BaseEditForm
	{
		public SinifGrupEditForm()
		{
			InitializeComponent();

			DataLayoutControl = myDataLayoutControl;
			Business = new SinifGrupBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.SinifGrup;
			EventsLoad();
		}

		protected internal override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new SinifGrup() : ((SinifGrupBusiness)Business).Single(FilterFunctions.Filter<SinifGrup>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((SinifGrupBusiness)Business).YeniKodVer();
			txtGrupAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (SinifGrup)OldEntity;

			txtKod.Text = entity.Kod;
			txtGrupAdi.Text = entity.GrupAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new SinifGrup
			{
				Id = Id,
				Kod = txtKod.Text,
				GrupAdi = txtGrupAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}