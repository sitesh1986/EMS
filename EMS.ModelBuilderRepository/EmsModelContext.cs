using EMS.ModelBuilderRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EMS.ModelBuilderRepository
{
    public class EmsModelContext: DbContext
    {
        public EmsModelContext(DbContextOptions<EmsModelContext> options)
           : base(options)
        {

        }
        private DbSet<Block> Block { get; set; }
        private DbSet<PM520L> PM520L { get; set; }
        private DbSet<EmsMaster> emsMaster { get; set; }
        private DbSet<Customer> customers { get; set; }
        private DbSet<Priviliges> priviliges { get; set; }
        private DbSet<CustomerPriviliges> customerpriviliges { get; set; }
        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerPriviliges>().HasKey(sc => new { sc.CustomerId, sc.PrivilegeId });
        }
    }
}
