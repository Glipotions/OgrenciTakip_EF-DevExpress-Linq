using DevExpress.Utils.Extensions;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.HizmetForms
{
	public partial class HizmetListForm : BaseListForm
	{
		private readonly Expression<Func<Hizmet, bool>> _filter;

		public HizmetListForm()
		{
			InitializeComponent();
			Business = new HizmetBusiness();
			_filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
		}

		public HizmetListForm(params object[] prm) : this() //yüklenme aşamasında parametresiz ctor çalışır
		{
			if (prm != null)
			{
				var panelGoster = (bool)prm[0];
				UstPanel.Visible = DateTime.Now.Date > AnaForm.DonemParametre.EgitimBaslamaTarihi && panelGoster;
			}

			_filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId && x.Durum == AktifKartlariGoster;
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Hizmet;
			FormShow = new ShowEditForms<HizmetEditForm>();
			Navigator = longNavigator.Navigator;
			TarihAyarla();
		}

		protected override void Listele()
		{
			var list = ((HizmetBusiness)Business).List(_filter);
			Tablo.GridControl.DataSource = list;

			if (!MultiSelect) return;
			if (list.Any()) //değer varsa
				EklenebilecekEntityVar = true;
			else
				Messages.KartBulunamadiMesaji("Kart");
		}

		private void TarihAyarla()
		{
			//(1:11:00)
			txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.DonemParametre.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemParametre.EgitimBaslamaTarihi : DateTime.Now.Date < AnaForm.DonemParametre.EgitimBaslamaTarihi ? AnaForm.DonemParametre.EgitimBaslamaTarihi : DateTime.Now.Date;

			txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.DonemParametre.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemParametre.DonemBitisTarihi : DateTime.Now.Date < AnaForm.DonemParametre.EgitimBaslamaTarihi ? AnaForm.DonemParametre.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemParametre.DonemBitisTarihi ? AnaForm.DonemParametre.DonemBitisTarihi : DateTime.Now.Date;

			txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.DonemParametre.EgitimBaslamaTarihi ? AnaForm.DonemParametre.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemParametre.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemParametre.DonemBitisTarihi ? DateTime.Now.Date : DateTime.Now.Date > AnaForm.DonemParametre.DonemBitisTarihi ? AnaForm.DonemParametre.DonemBitisTarihi : DateTime.Now.Date;
		}

		protected override void SelectEntity()
		{
			base.SelectEntity();

			if (MultiSelect)
				SelectedEntities.ForEach(x => ((HizmetL)x).BaslamaTarihi = txtHizmetBaslamaTarihi.DateTime.Date);
		}
	}
}