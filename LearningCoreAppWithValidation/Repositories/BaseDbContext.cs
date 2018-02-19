using LearningCoreAppWithValidation.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Repositories
{
    public class BaseDbContext : DbContext
    {

        TempSeed temp;

        public BaseDbContext(DbContextOptions<BaseDbContext> options)
                        : base(options)
        {
            AppDbContext dbContext = new AppDbContext(options);
            new BaseDbContext(options, new TempSeed(this, dbContext));

        }
        public BaseDbContext(DbContextOptions<BaseDbContext> options, TempSeed _temp)
                        : base(options)
        {
            temp = _temp;
            Seed();
        }

        public void Seed()
        {
            temp.Seed();
        }
    }
}
