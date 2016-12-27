using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Invisible:Skills
    {
        int active;
        public Invisible()
        {

        }
        public Invisible(int act)
            : base("Invisibility", 80)
        {
            active = act;
        }

        public override string ToString()
        {
            return base.ToString() + "\nDescription: Turn invisible for " + active + " seconds\n";
        }
    }
}
