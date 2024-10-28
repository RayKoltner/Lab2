using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор профилей оказанной мед помощи. В НСИ ФФОМС справочник V002
    /// </summary>
    [Table(name: "MedProfiles", Schema = "dict")]
    [Index(nameof(Code))]
    public class MedProfile: DictionaryBaseType<int>
    {
    }
}
