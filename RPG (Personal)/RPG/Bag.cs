using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Bag
    {
        private string name;
        private int slots;
        private int space;
        Items[] item;

        public Bag()
        {

        }
        public Bag(string nm)
        {
            name = nm;
            slots = 10;
            space = 0;
            item = new Items[slots];

            for (int i = 0; i < item.Length; i++)
            {
                item[i] = new Items();
            }
        }

        public void OpenBag()
        {
            Console.Clear();
            int num;
            ListItems();


            do{
            Console.Write("\nWhat would you like to do?");
            Console.WriteLine(" (Type in the number of the action that you want to do)");
            Console.WriteLine("1) Add an Item\n2)Remove an item\n3)Close bag");
            string numStr = Console.ReadLine();
            Boolean parsed = int.TryParse(numStr, out num);

            if(parsed == false)
            {
                continue;
            }

            if (num < 1 || num > 3)
            {
                Console.WriteLine("That is not an option, stop being stupid");
                continue;
            }

            else
            {
                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("What would you like to add to your bag? (Type in the number of the item to want)");
                            Console.WriteLine("1)Health Potion\n2)Mana Potion\n3)Wooden bow");
                            string choiceStr = Console.ReadLine();
                            int choice;
                            Boolean parsed1 = int.TryParse(choiceStr, out choice);
                            if (parsed == false)
                            {
                                Console.WriteLine("Come on take this seriously bro...");
                                continue;
                            }

                            if (choice < 1 || choice > 3)
                            {
                                Console.WriteLine("That isn't an option");
                            }
                            else
                            {
                                switch (choice)
                                {
                                    case 1:
                                        Console.Clear();
                                        Items hPotion = new HealthPotion();
                                        AddItem(hPotion);
                                        break;

                                    case 2:
                                        Console.Clear();
                                        Items mPotion = new ManaPotion();
                                        AddItem(mPotion);
                                        break;

                                    case 3:
                                        Console.Clear();
                                        Items bow = new Bow();
                                        AddItem(bow);
                                        break;
                                }
                                ListItems();
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Which item would you like to remove? (Type in the number of the item you'd like to remove)");
                            string choiceStr = Console.ReadLine();
                            int choice;
                            Boolean parsed1 = int.TryParse(choiceStr, out choice);
                            if (parsed == false)
                            {
                                Console.WriteLine("Come on take this seriously bro...");
                                continue;
                            }
                            choice -= 1;
                            if (choice < 0|| choice > item.Length)
                            {
                                Console.WriteLine("NOO!! that isn't an option, stahpp");
                            }
                            else
                            {
                                Console.Clear();
                                RemoveItem(choice);
                                ListItems();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            break;
                        }
                }
            }



            }while(num != 3);


        }

        public void ListItems()
        {

            int k = 1;
            Console.WriteLine(name + "'s Bag");
            Console.WriteLine("Inventory ({0}/{1}): ", space, slots);
            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine(k + ". " + item[i].ToString() + "\n");
                k += 1;
            }
        }

        public void AddItem(Items newitem)
        {
            Items nothing = new Items();
            string name = nothing.ToString();
            if (space == 10)
            {
                Console.WriteLine("( Your bag is full!! )\n");
            }
            else if (space <= item.Length)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i].ToString() == name)
                    {
                        item[i] = null;
                        item[i] = newitem;
                        space += 1;
                        break;
                    }
                }
               
            }


        }

        public void RemoveItem(int num)
        {
            if (num > item.Length || num < 0)
            {
                Console.WriteLine("That's not even a slot bro, git gud kid");

            }
            else if (space == 0)
            {
                Console.WriteLine("( There is nothing in the bag )");
            }
            else if (item[num].ToString() == "nothing")
            {
                Console.WriteLine("( There wasn't anything there to remove... )");
            }
            else
            {
                item[num] = null;
                item[num] = new Items();
                space -= 1;
                
               
            }

        }
    }
}
