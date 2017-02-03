using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using USF.TrainingCatalog.Data.Entities;

namespace USF.TrainingCatalog.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Material> Materials { get; set; }

        public DbSet<CatalogUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Session>()
                .Property(s => s.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            builder.Entity<Trainer>()
                .Property(t => t.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            builder.Entity<Attendee>()
                .Property(a => a.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            builder.Entity<Material>()
                .Property(m => m.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            builder.Entity<CatalogUser>()
                .Property(u => u.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
        }
    }
}
