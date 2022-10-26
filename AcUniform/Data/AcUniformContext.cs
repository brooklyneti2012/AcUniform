using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcUniform.Models;

namespace AcUniform.Data
{
    public class AcUniformContext : DbContext
    {
        public AcUniformContext (DbContextOptions<AcUniformContext> options)
            : base(options)
        {
        }

        public DbSet<AcUniform.Models.Junior> Junior { get; set; } = default!;
    }
}
