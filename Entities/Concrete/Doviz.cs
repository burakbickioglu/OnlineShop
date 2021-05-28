using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Doviz : IEntity
    {
        public int DovizId { get; set; }
        public string DovizAd { get; set; }

    }
}
