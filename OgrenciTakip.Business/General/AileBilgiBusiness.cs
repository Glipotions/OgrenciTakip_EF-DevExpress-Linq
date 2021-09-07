using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class AileBilgiBusiness : BaseGenelBusiness<AileBilgi>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public AileBilgiBusiness() : base(KartTuru.AileBilgi) { }

		public AileBilgiBusiness(Control ctrl) : base(ctrl, KartTuru.AileBilgi) { }
	}
}
