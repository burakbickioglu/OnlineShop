using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {
        public int AdminId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public decimal Bakiye { get; set; }

    }
}
