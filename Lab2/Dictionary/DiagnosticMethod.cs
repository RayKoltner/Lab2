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
    /// Классификатор методов диагностического исследования. В НСИ ФФОМС справочник V029 
    /// </summary>
    [Table(name: "DiagnosticMethods", Schema = "dict")]
    [Index(nameof(Code))]
    public class DiagnosticMethod:DictionaryBaseType<int>
    {
    }
}
