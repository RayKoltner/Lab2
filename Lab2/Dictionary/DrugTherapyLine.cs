using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор линий лекарственной терапии. В НСИ ФФОМС справочник N015 
    /// </summary>
    [Table(name: "DrugTherapyLines", Schema = "dict")]
    [Index(nameof(Code))]
    public class DrugTherapyLine : DictionaryBaseType<int>
    {
    }
}
