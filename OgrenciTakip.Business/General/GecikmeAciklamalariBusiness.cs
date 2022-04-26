using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Business.General
{
    public class GecikmeAciklamalariBusiness : BaseGenelBusiness<GecikmeAciklamalari>, IBaseCommonBusiness
    {
        public GecikmeAciklamalariBusiness() : base(KartTuru.GecikmeAciklamalari) { }

        public GecikmeAciklamalariBusiness(Control control) : base(control, KartTuru.GecikmeAciklamalari) { }

        public override BaseEntity Single(Expression<Func<GecikmeAciklamalari, bool>> filter)
        {
            return BaseSingle(filter, x => new GecikmeAciklamalariS
            {
                Id = x.Id,
                Kod = x.Kod,
                OdemeBilgileriId = x.OdemeBilgileriId,
                KullaniciAdi = x.Kullanici.Kod,
                TarihSaat = x.TarihSaat,
                Aciklama = x.Aciklama
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<GecikmeAciklamalari, bool>> filter)
        {
            return BaseList(filter, x => new GecikmeAciklamalariL
            {
                Id = x.Id,
                Kod = x.Kod,
                KullaniciAdi = x.Kullanici.Kod,
                TarihSaat = x.TarihSaat,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}