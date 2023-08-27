using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anita_Notherjoke.Core.Entities;

namespace Anita_Notherjoke.DataAccess.Repositories.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseClass
    {
        void CreateEntity(T entity);
    }
}
