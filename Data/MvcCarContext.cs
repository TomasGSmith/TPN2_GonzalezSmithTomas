using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPN2_GonzalezSmithTomas.Models;

namespace TPN2_GonzalezSmithTomas.Data
{
    public class MvcCarContext : DbContext
    {
        public MvcCarContext (DbContextOptions<MvcCarContext> options)
            : base(options)
        {
        }

        public DbSet<TPN2_GonzalezSmithTomas.Models.Car> Car { get; set; } = default!;
    }
}
