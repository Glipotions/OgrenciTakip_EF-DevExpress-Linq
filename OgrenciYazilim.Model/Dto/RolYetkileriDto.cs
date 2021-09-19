using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class RolYetkileriL : RolYetkileri, IBaseHareketEntity
    {
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}