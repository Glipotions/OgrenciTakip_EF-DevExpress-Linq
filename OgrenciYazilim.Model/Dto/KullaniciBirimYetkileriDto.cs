using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KullaniciBirimYetkileriL : KullaniciBirimYetkileri, IBaseHareketEntity
    {
        public string Kod { get; set; }
        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}