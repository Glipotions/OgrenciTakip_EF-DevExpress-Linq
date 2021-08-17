using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class FiltreBusiness : BaseGenelBusiness<Filtre>, IBaseCommonBusiness
	{
		public FiltreBusiness() : base(KartTuru.Filtre) { }
		public FiltreBusiness(Control ctrl) : base(ctrl, KartTuru.Filtre) { }
	}
}