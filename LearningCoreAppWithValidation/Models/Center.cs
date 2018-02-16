using LearningCoreAppWithValidation.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Models
{
    public class Center : ModelEntity
    {
        public virtual CenterType CenterType { get; set; }
        public int CenterTypeId { get; set; }
    }
}
