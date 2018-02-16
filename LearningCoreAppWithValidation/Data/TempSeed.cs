using LearningCoreAppWithValidation.DBEntitities;
using LearningCoreAppWithValidation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Data
{
    public class TempSeed
    {
        public BaseDbContext _dbContext;
        BaseRepository<Center> centerRep;
        public AppDbContext _Context;

        public TempSeed(BaseDbContext dbContext, AppDbContext Context)
        {
            _dbContext = dbContext;
            _Context = Context;
        }
        public void Seed()
        {
            centerRep = new BaseRepository<Center>(_dbContext);
            centerRep.AddEntity(new Center()
            {
                Name = "Hyderabad",
                CenterType = _Context.CenterTypes.FirstOrDefault(ct => ct.ShortName == "ST"),
                CenterRefId = _Context.Centers.FirstOrDefault(c => c.Name == "India").Id,
            });
        }
        

    }
}
