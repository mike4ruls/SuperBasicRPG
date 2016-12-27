using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Skills
    {
        string name;
        int coolDown;

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
