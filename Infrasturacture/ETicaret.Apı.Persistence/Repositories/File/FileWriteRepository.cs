using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.File;

namespace ETicaretApı.Infrasturacture.Repositories.File;

public class FileWriteRepository : WriteRepository<Domain.Entities.File>,IFileWriteRepository
{
    public FileWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}