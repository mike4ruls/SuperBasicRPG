//Name: Michael Ray
//Invisible Class
//A sub class of Skills class, This skill should specifically for only Theif players
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    // Sub Class of Skills
    class Invisible:Skills
    {
        // Can be active for a certain ammount of time
        private int active;
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
