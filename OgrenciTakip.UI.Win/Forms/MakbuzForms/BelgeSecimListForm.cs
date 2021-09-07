using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
	public partial class BelgeSecimListForm : BaseListForm
	{
		private readonly Expression<Func<OdemeBilgileri, bool>> _filter;
		private readonly MakbuzTuru _makbuzTuru;
		private readonly MakbuzHesapTuru _makbuzHesapTuru;
		private long _hesapId;

		public BelgeSecimListForm(params object[] prm)
		{
			InitializeComponent();
			HideItems = new BarItem[] { btnYeni, btnSil, btnDuzelt, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, barDuzelt, barDuzeltAciklama };
			ShowItems = new BarItem[] { btnBelgeHareketleri };

			_makbuzTuru = (MakbuzTuru)prm[0];
			_makbuzHesapTuru = (MakbuzHesapTuru)prm[1];
			_hesapId = prm[2] != null ? (long)prm[2] : 0;

			_filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Tahakkuk.DonemId == AnaForm.DonemId;
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.Hizmet;// hata verebilir
			Navigator = longNavigator1.Navigator;
			Text = $"{Text} - {_makbuzTuru.ToName()} - ( {_makbuzHesapTuru.ToName()} )";
		}

		protected override void Listele()
		{
			using (var Business = new BelgeSecimBusiness())
			{
				var list = Business.List(_filter, _makbuzTuru, _makbuzHesapTuru, _makbuzHesapTuru.ToName().GetEnum<OdemeTipi>(), _hesapId, AnaForm.SubeId);
				tablo.GridControl.DataSource = list;

				if (!MultiSelect) return;
				if (list.Any())
					EklenebilecekEntityVar = true;
				else
					Messages.KartBulunamadiMesaji("Belge");
			}
		}

		protected override void SutunGizleGoster()
		{
			if (tablo.DataRowCount == 0) return;
			var entity = tablo.GetRow<BelgeSecimL>(false);
			if (entity == null) return;

			bndBelgeDetayBilgileri.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
			colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
			colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Pos || entity.OdemeTipi == OdemeTipi.Ots;
			colBankaAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
			colBankaSubeAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
			colHesapNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
			colBelgeNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
			colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
			colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
		}

		protected override void BelgeHareketleri()
		{
			var entity = tablo.GetRow<BelgeSecimL>();
			if (entity == null) return;

			ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.OdemeBilgileriId);
		}
	}
}