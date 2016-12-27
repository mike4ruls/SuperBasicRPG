//Name: Michael Ray
//Main Class
//Should do all the work for the program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class RPG
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Declaring and intializing objects for player 1
            Player p1 = new Warrior("Player1");
            Warrior wr = (Warrior)p1;
            //Generating items inside the bag
            p1.OpenBag();
            Console.Clear(); // So it doesn't get messy
            p1.AddSkill(wr.GetSkill());


            // Declaring and intializing objects for player 2
            Player p2 = new Theif("Player2");
            Theif th = (Theif)p2;
            p2.OpenBag();
            Console.Clear();
            p2.AddSkill(th.GetSkill());


            // Printing out Player 1 stats, inventory, and skills
            Console.WriteLine(p1);
            Console.WriteLine();
            p1.OpenBag();
            p1.ShowSkills();

            Console.WriteLine();
            Console.WriteLine();

            // Printing out Player 2 stats, inventory, and skills
            Console.WriteLine(p2);
            Console.WriteLine();
            p2.OpenBag();
            p2.ShowSkills();
            }
        }
    }

