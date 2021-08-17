using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class RehberBusiness : BaseGenelBusiness<Rehber>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public RehberBusiness() : base(KartTuru.Rehber) { }

		public RehberBusiness(Control ctrl) : base(ctrl, KartTuru.Rehber) { }
	}
}
