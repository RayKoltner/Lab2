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
    /// Классификатор целей посещения. В НСИ ФФОМС справочник V025
    /// </summary>
    [Table(name: "VisitPurposes", Schema = "dict")]
    [Index(nameof(Code))]
    public class VisitPurpose:DictionaryBaseType<string>
    {
    }
}
