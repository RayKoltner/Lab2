using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор целей консилиума. В НСИ ФФОМС справочник N019
    /// </summary>
    [Table(name: "ConsultationPurposes", Schema = "dict")]
    [Index(nameof(Code))]
    public class ConsultationPurpose : DictionaryBaseType<int>
    {
    }
}
