using System.ComponentModel.DataAnnotations.Schema;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Cпособы оплаты медицинской помощи. В НСИ ФФОМС справочник V010
    /// </summary>
    [Table(name: "PaymentMethods", Schema = "dict")]
    public class PaymentMethod : DictionaryBaseType<int>
    {

    }
}
