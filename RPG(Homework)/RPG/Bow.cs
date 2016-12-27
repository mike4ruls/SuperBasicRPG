//Name: Michael Ray
//Bow Class
//A sub class of Items class, should generate a regular wooden bow object
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Bow:Items
    {
        int damage;
        public Bow()
        {

        }
        // Sub Class of Items
        public Bow(int dmg)
            : base("Wooden Bow")
        {
            damage = dmg;
        }

        public override string ToString()
        {
            return base.ToString() + ": A raggedy old bow, who would use this?? ( Does " + damage + " damage )";
        }
    }
}
