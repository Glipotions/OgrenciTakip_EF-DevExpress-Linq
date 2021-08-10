using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IlceBusiness : BaseGenelBusiness<Ilce>, IBaseCommonBusiness
	{

		public IlceBusiness() : base(KartTuru.Ilce) { }
		public IlceBusiness(Control ctrl) : base(ctrl, KartTuru.Ilce) { }
	}
}
