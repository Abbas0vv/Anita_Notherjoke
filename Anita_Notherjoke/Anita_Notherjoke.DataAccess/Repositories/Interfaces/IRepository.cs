using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anita_Notherjoke.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anita_Notherjoke.DataAccess.Repositories.Interfaces;

public interface IRepository<T> where T:BaseClass
{
    DbSet<T> Table { get; }
}
