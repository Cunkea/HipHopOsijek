using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Model.Common
{
    public interface IEvent
    {
        SqlInt64 EventId { get; set; }
        string EventTitle { get; set; }
        string EventDescription { get; set; }
        DateTime DateCreated { get; set; }
        DateTime LastModifyDate { get; set; }


        ICollection<IComment> Comments { get; set; }
    }
}
