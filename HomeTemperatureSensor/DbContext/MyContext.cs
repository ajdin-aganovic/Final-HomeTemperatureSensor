using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeTemperatureSensor.Models
{
    public class MyContext:DbContext
    {
        public DbSet<podaci> podaci { get; set; }
        public DbSet<sobe> sobe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=localhost;" +
                "Database=homeTemperatureSensor;" +
                "Trusted_Connection=true;" +
                "MultipleActiveResultSets=true;");
        }

    }
}
