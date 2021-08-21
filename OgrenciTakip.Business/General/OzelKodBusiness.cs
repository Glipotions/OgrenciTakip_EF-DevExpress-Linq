using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Common.Enums;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class OzelKodBusiness : BaseGenelBusiness<OzelKod>, IBaseCommonBusiness
	{
		public OzelKodBusiness() : base(KartTuru.OzelKod) { }

		public OzelKodBusiness(Control control) : base(control, KartTuru.OzelKod) { }
	}
}