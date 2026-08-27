using ETicaret.Apı.Persistence.Concretes;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories;
using ETicaretApı.Application.Repositories.InvoiceFile;

namespace ETicaretApı.Infrasturacture.Repositories.InvoiceFile;

public class InvoiceFileReadRepository :  ReadRepository<Domain.Entities.File>,IInvoiceFileReadRepository
{
    public InvoiceFileReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}