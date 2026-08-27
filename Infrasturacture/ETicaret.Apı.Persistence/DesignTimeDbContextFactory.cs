using ETicaret.Apı.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaret.Apı.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
{
    public ETicaretAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretAPIDbContext> contextOptionsBuilder = new();
        contextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
        return new(contextOptionsBuilder.Options);
    }
}