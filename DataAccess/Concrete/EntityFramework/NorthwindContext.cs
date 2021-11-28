using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context nesnesi Db tabloları ile proje classlarını bağlar.
    public class NorthwindContext:DbContext
    {
        //Bu metot proje hangi veri tabanı ile ilişkili olduğunu belirteceğimiz metottur.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");//Hangi veri tabanı? , Kullanıcı adı şifre ile bağlanma
        }
        //Hangi nesne hangi nesneye karşılık gelecek?
        public DbSet<Product> Products { get; set; }//Benim Product class ım veri tabanındaki Products tablosuna denk geliyor.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
