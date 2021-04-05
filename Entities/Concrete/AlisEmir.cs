using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{ 
    public class AlisEmir : IEntity
    {
        [Key]
        public int EmirId { get; set; }
        public int AliciId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public bool Durum { get; set; }

    }
}
