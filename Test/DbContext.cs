using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.Entities;
using Test.ViewModel;

namespace Test
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(
                @"Server=anita-nb\\sqlexpress;Database=Test;User Id=sa;Password=puchito666;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserRol>().ToTable("SuperPuchunRolUser");
            modelBuilder.Entity<Rol>().ToTable("Rol");

            modelBuilder.Entity<UserRol>()
                .HasKey(t => new { t.IdUser, t.IdRol });
        }
        public DbSet<Test.ViewModel.RolViewModel> RolViewModel { get; set; }


    }
}
