using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор противопоказаний и отказов. В НСИ ФФОМС справочник N001
    /// </summary>
    [Table(name: "Contraindications", Schema = "dict")]
    [Index(nameof(Code))]
    public class Contraindication : DictionaryBaseType<int>
    {
    }
}
