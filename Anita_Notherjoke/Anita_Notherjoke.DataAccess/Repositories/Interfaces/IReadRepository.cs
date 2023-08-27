using Anita_Notherjoke.DataAccess.Repositories.Interfaces;

namespace Anita_Notherjoke.DataAccess.Repositories.Interfaces;

public interface IReadRepository<T> : IRepository<T> where T : class
{
    T GetById(int id);
}
