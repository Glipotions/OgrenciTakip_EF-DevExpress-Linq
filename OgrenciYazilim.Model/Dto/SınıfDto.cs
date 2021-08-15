using OgrenciTakip.Model.Entities;
using OgrenciYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYazilim.Model.Dto
{
    [NotMapped]  //Bu olanları veritabanında oluşturmaz
    public class SinifS : Sinif
    {
        public string GrupAdi { get; set; }
    }

    public class SinifL : BaseEntity
    {
        public string SinifAdi { get; set; }
        public string GrupAdi { get; set; }
        public int HedefOgrenciSayisi { get; set; }
        public decimal HedefCiro { get; set; }
        public string Aciklama { get; set; }
    }
}
