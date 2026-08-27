using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.ProductRepo;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence;

public class ProductReadRepository : ReadRepository<Product>,IProductReadRepository
{
    public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}