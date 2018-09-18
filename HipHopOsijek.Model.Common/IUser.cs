using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Model.Common
{
    public interface IUser
    {
        SqlInt64 UserId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Picture { get; set; }
        DateTime DateCreated { get; set; }
    }
}
