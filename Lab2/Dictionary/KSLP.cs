﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор КСЛП 
    /// </summary>
    [Table(name: "KSLPs", Schema = "dict")]
    [Index(nameof(Code))]
    public class KSLP : DictionaryBaseType<int>
    {
        [Display(Name ="Условия оказания")]
        public int UMPId { get; set; }
        public virtual UMP? UMP { get; set; }
        [Display(Name ="Значение")]
        [Column(TypeName = "decimal(18,5)")]
        public decimal Value { get; set; }
    }
}
