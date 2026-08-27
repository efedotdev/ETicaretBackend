using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories.InvoiceFile;

namespace ETicaretApı.Infrasturacture.Repositories.InvoiceFile;

public class InvoiceFileWriteRepository : WriteRepository<Domain.Entities.File>, IInvoiceFileWriteRepository
{
    public InvoiceFileWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}