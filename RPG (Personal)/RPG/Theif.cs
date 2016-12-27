using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Theif:Player
    {
        int knifes;
        Skills s1;
        public Theif(string nm)
            : base(nm, "Theif", 200, 250, 250, 100)
        {
            knifes = 15;
            s1 = new Invisible(10);
        }

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
