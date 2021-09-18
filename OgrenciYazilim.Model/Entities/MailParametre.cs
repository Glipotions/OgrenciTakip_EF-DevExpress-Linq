using System.ComponentModel.DataAnnotations;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class MailParametre : BaseEntity
    {
        [Required, StringLength(50), ZorunluAlan("E_mail", "txtEmail")]
        public string Email { get; set; }

        [Required, StringLength(50), ZorunluAlan("Email şifre", "txtSifre")]
        public string Sifre { get; set; }

        [ZorunluAlan("Port No", "txtPortNo")]
        public int PortNo { get; set; }

        [Required, StringLength(50), ZorunluAlan("Host", "txtHost")]
        public string Host { get; set; }

        public EvetHayir SslKullan { get; set; } = EvetHayir.Evet;
    }
}