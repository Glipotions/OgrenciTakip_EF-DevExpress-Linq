using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base.Interfaces;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class BilgiNotlariL : BilgiNotlari, IBaseHareketEntity
    {
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}