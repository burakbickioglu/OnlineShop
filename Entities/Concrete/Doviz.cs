using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Doviz : IEntity
    {
        // Bu sınıf sisteme daha sonra implemente edilmiştir
        public int DovizId { get; set; }
        public string DovizAd { get; set; }

    }
}
