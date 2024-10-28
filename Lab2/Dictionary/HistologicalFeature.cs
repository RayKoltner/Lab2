using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор гистологических признаков. В НСИ ФФОМС справочник N007
    /// </summary>
    [Table(name: "HistologicalFeatures", Schema = "dict")]
    [Index(nameof(Code))]
    public class HistologicalFeature : DictionaryBaseType<int>
    {
    }
}
