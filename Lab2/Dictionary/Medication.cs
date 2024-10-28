using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор лекарственных препаратов, применяемых при проведении лекарственной терапии. В НСИ ФФОМС справочник N020
    /// </summary>
    [Table(name: "Medications", Schema = "dict")]
    [Index(nameof(Code))]
    public class Medication : DictionaryBaseType<string>
    {
    }
}
