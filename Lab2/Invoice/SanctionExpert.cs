using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Таблица связка санкций и экспертов 
    /// </summary>
    [Table(name: "SanctionExperts", Schema = "zap")]
    public class SanctionExpert : BaseGUIDEntity
    {
        [Display(Name = "Id эксперта качества медицинской помощи")]
        public int ExpertReestrId { get; set; }
        public virtual ExpertReestr? ExpertReestr { get; set; }
        [Display(Name = "Id санкции")]
        public Guid SanctionId { get; set; }
        public virtual Sanction? Sanction { get; set; }
    }
    
}
