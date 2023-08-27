using Anita_Notherjoke.Core.Bridges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anita_Notherjoke.Core.Entities;

public class Email
{
    public string EmailTitle { get; set; }
    public string EmailContent { get; set; }
    public ICollection<string> Recipients { get; set; } = new List<string>();
    public ICollection<UserEmail> UserEmails { get; set; } = new List<UserEmail>();

}
