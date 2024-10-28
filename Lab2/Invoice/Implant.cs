using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Сведения о медицинских изделиях, имплантируемых в организм человека
    /// </summary>
    [Table(name: "Implants", Schema = "zap")]
    public class Implant : BaseGUIDEntity
    {
        [Display(Name = "Дата установки медицинского изделия")]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Display(Name = "Id вида медицинского изделия")]
        public int MedicalDeviceTypeId { get; set; }
        public virtual MedicalDeviceType? MedicalDeviceType { get; set; }
        [Display(Name = "Id вида медицинского изделия")]
        [MaxLength(100)]
        public string SerialNumber { get; set; } = string.Empty;
        [Display(Name = "Id услуги")]
        public Guid USLServiceId { get; set; }
        public virtual USLService? USLService { get; set; }

    }
}
