using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор причин исключения экспертов качества медицинской помощи. В НСИ ФФОМС справочник R010
    /// </summary>
    [Table(name: "ExcludingExperts", Schema = "dict")]
    [Index(nameof(Code))]
    public class ExcludingExpert : DictionaryBaseType<int>
    {
    }
}
