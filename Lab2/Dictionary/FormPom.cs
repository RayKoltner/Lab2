
using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Форма медицинской помощи.В НСИ ФФОМС справочник V014
    /// </summary>
    [Table(name: "FormPoms", Schema = "dict")]
    public class FormPom : DictionaryBaseType<int>
    {

    }
}
