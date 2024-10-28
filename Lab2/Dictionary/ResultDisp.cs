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
    /// Классификатор результатов диспансеризации. В НСИ ФФОМС справочник V017
    /// </summary>
    [Table(name: "ResultDisps", Schema = "dict")]
    [Index(nameof(Code))]
    public class ResultDisp : DictionaryBaseType<int>
    {
    }
}
