using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //join atıyoruz.Linq ile
                //Ürünler ile kategorileri join et.Ürünlere p de kategorilere c de.(Eğer p deki CategoryId ile c deki CategoryId eşitse)
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto {ProductId=p.ProductId,ProductName=p.ProductName,//Hangi column ları istiyosun?
                                 CategoryName=c.CategoryName,UnitsInStock=p.UnitsInStock };

                return result.ToList();
            }
        }
    }
}
