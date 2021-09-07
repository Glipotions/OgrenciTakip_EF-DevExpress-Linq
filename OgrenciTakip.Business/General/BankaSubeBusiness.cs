using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class BankaSubeBusiness : BaseGenelBusiness<BankaSube>, IBaseCommonBusiness
	{
		public BankaSubeBusiness() : base(KartTuru.BankaSube)
		{
		}

		public BankaSubeBusiness(Control control) : base(control, KartTuru.BankaSube)
		{
		}
	}
}