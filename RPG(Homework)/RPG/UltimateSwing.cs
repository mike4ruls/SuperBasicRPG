//Name: Michael Ray
//UltimateSwing Class
//A sub class of Skills class, should be a specific skill only for Warrior players
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    // Sub Class of Skills
    class UltimateSwing:Skills
    {
        // This skill does a certain ammount of damage to enemies 
        private int damage;

        public UltimateSwing()
        {

        }
        public UltimateSwing(int dmg)
            : base("Ultimate Swing", 30)
        {
            damage = dmg;

        }

        public override string ToString()
        {
            return base.ToString() + "\nDescription: As you Swing your sword in one powerful swing you deal " + damage + " damage to enemies infront of you\n";
        }
    }
}
