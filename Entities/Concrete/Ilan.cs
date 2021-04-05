using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Ilan : IEntity
    {
        [Key]
        public int IlanId { get; set; }
        public int SaticiId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public bool Durum { get; set; }
    }
}
