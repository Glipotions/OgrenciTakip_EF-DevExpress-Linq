using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Business.Base
{
    public class BaseGenelYonetimBusiness<TEntity> : BaseBusiness<TEntity, OgrenciTakipYonetimContext> where TEntity : BaseEntity
    {
        private KartTuru _kartTuru;

        public BaseGenelYonetimBusiness(KartTuru kartTuru)
        {
            _kartTuru = kartTuru;
        }

        public BaseGenelYonetimBusiness(Control control, KartTuru kartTuru) : base(control)
        {
            _kartTuru = kartTuru;
        }

        public virtual BaseEntity Single(Expression<Func<TEntity, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Insert(BaseEntity entity, Expression<Func<TEntity, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<TEntity, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public virtual bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, _kartTuru, false);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod);
        }

        public string YeniKodVer(Expression<Func<TEntity, bool>> filter)
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod, filter);
        }
    }
}