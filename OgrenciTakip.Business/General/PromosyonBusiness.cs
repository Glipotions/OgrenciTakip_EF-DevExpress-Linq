using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
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