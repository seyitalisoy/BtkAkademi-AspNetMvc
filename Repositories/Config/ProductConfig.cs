using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            
            builder.HasData(
                new Product() { ProductId = 1, CategoryId=2, ImageUrl="/Images/mouse.jpg", ProductName = "Mouse", Price = 170, ShowCase=false },
                new Product() { ProductId = 2, CategoryId=2, ImageUrl="/Images/asusgamer.jpg", ProductName = "Asus", Price = 15_000, ShowCase=false },
                new Product() { ProductId = 3, CategoryId=2, ImageUrl="/Images/computer.jpg", ProductName = "Computer", Price = 17_000, ShowCase=false },
                new Product() { ProductId = 4, CategoryId=1, ImageUrl="/Images/devlet.jpg", ProductName = "Devlet", Price = 150, ShowCase=false },
                new Product() { ProductId = 5, CategoryId=1, ImageUrl="/images/galiz.jpg", ProductName = "Galiz", Price = 140, ShowCase=false },
                new Product() { ProductId = 6, CategoryId=1, ImageUrl="/images/amat.jpg", ProductName = "Amat", Price = 100, ShowCase=false },
                new Product() { ProductId = 7, CategoryId=1, ImageUrl="/images/anayasa.jpg", ProductName = "Anayasa 101", Price = 24_000, ShowCase=false },
                new Product() { ProductId = 8, CategoryId=1, ImageUrl="/images/8.jpg", ProductName = "Deccal", Price = 78, ShowCase=true },
                new Product() { ProductId = 9, CategoryId=2, ImageUrl="/images/9.jpg", ProductName = "Samsung Galaxy 10", Price = 24_000, ShowCase=true },
                new Product() { ProductId = 10, CategoryId=1, ImageUrl="/images/10.jpg", ProductName = "Hamlet", Price = 100, ShowCase=true }

            );
        }
    }
}