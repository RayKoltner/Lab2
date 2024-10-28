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
    /// Коэфициент сложности
    /// </summary>
    [Table(name: "DifficultyCoefficients", Schema = "zap")]
    public class DifficultyCoefficient : BaseGUIDEntity
    {
        [Display(Name ="КСЛП id")]
        public int KSLPId {  get; set; }
        public virtual KSLP? KSLP { get; set; }
        [Display(Name = "Значение коэффициента сложности лечения пациента")]
        [Column(TypeName = "decimal(18,5)")]
        public decimal Value { get; set; }
        [Display(Name ="КСГ/КПГ Id")]
        public Guid KSGKPGId { get; set; }
        public virtual KSGKPG? KSGKPG { get; set; }
    }
}
