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
    public class KullaniciBusiness : BaseGenelBusiness<Kullanici>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public KullaniciBusiness() : base(KartTuru.Kullanici)
        {
        }

        public KullaniciBusiness(Control control) : base(control, KartTuru.Kullanici)
        {
        }

        public override BaseEntity Single(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                RolId = x.RolId,
                RolAdi = x.Rol.RolAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public BaseEntity SingleDetail(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                RolId = x.RolId,
                RolAdi = x.Rol.RolAdi,
                Sifre = x.Sifre,
                GizliKelime = x.GizliKelime,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseList(filter, x => new KullaniciL
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                RolAdi = x.Rol.RolAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}