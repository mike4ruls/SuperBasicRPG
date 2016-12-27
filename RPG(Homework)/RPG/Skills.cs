//Name: Michael Ray
//Skills Class
//A parent class, Should creat a skill object with a name a cooldowns
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Skills
    {
        // All skills will have a name and cooldown
        private string name;
        private int coolDown;


        // A constructor for a blank skill
        public Skills()
        {
            name = "Open";
            coolDown = 0;
        }

        public Skills(string nm, int cd)
        {
            name = nm;
            coolDown = cd;
        }

        public override string ToString()
        {
            return name + "(Cool Down (" + coolDown + " sec))";
        }
    }
}
