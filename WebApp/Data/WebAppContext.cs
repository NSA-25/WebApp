using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Entities;

namespace WebApp.Data
{
    public class WebAppContext: IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public WebAppContext (DbContextOptions<WebAppContext> options): base(options) {}

        public DbSet<Product>? Product { get; set; }

        public DbSet<Location>? Location { get; set; }

        public DbSet<Manager>? Manager { get; set; }

        public DbSet<Store>? Store { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many

            modelBuilder.Entity<Location>()
                .HasMany(a => a.Stores)
                .WithOne(b => b.Location);

            // One to One

            modelBuilder.Entity<Manager>()
                .HasOne(a => a.Store)
                .WithOne(b => b.Manager);

            // Many to Many

            modelBuilder.Entity<StoreProduct>().HasKey(a => new { a.StoreId, a.ProductId });

            modelBuilder.Entity<StoreProduct>()
                .HasOne(a => a.Store)
                .WithMany(b => b.StoreProducts)
                .HasForeignKey(c => c.StoreId);

            modelBuilder.Entity<StoreProduct>()
                .HasOne(a => a.Product)
                .WithMany(b => b.StoreProducts)
                .HasForeignKey(c => c.ProductId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
