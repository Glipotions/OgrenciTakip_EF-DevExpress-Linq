using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class GecikmeAciklamalariS : GecikmeAciklamalari
    {
        public string KullaniciAdi { get; set; }
    }

    public class GecikmeAciklamalariL : BaseEntity
    {
        public int PortfoyNo { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Aciklama { get; set; }
    }
}
