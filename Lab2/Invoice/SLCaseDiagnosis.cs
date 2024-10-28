using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    [Table(name: "SLCaseDiagnoses", Schema = "zap")]
    public class SLCaseDiagnosis : BaseGUIDEntity
    {
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
        [Display(Name = "Тип диагноза")]
        public int DiagnosisType { get; set; }
        [Display(Name = "Id диагноза")]
        public int DiagnosisId { get; set; }
        public virtual Diagnosis? Diagnosis { get; set; }

        [Display(Name = "Установлен впервые (основной)")]
        public bool IsFirstInstalled { get; set; }

    }
}
