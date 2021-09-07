using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class KontenjanBusiness : BaseGenelBusiness<Kontenjan>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public KontenjanBusiness() : base(KartTuru.Kontenjan) { }

		public KontenjanBusiness(Control ctrl) : base(ctrl, KartTuru.Kontenjan) { }
	}
}