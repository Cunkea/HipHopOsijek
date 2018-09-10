using HipHopOsijek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Mapping
{
    public class Event_UserMap : EntityTypeConfiguration<Event_User>
    {
        public Event_UserMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Event_User");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
