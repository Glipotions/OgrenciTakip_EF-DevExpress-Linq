using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IlBusiness : BaseGenelBusiness<Il>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public IlBusiness() : base(KartTuru.Il) { }
		public IlBusiness(Control ctrl) : base(ctrl, KartTuru.Il) { }
	}
}
