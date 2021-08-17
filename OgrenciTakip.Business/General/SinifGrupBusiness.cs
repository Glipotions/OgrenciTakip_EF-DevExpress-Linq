﻿using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Business.General
{
	public class SinifGrupBusiness : BaseGenelBusiness<SinifGrup>, IBaseGenelBusiness, IBaseCommonBusiness
	{
		public SinifGrupBusiness() : base(KartTuru.SinifGrup) { }

		public SinifGrupBusiness(Control ctrl) : base(ctrl, KartTuru.SinifGrup) { }
	}
}