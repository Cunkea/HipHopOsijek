using HipHopOsijek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Comment");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.Text).HasColumnName("Text").HasColumnType("NVarchar").HasMaxLength(1000);
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

        }
    }
}
