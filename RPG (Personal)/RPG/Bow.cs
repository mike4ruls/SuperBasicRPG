using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Bow:Items
    {

        public Bow()
            : base("Wooden Bow")
        {
        }

        public override string ToString()
        {
            return base.ToString() + ": A raggedy old bow, who would use this??";
        }
    }
}
