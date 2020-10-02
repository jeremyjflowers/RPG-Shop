using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    //Defines the items
    struct Item
    {
        public string name;
        public int cost;
    }

    class Game
    {
        private bool gameOver = false;
        private Player player;
        private Shop shop;
        private Item bowAndarrows;
        private Item specialGem;
        private Item shortSword;
        private Item greatSword;
        private Item bombs;
        private Item[] shopInventory;

        public void Run()
        {
            Start();

            while(gameOver == false)
            {
                Update();
            }

            End();
        }

        public void Save()
        {
            //Creates a new stream writer
            StreamWriter writer = new StreamWriter("SaveData.txt");
            //Calls save for player instance
            player.Save(writer);
            //Closes the writer
            writer.Close();
        }

        public void Load()
        {
            //Creates a new stream reader
            StreamReader reader = new StreamReader("SaveData.txt");
            //Calls load for player instance
            player.Load(reader);
            //Closes the reader
            reader.Close();
        }

        //Intializes the items
        private void IntializeItems()
        {
            bowAndarrows.name = "Bow and 30 Arrows";
            bowAndarrows.cost = 17;
            specialGem.name = "Special Gem";
            specialGem.cost = 25;
            shortSword.name = "Short Sword";
            shortSword.cost = 12;
            greatSword.name = "Great Sword";
            greatSword.cost = 45;
            bombs.name = "5 Bombs";
            bombs.cost = 9;
        }

        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.Write("> ");

            input = ' ';
            while(input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if(input != '1' && input != '2')
                {
                    Console.WriteLine(" I don't understand what you want to do.");
                }
            }
        }

        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name, +inventory[i].cost);
            }
        }

        private void OpenShopMenu()
        {
            //Prints welcome message and choices to the screen
            Console.WriteLine("\nWelcome to the shop, traveler! What would you like?");
            PrintInventory(shopInventory);
            Console.WriteLine("\nGold: " + player.GetGold());

            //Gets the player's input
            char input = Console.ReadKey().KeyChar;

            //Sets itemIndex to the index the player chooses
            int itemIndex = -1;
            switch(input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }
                case '2':
                    {
                        itemIndex = 1;
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        break;
                    }
                case '4':
                    {
                        itemIndex = 3;
                        break;
                    }
                case '5':
                    {
                        itemIndex = 4;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            if(player.GetGold() < shopInventory[itemIndex].cost)
            {
                Console.WriteLine("\nSorry, you must have that broke boi syndrome.");
                return;
            }

            //Asks the player to select a slot in their inventory
            Console.WriteLine("\nChoose a slot to replace.");
            PrintInventory(player.GetInventory());

            //Gets the player's input
            input = Console.ReadKey().KeyChar;

            //Sets the value of the playerIndex by the player's choice
            int playerIndex = -1;
            switch(input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }
                case '2':
                    {
                        playerIndex = 1;
                        break;
                    }
                case '3':
                    {
                        playerIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            //Sell item to player and replace the weapon at the index with the newly purchased item
            shop.Sell(player, itemIndex, playerIndex);

            GetInput(out input, "Continue shopping", "Leave the shop", "\nWould you like to keep shopping?");

            if(input == '1')
            {
                return;
            }
            else if(input == '2')
            {
                Save();
                Console.WriteLine("\nThank you for shopping!!!");
                gameOver = true;
            }
        }

        public void OpenMainMenu()
        {
            char input;
            GetInput(out input, "New Character", "Load a Character", "What would you like to do?");
            if (input == '1')
            {
                Update();
            }
            else if (input == '2')
            {
                Load();
            }
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            player = new Player(name, 200);
            IntializeItems();
            shopInventory = new Item[] { bowAndarrows, specialGem, shortSword, greatSword, bombs };
            shop = new Shop(shopInventory);
            OpenMainMenu(); 
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thanks for playing!!!");
        }
    }
}
