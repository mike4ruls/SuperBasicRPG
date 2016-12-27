using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Player
    {
        private string name;
        private string special;
        private int health;
        private int mana;
        private int attack;
        private int armor;
        private int maxSkills;
        Bag inventory;
        Skills genSkill;
        Skills[] skill;

        public Player()
        {
            name = "Pizza";
            special = "Nothing";
            health = 50;
            mana = 25;
            attack = 25;
            armor = 0;
            maxSkills = 0;
        }

        public Player(string nm, string spcl, int hlth, int mn, int attk, int armr)
        {
            name = nm;
            special = spcl;
            health = hlth;
            mana = mn;
            attack = attk;
            armor = armr;
            maxSkills = 3;
            inventory = new Bag(name);
            genSkill = new Heal(100);
            skill = new Skills[maxSkills];
            skill[0] = genSkill;
            skill[1] = new Skills();
            skill[2] = new Skills();

        }

        public void OpenBag()
        {
            inventory.OpenBag();
        }

        public void AddSkill(Skills newSkill)
        {
            Skills nothing = new Skills();
            for (int i = 0; i < skill.Length; i++)
            {
                if (skill[i].ToString() == nothing.ToString())
                {
                    skill[i] = newSkill;
                    break;
                }
            }
        }

        public void ShowSkills()
        {
            int end = 0;
            do
            {
                int slots = 1;
                Console.WriteLine("Skills: \n");
                for (int i = 0; i < skill.Length; i++)
                {
                    Console.WriteLine(slots + ") " + skill[i].ToString());
                    slots += 1;
                }
                Console.WriteLine("Press B to go back...");
                string choice = Console.ReadLine();
                choice = choice.ToUpper();
                if (choice != "B")
                {
                    Console.Clear();
                    continue;
                }
                else if (choice == "B")
                {
                    end += 1;
                }

            } while (end == 0);
            Console.Clear();

        }

        public override string ToString()
        {
            return "Name: " + name + "\nClass: " + special + "\nHealth: (" + health + ") Mana: (" + mana + ")\nAttack Damge: (" + attack + ") Armor: (" + armor + ")";
        }

    }
}
