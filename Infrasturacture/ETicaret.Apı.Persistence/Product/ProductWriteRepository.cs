using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.ProductRepo;
using ETicaretApı.Domain.Entities;

namespace ETicaret.Apı.Persistence;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}