using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior:Player
    {
        int rage;
        Skills s1;

        public Warrior(string nm)
            : base(nm, "Warrior", 400, 100, 300, 300)
        {
            rage = 1;
            s1 = new UltimateSwing(400);
        }

        public Skills GetSkill()
        {
            return s1;
        }

        public override string ToString()
        {
            return base.ToString() + "\nRage: " + rage + "/100";
        }
    }
}
