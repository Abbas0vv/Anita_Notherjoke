using Anita_Notherjoke.Core.Entities;
using Anita_Notherjoke.DataAccess.Context;
using Anita_Notherjoke.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Anita_Notherjoke.DataAccess.Repositories.Concretes;

public class ReadRepository<T> : IReadRepository<T> where T : BaseClass
{
    private readonly Anita_NotherjokeDbContext _context;

    public ReadRepository(Anita_NotherjokeDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();
        
    public T GetById(int id)
    {
        return Table.FirstOrDefault( t => t.Id == id);
    }
}
