using LearningCoreAppWithValidation.Data;
using LearningCoreAppWithValidation.DBEntitities;
using LearningCoreAppWithValidation.ViewModels;
//using LearningCoreAppWithValidation.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Controllers
{
    public class CenterController : Controller
    {
        //BaseDbContext _dbContext;

        AppDbContext _dbContext;
        //public CenterController(BaseDbContext dbContext)
        public CenterController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        public IActionResult Index()
        {
            var dbCenter = _dbContext.Centers.Include(x=> x.CenterType).ToList();
            List<CenterList> viewCenters = new List<CenterList>();
            foreach (var center in dbCenter)
            {
                viewCenters.Add(new CenterList()
                {
                    Name = center.Name,
                    CenterType = (center.CenterType is null) ? null : center.CenterType.Name,
                    CenterRefId = center.CenterRefId,
                    CenterTypeId = center.CenterTypeId,
                    ParentCenter = _dbContext.Centers.Find(center.CenterRefId)
                });
            }
            
            return View(viewCenters);
        }


        public IActionResult Create()
        {
            List<CenterType> centerTypes = _dbContext.CenterTypes.ToList();
            List<Models.CenterType> cTypes = new List<Models.CenterType>();
            
                foreach (var centertype in centerTypes)
                {
                    cTypes.Add(new Models.CenterType()
                    {
                        Name = centertype.Name,
                        Id = centertype.Id,
                        IsActive = centertype.IsActive
                    });
                }

            List<Center> ParentCenters = _dbContext.Centers.Where(x=> x.IsActive == true).ToList();
            List<Models.Center> centers = new List<Models.Center>();

            foreach (var center in ParentCenters)
            {
                centers.Add(new Models.Center()
                {
                    Name = center.Name,
                    Id = center.Id
                });
            }

            AddCenterVM addCenterVM = new AddCenterVM()
            {
                CenterTypes  = cTypes,
                ParentCenters = centers
            };
            
            return View(addCenterVM);
        }
        [HttpPost]
        public IActionResult Create(AddCenterVM model)
        {
           if(ModelState.IsValid)
            {
                return RedirectToAction("Create",ModelState);
            }
            return View("Create",ModelState);
        }
    }
}
