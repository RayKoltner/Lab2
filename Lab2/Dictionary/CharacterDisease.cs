using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Telerik.SvgIcons;
using TFOMSReestrServer.DS.Common;

namespace TFOMSReestrServer.DS.Models
{
    /// <summary>
    /// Классификатор характеров заболеваний. В НСИ ФФОМС справочник V027
    /// </summary>
    [Table(name: "CharacterDiseases", Schema = "dict")]
    [Index(nameof(Code))]
    public class CharacterDisease:DictionaryBaseType<int>
    {
    }
}
