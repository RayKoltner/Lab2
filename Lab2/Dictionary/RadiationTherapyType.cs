using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор типов лучевой терапии. В НСИ ФФОМС справочник N017 
    /// </summary>
    [Table(name: "RadiationTherapyTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class RadiationTherapyType : DictionaryBaseType<int>
    {
    }
}
