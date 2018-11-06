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
    [KnownType(typeof(EventUserPoco))]
    class EventUserPoco :IEventUser
    {
        public SqlInt64 Id { get; set; }
        public SqlInt64 PersonId { get; set; }
        public SqlInt64 EventId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
