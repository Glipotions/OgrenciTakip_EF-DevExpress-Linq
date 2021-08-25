using System.ComponentModel.DataAnnotations.Schema;
using OgrenciYazilim.Model.Entities;
using OgrenciYazilim.Model.Entities.Base.Interfaces;

namespace OgrenciYazilim.Model.Dto
{
    [NotMapped]
    public class AileBilgileriL : AileBilgileri, IBaseHareketEntity
    {
        public string BilgiAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}