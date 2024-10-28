using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор поводов обращения. В НСИ ФФОМС справочник N018 
    /// </summary>
    [Table(name: "ReasonAppeals", Schema = "dict")]
    [Index(nameof(Code))]
    public class ReasonAppeal : DictionaryBaseType<int>
    {
    }
}
