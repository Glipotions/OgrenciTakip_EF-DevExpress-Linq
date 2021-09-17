using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
	public partial class IptalNedeniEditForm : BaseEditForm
	{
		public IptalNedeniEditForm()
		{
			InitializeComponent();


			DataLayoutControl = myDataLayoutControl;
			Business = new IptalNedeniBusiness(myDataLayoutControl);
			BaseKartTuru = KartTuru.IptalNedeni;
			EventsLoad();
		}

		public override void Yukle()
		{
			OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ?
			new IptalNedeni() : ((IptalNedeniBusiness)Business).Single(FilterFunctions.Filter<IptalNedeni>(Id));
			NesneyiKontrollereBagla();

			if (BaseIslemTuru != IslemTuru.EntityInsert) return;
			Id = BaseIslemTuru.IdOlustur(OldEntity);
			txtKod.Text = ((IptalNedeniBusiness)Business).YeniKodVer();
			txtIptalNedeniAdi.Focus();
		}

		protected override void NesneyiKontrollereBagla()
		{
			var entity = (IptalNedeni)OldEntity;

			txtKod.Text = entity.Kod;
			txtIptalNedeniAdi.Text = entity.IptalNedeniAdi;
			txtAciklama.Text = entity.Aciklama;
			tglDurum.IsOn = entity.Durum;
		}

		protected override void GuncelNesneOlustur()
		{
			CurrentEntity = new IptalNedeni
			{
				Id = Id,
				Kod = txtKod.Text,
				IptalNedeniAdi = txtIptalNedeniAdi.Text,
				Aciklama = txtAciklama.Text,
				Durum = tglDurum.IsOn
			};

			ButtonEnabledDurumu();
		}
	}
}