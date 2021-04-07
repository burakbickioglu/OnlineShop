 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        [Key]
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public string eMail { get; set; }
        public string TcNo { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }


    }
}
