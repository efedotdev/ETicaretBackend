using System.Data;
using ETicaret.Apı.Persistence.Contexts;
using ETicaretApı.Application.Repositories;
using ETicaretApı.Domain.Entities;
using ETicaretApı.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaret.Apı.Persistence.Concretes;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly ETicaretAPIDbContext _context;

    public WriteRepository(ETicaretAPIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(IEnumerable<T> datas)
    {
        await Table.AddRangeAsync(datas);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;
    }

    public bool RemoveRange(IEnumerable<T> datas)
    {
        Table.RemoveRange(datas);
        return true;
    }

    public async Task<bool> RemoveAsync(string id)
    {
        T model = await Table.FindAsync(Guid.Parse(id));
        EntityEntry entityEntry = Table.Remove(model);
        return true;
    }

    public bool Update(T model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveChangesAsync()
        => await _context.SaveChangesAsync();
}