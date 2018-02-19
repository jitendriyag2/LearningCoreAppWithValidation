using LearningCoreAppWithValidation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Repositories
{
    public class CenterRepository
    {
        BaseDbContext _dbContext;
        public CenterRepository(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
