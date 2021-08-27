using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class PromosyonBusiness : BaseGenelBusiness<Promosyon>, IBaseCommonBusiness
	{
		public PromosyonBusiness() : base(KartTuru.Promosyon)
		{
		}

		public PromosyonBusiness(Control control) : base(control, KartTuru.Promosyon)
		{
		}
	}
}