using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IsyeriBusiness : BaseGenelBusiness<Isyeri>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public IsyeriBusiness() : base(KartTuru.Isyeri) { }

		public IsyeriBusiness(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
	}
}