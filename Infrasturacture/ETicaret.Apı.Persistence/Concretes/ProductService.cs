using ETicaretApı.Application.Abstractions;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence.Concretes;

public class ProductService:IProductService
{
    public List<Product> GetProducts()
        => new()
        {
            
            new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name = "Product 1",
                Price = 700,
                Stock = 10
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name = "Product 2",
                Price = 200,
                Stock = 10
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name = "Product 3",
                Price = 500,
                Stock = 10
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name = "Product 4",
                Price = 400,
                Stock = 10
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name = "Product 5",
                Price = 300,
                Stock = 10
            } 
        };
}