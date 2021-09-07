using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class ServisBusiness : BaseGenelBusiness<Servis>, IBaseCommonBusiness
	{
		public ServisBusiness() : base(KartTuru.Servis)
		{
		}

		public ServisBusiness(Control control) : base(control, KartTuru.Servis)
		{
		}
	}
}