using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakip.Business.Base;
using OgrenciTakip.Business.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Business.General
{
    public class KurumBilgileriBusiness : BaseGenelBusiness<KurumBilgileri>, IBaseGenelBusiness, IBaseCommonBusiness
    {
        public KurumBilgileriBusiness(Control control) : base(control)
        {
        }

        public override BaseEntity Single(Expression<Func<KurumBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new KurumBilgileriS
            {
                Id = x.Id,
                Kod = x.Kod,
                KurumAdi = x.KurumAdi,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi
            });
        }
    }
}