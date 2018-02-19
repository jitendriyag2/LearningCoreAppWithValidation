using LearningCoreAppWithValidation.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.ViewModels
{
    public class CenterDetailVM : ModelEntity
    {
        [Display(Name = "Center ID")]
        public override int Id { get; set; }
        [Display(Name = "Center Name")]
        public override string Name { get; set; }
        [Display(Name = "Center Type")]
        public string CenterType { get; set; }
        [Display(Name = "Parent Center")]
        public string ParentCenter { get; set; }
        [Display(Name = "Center Active Or Not")]
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
    }
}
