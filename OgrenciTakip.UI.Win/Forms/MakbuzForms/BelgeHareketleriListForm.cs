using DevExpress.XtraBars;
using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
	public partial class BelgeHareketleriListForm : BaseListForm
	{
		private readonly int _odemeBilgileriId;

		public BelgeHareketleriListForm(params object[] prm)
		{
			InitializeComponent();
			HideItems = new BarItem[] { btnYeni, btnSil, btnSec, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, barEnter, barEnterAciklama };

			_odemeBilgileriId = (int)prm[0];
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.BelgeHareketleri;
			Navigator = longNavigator.Navigator;
			Navigator.TextStringFormat = "Belge Hareketleri ( {0} / {1} )";
		}

		protected override void Listele()
		{
			using (var Business = new BelgeHareketleriBusiness())
			{
				var list = Business.List(x => x.OdemeBilgileriId == _odemeBilgileriId).Cast<BelgeHareketleriL>().ToList();
				if (!list.Any())
				{
					Messages.UyariMesaji("Seçtimiş Olduğunuz Ödeme Belgesine Ait Hareket Bulunmamaktadır.");
					Close();
					return;
				}

				var entity = list[0];

				txtNo.Text = entity.OgrenciNo;
				txtAdi.Text = entity.Adi;
				txtSoyadi.Text = entity.Soyadi;
				txtSinifadi.Text = entity.SinifAdi;
				txtSubeAdi.Text = entity.OgrenciSubeAdi;
				txtPortfoyNo.EditValue = entity.OdemeBilgileriId;
				txtOdemeTuru.Text = entity.OdemeTuruAdi;
				txtGirisTarihi.DateTime = entity.GirisTarihi;
				txtVade.DateTime = entity.Vade;
				txtHesabaGecisTarihi.DateTime = entity.HesabaGecisTarihi;
				txtTutar.Value = entity.Tutar;
				txtAsilBorclu.Text = entity.AsilBorclu;
				txtCiranta.Text = entity.Ciranta;
				txtBankaAdi.Text = entity.BankaAdi;
				txtBankaSubeAdi.Text = entity.BankaSubeAdi;
				txtHesapNo.Text = entity.HesapNo;
				txtBelgeNo.Text = entity.BelgeNo;

				grid.DataSource = list;
			}
		}

		protected override void ShowEditForm(long id)
		{
			var entity = tablo.GetRow<BelgeHareketleriL>();
			if (entity == null) return;

			if (entity.SubeId != AnaForm.SubeId)
				ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru, true);
			else
			{
				var result = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru);
				ShowEditFormDefault(result);
			}
		}
	}
}