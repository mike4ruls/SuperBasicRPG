using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    class Heal:Skills
    {
        int ammountHeal;
        public Heal()
        {

        }
        public Heal(int ammHl)
            : base("Heal", 200)
        {
            ammountHeal = ammHl;
        }

        public override string ToString()
        {
            return base.ToString() + "\nDescription: Heal yourself for " + ammountHeal + " HP\n";
        }
    }
}
