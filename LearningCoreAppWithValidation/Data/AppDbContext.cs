using LearningCoreAppWithValidation.DBEntitities;
//using LearningCoreAppWithValidation.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Data
{
    public class AppDbContext : DbContext
    {
        
        //BaseDbContext _dbContext;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Seed();
        }

        public void Seed()
        {
            SeedData.Seed(this);
            
        }

        public DbSet<Center> Centers { get; set; }
        public DbSet<CenterType> CenterTypes { get; set; }
    }
}
