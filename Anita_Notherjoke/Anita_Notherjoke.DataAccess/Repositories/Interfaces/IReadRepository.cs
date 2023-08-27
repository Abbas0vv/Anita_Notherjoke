using Anita_Notherjoke.Core.Entities;
using Anita_Notherjoke.DataAccess.Repositories.Interfaces;

namespace Anita_Notherjoke.DataAccess.Repositories.Interfaces;

public interface IReadRepository<T> : IRepository<T> where T : BaseClass
{
    T GetById(int id);
}
