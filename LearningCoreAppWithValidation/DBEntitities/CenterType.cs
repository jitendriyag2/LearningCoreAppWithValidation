using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.DBEntitities
{
    public class CenterType : DbEntity
    {
        [MaxLength(3)]
        public string ShortName { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Center> Centers { get; set; }
    }
}
