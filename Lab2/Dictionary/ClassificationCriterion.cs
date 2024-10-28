using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор классификационных критериев. В НСИ ФФОМС справочник V024 
    /// </summary>
    [Table(name: "ClassificationCriterions", Schema = "dict")]
    [Index(nameof(Code))]
    public class ClassificationCriterion : BaseEntity
    {
        [Display(Name = "Код")]
        [MaxLength(10)]
        public string Code { get; set; } = string.Empty;
        [Column(TypeName = "date")]
        [Display(Name = "Начало")]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Окончание")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;

    }

}
