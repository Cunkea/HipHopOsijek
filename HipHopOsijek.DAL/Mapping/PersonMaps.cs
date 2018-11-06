using HipHopOsijek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            this.HasKey(t => t.PersonId);

            this.ToTable("Event");
            this.Property(t => t.Name).HasColumnName("Name").HasColumnType("NVarchar").HasMaxLength(20);
            this.Property(t => t.Surname).HasColumnName("Surname").HasColumnType("NVarchar").HasMaxLength(20);
            this.Property(t => t.Email).HasColumnName("Email").HasColumnType("NVarchar").HasMaxLength(50);
            this.Property(t => t.Password).HasColumnName("Password").HasColumnType("NVarchar").HasMaxLength(24);
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
