//Name: Michael Ray
//Items Class
//A parent class, and should construct a basic item object
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Items
    {
        private string name;


        // Constructor for a blank Item
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
