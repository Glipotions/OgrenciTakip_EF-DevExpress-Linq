using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities.Base;
using System;
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

		public static void ShowListForm(KartTuru kartTuru,params object[] prm)
		{
			//Yetki Kontrolü

			var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm);
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

	}
}
