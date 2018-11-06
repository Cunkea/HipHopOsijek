using HipHopOsijek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            this.HasKey(t => t.EventId);

            this.ToTable("Event");
            this.Property(t => t.EventTitle).HasColumnName("EventTitle").HasColumnType("NVarchar").HasMaxLength(50);
            this.Property(t => t.EventDescription).HasColumnName("EventDescription").HasColumnType("NVarchar").HasMaxLength(1000);
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.LastModifyDate).HasColumnName("LastModifyDate");
        }
    }
}
