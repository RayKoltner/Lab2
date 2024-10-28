using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор моделей пациента при ВМП. В НСИ ФФОМС справочник V022
    /// </summary>
    [Table(name: "PatientVMPModels", Schema = "dict")]
    [Index(nameof(Code))]
    public class PatientVMPModel : BaseEntity
    {
        [Display(Name = "Код")]
        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "date")]
        public DateTime BeginDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

    }
}
