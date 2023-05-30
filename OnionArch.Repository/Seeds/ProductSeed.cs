using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArch.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 350, Stock = 40, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, Name = "Kalem 3", Price = 200, Stock = 5, CreatedDate = DateTime.Now },
                new Product { Id = 4, CategoryId = 2, Name = "Kitap 1", Price = 640, Stock = 17, CreatedDate = DateTime.Now });
        }
    }
}
