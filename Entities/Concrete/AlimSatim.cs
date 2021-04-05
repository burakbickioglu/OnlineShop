using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class AlimSatim : IEntity
    {
        [Key]
        public int IslemId { get; set; }
        public int AliciId { get; set; }
        public int SaticiId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal ToplamFiyat { get; set; }

    }
}
