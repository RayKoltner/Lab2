using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Условия оказания мед помощи. В НСИ ФФОМС справочник V006
    /// </summary>
    [Table(name: "UMPs", Schema = "dict")]
	[Index(nameof(Code))]
	public class UMP : DictionaryBaseType<int>
	{
	}
}
