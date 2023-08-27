using Anita_Notherjoke.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anita_Notherjoke.Core.Bridges
{
    public class UserEmail
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int EmailId { get; set; }
        public Email Email { get; set; }
    }
}
