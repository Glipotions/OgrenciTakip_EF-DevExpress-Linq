using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model;
using OgrenciYazilim.Common.Enums;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class EvrakBusiness : BaseGenelBusiness<Evrak>, IBaseCommonBusiness  //interface yapısına uymadığı için IBaseGenelBusiness'den implemente edilmedi
	{
		public EvrakBusiness() : base(KartTuru.Evrak)
		{
		}

		public EvrakBusiness(Control control) : base(control, KartTuru.Evrak)
		{
		}
	}
}
