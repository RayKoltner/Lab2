﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор видов ВМП. В НСИ ФФОМС справочник V018
    /// </summary>
    [Table(name: "VidVMPs", Schema = "dict")]
    [Index(nameof(Code))]
    public class VidVMP : BaseEntity
    {
        [Display(Name = "Код")]
        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Номер группы ВМП")]
        [MaxLength(50)]
        public string VMPGrupNumber { get; set; } = string.Empty;
        [Display(Name = "Начало")]
        [Column(TypeName = "date")]
        public DateTime BeginDate { get; set; }
        [Display(Name = "Окончание")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
    }
}
