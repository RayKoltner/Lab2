using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    [Table(name: "KSGKPGClassificationCriterions", Schema = "zap")]
    public class KSGKPGClassificationCriterion : BaseGUIDEntity
    {
        [Display(Name ="Id КСГ/КПГ")]
        public Guid KSGKPGId { get; set; }
        public virtual KSGKPG? KSGKPG { get; set; }
        [Display(Name = "Id классификационного критерия")]
        public int ClassificationCriterionId { get; set; }  
        public virtual ClassificationCriterion? ClassificationCriterion { get; set; }

    }
}
