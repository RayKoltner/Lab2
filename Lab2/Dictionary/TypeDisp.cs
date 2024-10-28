using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Типы диспансеризации. В НСИ ФФОМС справочник V016
    /// </summary>
    [Table(name: "TypeDisps", Schema = "dict")]
    [Index(nameof(Code))]
    public class TypeDisp:DictionaryBaseType<string>
    {
        [Display(Name = "Допустимый для данного типа ДД значения результата")]
        public string ValidResultDisp { get; set; } = string.Empty;
    }
}
