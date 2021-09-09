using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Business.General
{
	public class SubeBusiness : BaseGenelBusiness<Sube>, IBaseCommonBusiness, IBaseGenelBusiness
    {
        public SubeBusiness() : base(KartTuru.Sube)
        {
        }

        public SubeBusiness(Control control) : base(control, KartTuru.Sube)
        {
        }

        public override BaseEntity Single(Expression<Func<Sube, bool>> filter)
        {
            return BaseSingle(filter, x => new SubeS
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Adres = x.Adres,
                AdresIlId = x.AdresIlId,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceId = x.AdresIlceId,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
                Telefon = x.Telefon,
                Fax = x.Fax,
                IbanNo = x.IbanNo,
                GrupAdi = x.GrupAdi,
                SiraNo = x.SiraNo,
                Logo = x.Logo,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Sube, bool>> filter)
        {
            return BaseList(filter, x => new SubeL
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Adres = x.Adres,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
                Telefon = x.Telefon,
                Fax = x.Fax,
                IbanNo = x.IbanNo,
                GrupAdi = x.GrupAdi,
                SiraNo = x.SiraNo,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}