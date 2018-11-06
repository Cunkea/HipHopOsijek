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
    [KnownType(typeof(EventPoco))]
    class EventPoco : IEvent
    {
        public SqlInt64 EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifyDate { get; set; }

        public ICollection<IComment> Comments { get; set; }
    }
}
