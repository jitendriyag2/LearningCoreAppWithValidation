using LearningCoreAppWithValidation.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Controllers
{
    public class CenterController : Controller
    {
        AppDbContext _dbContext;
        public CenterController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
