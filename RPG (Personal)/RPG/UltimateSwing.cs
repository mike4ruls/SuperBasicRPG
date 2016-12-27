using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class UltimateSwing:Skills
    {
        int damage;

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
