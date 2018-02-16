using LearningCoreAppWithValidation.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.Models
{
    public class CenterType : ModelEntity
    {
        public virtual IEnumerable<Center> Centers { get; set; }
    }
}
