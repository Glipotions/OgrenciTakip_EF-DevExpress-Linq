using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class RehberBusiness : BaseGenelBusiness<Rehber>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public RehberBusiness() : base(KartTuru.Rehber) { }

		public RehberBusiness(Control ctrl) : base(ctrl, KartTuru.Rehber) { }
	}
}
