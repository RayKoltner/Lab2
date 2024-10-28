using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Результы обращения за медицинской помощью. В НСИ ФФОМС справочник V009
    /// </summary>
    [Table(name: "Results", Schema = "dict")]
    public class Result : DictionaryBaseType<int>
    {
        [Display(Name = "Ключ условия оказания мед помощи")]
        public int UMPId { get; set; }
        public virtual UMP? UMP { get; set; }
    }
}   
