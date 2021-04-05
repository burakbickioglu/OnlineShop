using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Stok : IEntity
    {
        [Key]
        public int StokKod { get; set; }
        public int KullaniciId { get; set; }
        public int UrunId { get; set; }
        public int UrunMiktar { get; set; }
        public bool UrunOnay { get; set; }

    }
}
