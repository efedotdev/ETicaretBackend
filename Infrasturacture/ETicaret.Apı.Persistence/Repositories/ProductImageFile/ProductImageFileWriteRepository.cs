using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.ProductImageFile;

namespace ETicaretApı.Infrasturacture.Repositories.ProductImageFile;

public class ProductImageFileWriteRepository : WriteRepository<Domain.Entities.ProductImageFile> ,IProductImageFileWriteRepository
{
    public ProductImageFileWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}