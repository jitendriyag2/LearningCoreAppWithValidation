using LearningCoreAppWithValidation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Repositories
{
    public class CenterRepository
    {
        AppDbContext _dbContext;
        public CenterRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
