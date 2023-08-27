using Anita_Notherjoke.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anita_Notherjoke.DataAccess.Context;

public class Anita_NotherjokeDbContext : DbContext
{
    public Anita_NotherjokeDbContext(DbContextOptions<Anita_NotherjokeDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Email> Emails { get; set; } = null!;

}
