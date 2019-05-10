using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreIntro.Models
{
    public class CoreIntroContext : DbContext
    {
        public CoreIntroContext (DbContextOptions<CoreIntroContext> options)
            : base(options)
        {
        }

        public DbSet<CoreIntro.Models.Person> Person { get; set; }
    }
}
