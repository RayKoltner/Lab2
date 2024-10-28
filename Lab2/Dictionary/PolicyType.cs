using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор форм изготовления полиса. В НСИ ФФОМС справочник R002
    /// </summary>
    [Table(name: "PolicyTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class PolicyType : DictionaryBaseType<int>

    {


    }
}
