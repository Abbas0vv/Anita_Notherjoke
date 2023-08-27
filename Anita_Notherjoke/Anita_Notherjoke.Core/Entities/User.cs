using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anita_Notherjoke.Core.Entities;

public class User
{
    public string Username { get; set; }
    public ICollection<UserEmail> UserEmails { get; set; } = new List<UserEmail>();

}
