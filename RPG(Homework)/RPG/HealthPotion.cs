//Name: Michael Ray
//HealthPotion Class
//A sub class of Items class, should generate a healthpotion item
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    // Sub Class of Items
    class HealthPotion:Items
    {
        private int health;

        public HealthPotion()
        {

        }
        public HealthPotion(int hlt)
            : base("Health Potion")
        {
            health = hlt;
        }

        public override string ToString()
        {
            return base.ToString() + ": Replenishes " + health + " HP";
        }
    }
}
