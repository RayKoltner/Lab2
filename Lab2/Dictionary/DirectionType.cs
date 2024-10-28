using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор видов направлений. В НСИ ФФОМС справочник V028
    /// </summary>
    [Table(name: "DirectionTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class DirectionType:DictionaryBaseType<int>
    {
    }
}
