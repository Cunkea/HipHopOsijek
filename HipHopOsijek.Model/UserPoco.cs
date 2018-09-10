using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Model
{
    [KnownType(typeof(UserPoco))]
    class UserPoco : IUser
    {
        public SqlInt64 UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
