using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор типов лечения. В НСИ ФФОМС справочник N013 
    /// </summary>
    [Table(name: "TreatmentTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class TreatmentType : DictionaryBaseType<int>
    {
    }
}
