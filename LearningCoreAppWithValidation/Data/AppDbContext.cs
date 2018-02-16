using LearningCoreAppWithValidation.DBEntitities;
using LearningCoreAppWithValidation.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Data
{
    public class AppDbContext : BaseDbContext
    {
        TempSeed temp;
        public AppDbContext(DbContextOptions<BaseDbContext> options, TempSeed _temp) : base(options)
        {
            Seed();
            temp = _temp;
        }

        public void Seed()
        {
            //SeedData.Seed(this);
            temp.Seed();
        }

        public DbSet<Center> Centers { get; set; }
        public DbSet<CenterType> CenterTypes { get; set; }
    }
}
