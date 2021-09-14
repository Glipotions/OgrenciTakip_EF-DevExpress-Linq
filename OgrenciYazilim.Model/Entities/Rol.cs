using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class Rol : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Rol Adı", "txtRolAdi")]
        public string RolAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}