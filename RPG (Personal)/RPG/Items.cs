using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Items
    {
        string name;

        public Items()
        {
            name = "nothing";
        }
        public Items(string nm)
        {
            name = nm;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
