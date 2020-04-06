using Microsoft.EntityFrameworkCore;
using System;

namespace EMS.Models
{
    public class EmsContext:DbContext
    {
        public EmsContext(DbContextOptions<EmsContext> options)
            :base(options)
        {

        }
    }
}
