using HipHopOsijek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(t => t.UserId);

            this.ToTable("Event");
            this.Property(t => t.Name).HasColumnName("Name").HasColumnType("NVarchar").HasMaxLength(20);
            this.Property(t => t.Surname).HasColumnName("Surname").HasColumnType("NVarchar").HasMaxLength(20);
            this.Property(t => t.Picture).HasColumnName("Picture").HasColumnType("NVarchar").HasMaxLength(50);
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
