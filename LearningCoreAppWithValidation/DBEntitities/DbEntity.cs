using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningCoreAppWithValidation.DBEntitities
{
    public class DbEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        
        public virtual bool IsActive { get; set; } = true;
    }
}
