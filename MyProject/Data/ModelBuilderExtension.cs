using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Cookies", Description = "Freshly Baked Choco chip Cookies", Price = 25.50f, ImageName = "Cookies.jpg" },
                new Product { Id = 2, Name = "Croissant", Description = "Delicious Baked Croissant", Price = 55.50f, ImageName = "croissant.jpg" },
                new Product { Id = 3, Name = "Donut", Description = "Chololate Donut", Price = 25.50f, ImageName = "Choco_Donut.jpg" }
                );

            return builder;
        }

        //public static void SeedData(ModelBuilder builder)
        //{
        //    builder.Entity<Product>().HasData(
        //        new Product { Id = 1, Name = "Cookies", Description = "Freshly Baked Choco chip Cookies", Price = 25.50f, ImageName = "Cookies.jpg" },
        //        new Product { Id = 2, Name = "Croissant", Description = "Delicious Baked Croissant", Price = 55.50f, ImageName = "croissant.jpg" },
        //        new Product { Id = 3, Name = "Donut", Description = "Chololate Donut", Price = 25.50f, ImageName = "Choco_Donut.jpg" }
        //        );           
        //}
    }
}
