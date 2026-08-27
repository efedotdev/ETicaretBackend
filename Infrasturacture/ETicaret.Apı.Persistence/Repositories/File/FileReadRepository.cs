using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.File;

namespace ETicaretApı.Infrasturacture.Repositories.File;

public class FileReadRepository :ReadRepository<Domain.Entities.File>, IFileReadRepository
{
    public FileReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}