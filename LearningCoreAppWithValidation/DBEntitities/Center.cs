using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.DBEntitities
{
    public class Center : DbEntity
    {
        public virtual CenterType CenterType { get; set; }
        public int CenterTypeId { get; set; }
        public int CenterRefId { get; set; }
        public virtual Center ParentCenter { get; set; }
    }
}
