using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Сочетание схемы лечения и группы препаратов. В НСИ ФФОМС справочник V032
    /// </summary>
    [Table(name: "CombinationTreatments", Schema = "dict")]
    [Index(nameof(Code))]
    public class CombinationTreatment : DictionaryBaseType<string>
    {
        [Display(Name ="Код схемы")]
        [MaxLength(4)]
        public string SchemeCode { get; set; } = string.Empty;
    }
}
