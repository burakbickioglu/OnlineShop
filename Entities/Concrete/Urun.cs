using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Urun : IEntity
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
    }
}
