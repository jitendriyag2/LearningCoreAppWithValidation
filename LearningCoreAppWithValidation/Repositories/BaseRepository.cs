using LearningCoreAppWithValidation.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Repositories
{
    public class BaseRepository<TModel> where TModel : class
    {
        BaseDbContext _dbContext;
        public DbSet<TModel> Entities;

        public BaseRepository(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddEntity(TModel model)
        {
            try
            {
                this.Entities.Add(model);
                Save();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                
            }
        }

        public void AddEntities(IEnumerable<TModel> models)
        {
            try
            {
                this.Entities.AddRange(models);
                Save();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
            }
        }

        public TModel GetEntityById(object Id)
        {
            try
            {
                return this.Entities.Find(Id);
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return this.Entities.Find(Id);
        }


        public void Save()
        {
            this._dbContext.SaveChanges();
        }
    }
}
