using LearningCoreAppWithValidation.DBEntitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.ViewModels
{
    public class CenterList
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string CenterType { get; set; }
        public int CenterTypeId { get; set; }
        public int CenterRefId { get; set; }
        public Center ParentCenter { get; set; }
    }
}
