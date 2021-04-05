using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Bakiye : IEntity
    {
        [Key]
        public int KullaniciId { get; set; }
        public decimal MevcutBakiye { get; set; }
        public decimal EklenecekBakiye { get; set; }
        public bool BakiyeOnay { get; set; }

    }
}
