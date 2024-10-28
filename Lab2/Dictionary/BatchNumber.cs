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
    /// Номер партии для пакета
    /// </summary>
    [Table(name: "BatchNumbers", Schema = "dict")]
    [Index(nameof(Code))]
    public class BatchNumber : DictionaryBaseType<int>
    {
    }
}
