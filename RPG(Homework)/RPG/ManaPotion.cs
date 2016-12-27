//Name: Michael Ray
//ManaPotion Class
//A sub class of Items class, should generate a mana potion item
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    // Sub Class of Items
    class ManaPotion:Items
    {
        private int mana;

        public ManaPotion()
        {

        }
        public ManaPotion(int mn)
            : base("Mana Potion")
        {
            mana = mn;
        }

        public override string ToString()
        {
            return base.ToString() + ": Replenishes " + mana + " Mana";
        }
    }
}
