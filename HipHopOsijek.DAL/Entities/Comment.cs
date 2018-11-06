using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Entities
{
    public class Comment
    {
        public SqlInt64 Id { get; set; }
        public SqlInt64 PersonId { get; set; }
        public SqlInt64 EventId { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }

        public Event Event { get; set; }
    }
}
