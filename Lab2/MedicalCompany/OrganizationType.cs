using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
////using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Тип организации
    /// </summary>
    [Table(name: "OrganizationTypes", Schema = "LPU")]
    public class OrganizationType : BaseEntity
    {
        [MaxLength(250)]
        public string Name { get; set; }
        public OrganizationType()
        {
            Name = string.Empty;
        }
    }
}
