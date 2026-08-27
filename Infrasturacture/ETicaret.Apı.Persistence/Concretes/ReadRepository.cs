using System.Linq.Expressions;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories;
using ETicaretApı.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Apı.Persistence.Concretes;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    readonly ETicaretAPIDbContext _context;

    public ReadRepository(ETicaretAPIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.Where(method).AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.Where(method).AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(method);
    }

    public async Task<T> GetByIdAsync(string id, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
    }
}