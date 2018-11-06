using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Entities
{
    public class Event
    {
        public Event()
        {
            Comments = new Collection<Comment>();
        }

        public SqlInt64 EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifyDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<EventUser> EventUsers { get; set; }
    }
}
