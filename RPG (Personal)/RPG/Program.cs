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
            Player p1 = new Player();
            int classChoice=0;


            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            do{
                Console.WriteLine("What class do you wish to be?\n1) Warrior (Very strong and tanky, but can't use magic really well and never stealthy)\n2) Theif (Very sneaky and fast, does a decent amount of damage over time, but dies really fast)");
                String classChoiceStr = Console.ReadLine();
                Boolean parsed = int.TryParse(classChoiceStr, out classChoice);

                 if(parsed == false)
                     {
                         Console.WriteLine("That is not a choice");
                         continue;
                     }

                 if (classChoice < 1 || classChoice > 2)
                     {
                        Console.WriteLine("Why...you know that isnt a choice...");
                        classChoice = 0;
                     }

                 else if (classChoice == 1)
                     {
                        p1 = new Warrior(name);
                        Warrior wr = (Warrior)p1;
                        p1.AddSkill(wr.GetSkill());
                     }

                 else if (classChoice == 2)
                     {
                         p1 = new Theif(name);
                         Theif th = (Theif)p1;
                         p1.AddSkill(th.GetSkill());
                     }


            }while(classChoice == 0);

            Console.Clear();
            Console.WriteLine(p1);
            int end = 0 ;
            do{
            Console.WriteLine("*To open up your bag and check your inventory press (I)");
            Console.WriteLine("*To display your skills press (S)");
            string choiceStr = Console.ReadLine();
            choiceStr = choiceStr.ToUpper();
            if (choiceStr != "I" && choiceStr != "S")
            {
                continue;
            }
            else if (choiceStr == "I") 
            { 
            p1.OpenBag();
            Console.WriteLine(p1);
            }

            else if (choiceStr == "S")
            {
                p1.ShowSkills();
                Console.WriteLine(p1);
            }

            }while( end == 0);
            }
        }
    }

