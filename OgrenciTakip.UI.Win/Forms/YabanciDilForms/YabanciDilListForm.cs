﻿using OgrenciTakip.Business.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
	public partial class YabanciDilListForm : BaseListForm
	{
		public YabanciDilListForm()
		{
			InitializeComponent();
			Business = new YabanciDilBusiness();
		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.YabanciDil;
			FormShow = new ShowEditForms<YabanciDilEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((YabanciDilBusiness)Business).List(FilterFunctions.Filter<YabanciDil>(AktifKartlariGoster));
		}
	}
}