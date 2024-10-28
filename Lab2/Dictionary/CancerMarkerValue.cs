using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
////using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор значений маркёров. В НСИ ФФОМС справочник N011
    /// </summary>
    [Table(name: "CancerMarkerValues", Schema = "dict")]
    [Index(nameof(Code))]
    public class CancerMarkerValue : DictionaryBaseType<int>
    {
        [Display(Name = "Id маркера")]
        public int CancerMarkerId { get; set; }
        public virtual CancerMarker? CancerMarker { get; set; }
        [Display(Name = "Обозначение результата")]
        [MaxLength(250)]
        public string Result { get; set; } = string.Empty;
    }
}
