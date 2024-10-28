using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Вид медицинской помощи.В НСИ ФФОМС справочник V008 Приложение А
    /// </summary>
    [Table(name: "VidPoms", Schema = "dict")]
    public class VidPom : DictionaryBaseType<int>
    {

    }
}
