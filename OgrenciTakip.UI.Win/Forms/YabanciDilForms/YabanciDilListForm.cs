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