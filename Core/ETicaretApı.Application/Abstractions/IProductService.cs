using ETicaretApı.Domain.Entities;

namespace ETicaretApı.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}