using LearningCoreAppWithValidation.BaseEntity;
using LearningCoreAppWithValidation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCoreAppWithValidation.ViewModels
{
    public class AddCenterVM : ModelEntity
    {
        [Required,MinLength(2)]
        [Display(Name = "Center ID")]
        public override int Id { get; set; }
        [Display(Name = "Center Name")]
        public override string Name { get; set; }
        [Display(Name = "Center Type")]
        public IEnumerable<CenterType> CenterTypes { get; set; }
        [Display(Name = "Parent Center")]
        public IEnumerable<Center> ParentCenters { get; set; }
        public int CenterRefID { get; set; }
        public int SelectedCenterType { get; set; }
        [Display(Name = "Center Active Or Not")]
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
    }
}
