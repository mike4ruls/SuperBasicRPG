//Name: Michael Ray
//Heal Class
//A sub class of Skills class, This skill should be a generic skill every player carries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{

    // Sub Class of Skills
    class Heal:Skills
    {
        // This skill can heal the player for a certain ammount of HP
        private int ammountHeal;
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
