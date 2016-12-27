using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class HealthPotion:Items
    {
        private int health;

        public HealthPotion()
            : base("Health Potion")
        {
            health = 50;
        }

        public override string ToString()
        {
            return base.ToString() + ": Replenishes 50 HP";
        }
    }
}
