using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordandFather.Models
{
    public class CreateAssassinRequest
    {
        public string CodeName { get; set; }
        public string CatchPhrase { get; set; }
        public string PreferredWeapon { get; set; }
    }
}
