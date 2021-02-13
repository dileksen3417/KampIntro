using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        //veritabanımızın olduğu yeri bağlayalım
        //override yani üzerine yazmak, OnConfiguring methodu DbContext classının içindeki bir methoddur ve tipi virtualdır
        //virtual imzaya sahip bir method override keywordu ile içerisi değiştirilerek kullanılabilir.

        //db bağlantısını sağlayalım
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");

        }
        //db tabloları ile classlarımızı ilişkilendirelim
        public DbSet<Product> Products { get; set; }  //<Product> : bizim projemizdeki class, Products: dbdeki tablonun adı
        public DbSet<Personel> Personels { get; set; }

        //Personel classım ile dbdeki Employees'i ilişkilendirebilmem için DbContext classının bir virtual methodu olan 
        //OnModelCreating methodunu override ederek kullanıyorum:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().ToTable("Employees"); // <Personel> isimli classımı git Employees tablosuyla bagla
            //kolonları baglayalım
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");

        }

    }
}
