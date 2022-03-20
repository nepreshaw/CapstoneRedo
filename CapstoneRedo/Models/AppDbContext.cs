using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneRedo.Models;

namespace CapstoneRedo.Models {
    public class AppDbContext : DbContext {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>(
                fred => fred.HasIndex(fred => fred.Username).IsUnique(true));
            builder.Entity<Vendor>(
                fred => fred.HasIndex(fred => fred.Code).IsUnique(true));
        }

        public DbSet<CapstoneRedo.Models.Vendor> Vendor { get; set; }

        public DbSet<CapstoneRedo.Models.Request> Request { get; set; }

        public DbSet<CapstoneRedo.Models.RequestLine> RequestLine { get; set; }
    }
}
