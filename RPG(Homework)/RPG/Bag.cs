//Name: Michael Ray
//Bag Class
//The Bag class has multiple methods, one to do the main functions in the bag
//then another for displaying the content in the bag, one to add items to the bag
//and one to remove items from the bag.  
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
        private Items[] item; // Data structure to hold item objects

        public Bag()
        {

        }
        public Bag(string nm)
        {
            name = nm;
            slots = 10;
            space = 0;
            item = new Items[slots];


            // Inserts a blank item object into the items array
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = new Items();
            }
        }

        /// <summary>
        /// Should atleast print out the content of inventory ask what items you would
        /// like to add or remove and leave the bag;
        /// </summary>

        public void OpenBag()
        {
            int num; // four the choice you want to make
            ListItems();

            //Loop to keep you in the bag
            do{
            string numStr = "1"; //Initially had user input, didn't feel like taking this out
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
                Random rgen = new Random();
                num = 1; // Makes sure it always adds items to the until it is full

                // So I can exit as soon as the bag is full
                if (space == 10)
                {
                    num = 3;
                }
                switch (num)
                {
                        //To add items
                    case 1:
                        {
                            int choice = rgen.Next(1,4); // Randommizes the items input into the bag


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
                                        Items hPotion = new HealthPotion(50);
                                        AddItem(hPotion);
                                        break;

                                    case 2:
                                        Console.Clear();
                                        Items mPotion = new ManaPotion(50);
                                        AddItem(mPotion);
                                        break;

                                    case 3:
                                        Console.Clear();
                                        Items bow = new Bow(1);
                                        AddItem(bow);
                                        break;
                                }
                                ListItems();
                            }

                            break;
                        }

                        //To remove items
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
                                RemoveItem(choice);
                                Console.Clear();
                                ListItems();
                            }
                            break;
                        }

                        // To leave bag
                    case 3:
                        {
                           
                            break;
                        }
                }
            }



            }while(num != 3);


        }


        /// <summary>
        /// Should list out the content of the bag
        /// </summary>
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


        /// <summary>
        /// Should add an item object to the item array
        /// </summary>
        /// <param name="newitem">an item object</param>
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

        /// <summary>
        /// Should find specific item and remove it
        /// </summary>
        /// <param name="num">Number of slot</param>
        public void RemoveItem(int num)
        {
            if (num > item.Length || num < 0)
            {
                Console.WriteLine("That's not even a slot bro, git gud kid");

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
