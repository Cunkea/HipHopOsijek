using HipHopOsijek.DAL.Entities;
using HipHopOsijek.DAL.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.DAL
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventUser> Event_Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new Event_UserMap());
            modelBuilder.Configurations.Add(new PersonMap());
        }
    }

    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Comment> Comments { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<EventUser> Event_Users { get; set; }
        DbSet<Person> People { get; set; }
    
        Task<int> SaveChangesAsync();
    }
}
