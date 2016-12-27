using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class ManaPotion:Items
    {
        private int mana;

        public ManaPotion()
            : base("Mana Potion")
        {
            mana = 50;
        }

        public override string ToString()
        {
            return base.ToString() + ": Replenishes 50 Mana";
        }
    }
}
