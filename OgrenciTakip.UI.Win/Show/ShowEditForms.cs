using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities.Base.Interfaces;
using System;

namespace OgrenciTakip.UI.Win.Show
{
	public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
	{
		public long ShowDialogEditForm(KartTuru kartTuru, long id)
		{
			//Yetki Kontrolü
			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
			{
				frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
				frm.Id = id;
				frm.Yukle();
				frm.ShowDialog();
				return frm.RefreshYapilacak ? frm.Id : 0;
			}
		}

		public static long ShowDialogEditForm(KartTuru kartTuru, long id, params object[] prm)
		{
			//Yetki Kontrolü
			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
			{
				frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
				frm.Id = id;
				frm.Yukle();
				frm.ShowDialog();
				return frm.RefreshYapilacak ? frm.Id : 0;
			}
		}

		public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
		{
			using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
			{
				frm.Yukle();
				frm.ShowDialog();
				return (T)frm.ReturnEntity();
			}
		}
	}
}
