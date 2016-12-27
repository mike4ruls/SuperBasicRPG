//Name: Michael Ray
//Warrior Class
//A sub class of Player, has one unique skill object
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    // Sub Class of Player
    class Warrior:Player
    {
        private int rage; // This attribute is unique to Warriors
        private Skills s1; // Has a unique skill associated with Warriors

        public Warrior()
        {

        }
        public Warrior(string nm)
            : base(nm, "Warrior", 400, 100, 300, 300)
        {
            rage = 1;
            s1 = new UltimateSwing(400);
        }


        /// <summary>
        /// Should return a skill object
        /// </summary>
        /// <returns>A skill object</returns>
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
