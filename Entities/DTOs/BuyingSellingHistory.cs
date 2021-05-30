using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Entities.Abstract;

namespace Entities.DTOs
{
    public class BuyingSellingHistory : IDto
    { 
        // bu dto sınıfında kullanıcının geçmiş alışverişini tutuyor, kullanıcıya raporluyoruz
        public string AliciAdi { get; set; }
        public string SaticiAdi { get; set; }
        public string UrunAdi { get; set; }
        public int Miktar { get; set; }
        public decimal ToplamFiyat { get; set; }
        public DateTime Tarih { get; set; }


    }
}
