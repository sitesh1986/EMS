using EMS.ModelsRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EMS.Models
{
    public class EmsContext : DbContext
    {
        public EmsContext(DbContextOptions<EmsContext> options)
            : base(options)
        {

        }
        private DbSet<Block> Block { get; set; }
        private DbSet<PM520L> PM520L { get; set; }
        private DbSet<EmsMaster> emsMaster { get; set; }
        private DbSet<Customer> customers { get; set; }
    }
}
