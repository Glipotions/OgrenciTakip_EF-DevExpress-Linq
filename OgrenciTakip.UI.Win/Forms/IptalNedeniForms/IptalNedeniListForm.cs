using DevExpress.XtraEditors;
using OgrenciTakip.Business.General;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
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

namespace OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
	public partial class IptalNedeniListForm : BaseListForm
	{
		public IptalNedeniListForm()
		{
			InitializeComponent();
			Business = new IptalNedeniBusiness();
		}
		protected override void DegiskenleriDoldur()
		{
			Tablo = tablo;
			BaseKartTuru = KartTuru.IptalNedeni;
			FormShow = new ShowEditForms<IptalNedeniEditForm>();
			Navigator = longNavigator.Navigator;

		}

		protected override void Listele()
		{
			Tablo.GridControl.DataSource = ((IptalNedeniBusiness)Business).List(FilterFunctions.Filter<IptalNedeni>(AktifKartlariGoster));
		}


	}
}