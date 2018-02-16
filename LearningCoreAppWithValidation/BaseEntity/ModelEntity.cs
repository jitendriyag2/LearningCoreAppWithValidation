using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.BaseEntity
{
    public class ModelEntity
    {
        //public static Type Type { get; set; }

        //public ModelEntity()
        //{
        //    Type = this.GetType();
        //}

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        [Display(Name = "Active Status")]
        public virtual bool IsActive { get; set; }
    }
}
