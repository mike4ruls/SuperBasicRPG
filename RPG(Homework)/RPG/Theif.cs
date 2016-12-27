//Name: Michael Ray
//Theif Class
//A sub class of Player, has a unique skill object
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    // Sub Class of Player
    class Theif:Player
    {
        // Special attribute for Theifs
        private int knifes;

        // Special skill associated with Theifs
        private Skills s1;
        public Theif()
        {

        }


        public Theif(string nm)
            : base(nm, "Theif", 200, 250, 250, 100)
        {
            knifes = 15;
            s1 = new Invisible(10);
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
            return base.ToString() + "\nThrowing knifes: " + knifes;
        }
    }
}
