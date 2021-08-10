﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
	public partial class AileBilgiListForm : BaseListForm
	{
		public AileBilgiListForm()
		{
			InitializeComponent();

			Business = new AileBilgiBusiness();

		}

		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.AileBilgi;
			FormShow = new ShowEditForms<AileBilgiEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((AileBilgiBusiness)Business).List(FilterFunctions.Filter<AileBilgi>(AktifKartlariGoster));
		}
	}
}