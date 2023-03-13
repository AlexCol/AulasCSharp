using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _4._ProjetoMVC.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public DbSet<Department> Department { get; set; }

        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Ignore<Notification>();

            modelBuilder.Entity<Department>()
                .Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Department>()
                .Property(p => p.Name).HasMaxLength(500);
            modelBuilder.Entity<Department>()
                .Property(p => p.Id).IsRequired();
        }
    }
}
