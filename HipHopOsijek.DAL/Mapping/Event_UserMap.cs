using HipHopOsijek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Mapping
{
    public class Event_UserMap : EntityTypeConfiguration<EventUser>
    {
        public Event_UserMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Event_User");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
