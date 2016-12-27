//Name: Michael Ray
//Player Class
//Should be a parent class and construct generic player attributes with a bag/inventory
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
        private Bag inventory; //Declaring a bag object
        private Skills genSkill; // Declaring a General Skill every player will have
        private Skills[] skill; // Declaring an array of skills objects to hold

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
            genSkill = new Heal(100); // General skill is Heal
            skill = new Skills[maxSkills];


            skill[0] = genSkill;
            skill[1] = new Skills();
            skill[2] = new Skills();

        }

        /// <summary>
        /// Should open up and display player's inventory
        /// </summary>
        public void OpenBag()
        {
            inventory.OpenBag();
        }

        /// <summary>
        /// Should add a skill object into player's skill array
        /// </summary>
        /// <param name="newSkill">A skill object</param>

        public void AddSkill(Skills newSkill)
        {
            Skills nothing = new Skills();
            // Looks for an open slot in the array
            for (int i = 0; i < skill.Length; i++)
            {
                if (skill[i].ToString() == nothing.ToString())
                {
                    skill[i] = newSkill;
                    break;
                }
            }
        }

        /// <summary>
        /// Displays the player's skills
        /// </summary>

        public void ShowSkills()
        {
            int end = 0; // So I can leave loop
            do
            {
                int slots = 1;
                Console.WriteLine("Skills: \n");
                for (int i = 0; i < skill.Length; i++)
                {
                    Console.WriteLine(slots + ") " + skill[i].ToString());
                    slots += 1;
                }
                end += 1;

            } while (end == 0);

        }

        public override string ToString()
        {
            return "Name: " + name + "\nClass: " + special + "\nHealth: (" + health + ") Mana: (" + mana + ")\nAttack Damge: (" + attack + ") Armor: (" + armor + ")";
        }

    }
}
