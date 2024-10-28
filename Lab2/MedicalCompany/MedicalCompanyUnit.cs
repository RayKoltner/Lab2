using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    [Table(name: "MedicalCompanyUnits", Schema = "LPU")]
    [Index(nameof(MedicalCompanyId))]
    public class MedicalCompanyUnit : BaseEntity
    {
        [Display(Name = "ЛПУ")]
        public int MedicalCompanyId { get; set; }
        public virtual MedicalCompany? MedicalCompany { get; set; }
        [Display(Name = "КОД ПОДРАЗД")]
        [MaxLength(20)]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "СТАРЫЙ КОД")]
        [MaxLength(20)]
        public string OldCode { get; set; } = string.Empty;
        [MaxLength(20)]
        public string CodeMain { get; set; } = string.Empty;
        [Display(Name = "НАИМЕНОВАНИЕ")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string FRMOId { get; set; } = string.Empty;
        [Column(TypeName = "date")]
        [Display(Name = "НАЧАЛО")]
        public DateTime BeginDate { get; set; }
        [Display(Name = "ОКОНЧАНИЕ")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
    }
}
