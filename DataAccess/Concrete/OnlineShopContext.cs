using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class OnlineShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;database=OnlineShopping;Trusted_Connection=true");
        }

        public DbSet<Kullanici> tblKullanici { get; set; }
        public DbSet<Stok> tblStok { get; set; }
        public DbSet<Urun> tblUrun { get; set; }
        public DbSet<AlimSatim> tblAlimSatim { get; set; }
        public DbSet<Bakiye> tblBakiye { get; set; }
        public DbSet<Ilan> tblIlan { get; set; }
        public DbSet<AlisEmir> tblAlimEmri { get; set; }
        public DbSet<Doviz> tblDoviz { get; set; }

    }
}
