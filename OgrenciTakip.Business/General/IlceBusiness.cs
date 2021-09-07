using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IlceBusiness : BaseGenelBusiness<Ilce>, IBaseCommonBusiness
	{

		public IlceBusiness() : base(KartTuru.Ilce) { }
		public IlceBusiness(Control ctrl) : base(ctrl, KartTuru.Ilce) { }
	}
}
