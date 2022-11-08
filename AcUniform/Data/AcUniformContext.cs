using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcUniform.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AcUniform.Data
{
    public class AcUniformContext : DbContext
    {
        private Func<DbContextOptions<AcUniformContext>> getRequiredService;



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=AcUniform.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}
        public AcUniformContext (DbContextOptions<AcUniformContext> options)
            : base(options)
        {

        }       
       
        public AcUniformContext(Func<DbContextOptions<AcUniformContext>> getRequiredService)
        {
            this.getRequiredService = getRequiredService;
        }

        

        public DbSet<AcUniform.Models.Junior> Junior { get; set; } = default!;
       
    }
}
