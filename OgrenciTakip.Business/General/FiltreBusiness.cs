using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class FiltreBusiness : BaseGenelBusiness<Filtre>, IBaseCommonBusiness
	{
		public FiltreBusiness() : base(KartTuru.Filtre) { }
		public FiltreBusiness(Control ctrl) : base(ctrl, KartTuru.Filtre) { }
	}
}