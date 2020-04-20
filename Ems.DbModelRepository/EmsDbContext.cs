using EMS.DbModelRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

namespace Ems.DbModelRepository
{
    public class EmsDbContext:DbContext
    {
        public EmsDbContext(DbContextOptions<EmsDbContext> options)
         : base(options)
        {

        }
        private DbSet<Block> Block { get; set; }
        private DbSet<PM520L> PM520L { get; set; }
        private DbSet<EmsMaster> emsMaster { get; set; }
        private DbSet<Customer> customers { get; set; }
        private DbSet<Privilige> priviliges { get; set; }
        private DbSet<CustomerPrivilege> customerprivileges { get; set; }

    }
}
