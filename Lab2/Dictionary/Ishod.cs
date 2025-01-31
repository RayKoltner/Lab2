﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Исходы заболевания. В НСИ ФФОМС справочник V012
    /// </summary>
    [Table(name: "Ishods", Schema = "dict")]
    public class Ishod : DictionaryBaseType<int>
    {
        [Display(Name = "Ключ условия оказания мед помощи")]
        public int UMPId { get; set; }
        public virtual UMP? UMP { get; set; }
    }
}
