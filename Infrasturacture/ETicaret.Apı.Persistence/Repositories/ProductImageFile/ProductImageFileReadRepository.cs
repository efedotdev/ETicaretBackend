using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.ProductImageFile;

namespace ETicaretApı.Infrasturacture.Repositories.ProductImageFile;

public class ProductImageFileReadRepository : ReadRepository<Domain.Entities.File>, IProductImageFileReadRepository
{
    public ProductImageFileReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}