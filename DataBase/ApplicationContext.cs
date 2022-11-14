using Microsoft.EntityFrameworkCore;
using ShopAccessoriesPC.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ShopAccessoriesPC.DataBase
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Набор сущностей класса Users
        /// </summary>
        public DbSet<Users> UserBD { get; set; }
        /// <summary>
        /// Набор сущностей класса Tovar
        /// </summary>
        public DbSet<Tovar> TovarsBD { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(u => u.Id);
            modelBuilder.Entity<Tovar>().ToTable("TovarsUsers");
            modelBuilder.Entity<Tovar>().HasKey(u => u.Id);
        }

    }
}
