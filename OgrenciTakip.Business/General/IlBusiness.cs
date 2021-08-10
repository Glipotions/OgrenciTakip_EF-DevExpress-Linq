using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IlBusiness : BaseGenelBusiness<Il>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public IlBusiness() : base(KartTuru.Il) { }
		public IlBusiness(Control ctrl) : base(ctrl, KartTuru.Il) { }
	}
}
