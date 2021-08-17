﻿using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciYazilim.Common.Enums;
using OgrenciYazilim.Model.Entities;
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
