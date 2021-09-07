using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class GorevBusiness : BaseGenelBusiness<Gorev>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public GorevBusiness() : base(KartTuru.Gorev) { }

		public GorevBusiness(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
	}
}