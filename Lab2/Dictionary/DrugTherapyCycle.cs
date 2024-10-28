using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор циклов лекарственной терапии. В НСИ ФФОМС справочник N016  
    /// </summary>
    [Table(name: "DrugTherapyCycles", Schema = "dict")]
    [Index(nameof(Code))]
    public class DrugTherapyCycle : DictionaryBaseType<int>
    {
    }
}
