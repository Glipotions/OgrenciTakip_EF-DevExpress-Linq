using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class IptalNedeniBusiness : BaseGenelBusiness<IptalNedeni>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public IptalNedeniBusiness() : base(KartTuru.IptalNedeni)
		{
		}

		public IptalNedeniBusiness(Control ctrl) : base(ctrl, KartTuru.IptalNedeni)
		{
		}
	}
}
