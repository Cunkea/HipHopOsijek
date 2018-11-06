using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Model.Common
{
    public interface IPerson
    {
        SqlInt64 PersonId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        DateTime DateCreated { get; set; }
    }
}
