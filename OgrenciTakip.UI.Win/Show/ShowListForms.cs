using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities.Base;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Show
{
	public class ShowListForms<TForm> where TForm : BaseListForm
	{
		public static void ShowListForm(KartTuru kartTuru)
		{
			//Yetki Kontrolü

			var frm = (TForm)Activator.CreateInstance(typeof(TForm));
			frm.MdiParent = Form.ActiveForm;

			frm.Yukle();
			frm.Show();
		}

		public static void ShowListForm(KartTuru kartTuru, params object[] prm)
		{
			//Yetki Kontrolü

			var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
			frm.MdiParent = Form.ActiveForm;

			frm.Yukle();
			frm.Show();
		}

		public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
		{
			//Yetki Kontrolü

			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
			{
				frm.SeciliGelecekId = seciliGelecekId;
				frm.Yukle();
				frm.ShowDialog();

				return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
			}
		}

		public static void ShowDialogListForm()
		{
			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
			{
				frm.AktifPasifButonGoster = true;
				frm.Yukle();
				frm.ShowDialog();
			}
		}

		public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
		{
			//if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
			{
				frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
				frm.MultiSelect = multiSelect;
				frm.Yukle();
				frm.RowSelect = new SelectRowFunctions(frm.Tablo);

				if (frm.EklenebilecekEntityVar)
					frm.ShowDialog();

				return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
			}
		}

		public static IEnumerable<IBaseEntity> ShowDialogListForm(IList<long> listeDisiTutulacakKayitlar,
	bool multiSelect, params object[] prm)
		{
			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
			{
				frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
				frm.MultiSelect = multiSelect;
				frm.Yukle();
				frm.RowSelect = new SelectRowFunctions(frm.Tablo);

				if (frm.EklenebilecekEntityVar)
					frm.ShowDialog();

				return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
			}
		}

		public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiSelect, params object[] prm)
		{
			//if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
			{
				frm.MultiSelect = multiSelect;
				frm.Yukle();
				frm.RowSelect = new SelectRowFunctions(frm.Tablo);
				frm.ShowDialog();

				return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
			}
		}

	}
}
