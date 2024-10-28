using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор профилей койки. В НСИ ФФОМС справочник V020
    /// </summary>
    [Table(name: "BedMedProfiles", Schema = "dict")]
    [Index(nameof(Code))]
    public class BedMedProfile:DictionaryBaseType<int>
    {
    }
}
