using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор типов хирургического лечения . В НСИ ФФОМС справочник N014 
    /// </summary>
    [Table(name: "SurgeryTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class SurgeryType : DictionaryBaseType<int>
    {
    }
}
