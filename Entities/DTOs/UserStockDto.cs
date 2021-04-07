using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.DTOs
{
    public class UserStockDto : IDto
    {

        public int? StokKod { get; set; }
        public int? KullaniciId { get; set; }
        public string UrunAd { get; set; }
        public int? UrunMiktar { get; set; }
        public bool? UrunOnay { get; set; }
    }
}
