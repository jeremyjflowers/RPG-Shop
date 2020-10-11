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
        public int statBoost;
        public int cost;
    }

    class Game
    {
        private bool gameOver = false;
        private Player player;
        private Character enemy;
        private Shop shop;
        private Item battleShield;
        private Item armour;
        private Item babyDragon;
        private Item cursedSword;
        private Item woodenBow;
        private Item broadSword;
        private Item dagger;
        private Item demonicGauntlets;
        private Item dualBlades;
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
                    Console.WriteLine(" I don't understand your logic here.");
                }
            }
        }

        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.Write("> ");

            input = ' ';
            while(input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if(input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("I don't understand your logic here.");
                }
            }
        }

        public void ShowInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + inventory[i].cost + " Gold"); 
            }
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            player.Save(writer);
            writer.Close();
        }

        public void Load()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            player.Load(reader);
            reader.Close();
        }

        public void IntializeItems()
        {
            battleShield.name = "Battle Shield";
            battleShield.statBoost = 17;
            battleShield.cost = 10;
            armour.name = "Gilgamesh";
            armour.statBoost = 32;
            armour.cost = 19;
            babyDragon.name = "Dragon Hatchling";
            babyDragon.statBoost = 92;
            babyDragon.cost = 60;
            cursedSword.name = "Devil's Sword";
            cursedSword.statBoost = 49;
            cursedSword.cost = 36;
            woodenBow.name = "Bow and 50 Arrows";
            woodenBow.statBoost = 25;
            woodenBow.cost = 20;
            broadSword.name = "Broad Sword";
            broadSword.statBoost = 28;
            broadSword.cost = 16;
            dagger.name = "Dagger";
            dagger.statBoost = 14;
            dagger.cost = 7;
            demonicGauntlets.name = "Beowulf";
            demonicGauntlets.statBoost = 78;
            demonicGauntlets.cost = 39;
            dualBlades.name = "Twin Swords";
            dualBlades.statBoost = 43;
            dualBlades.cost = 24;
        }

        public void IntializeEnemies(Character enemy)
        {
            enemy = new Character ("Bandit", 50, 10, 12);
            enemy = new Character ("Wolf", 10, 5, 5);
            enemy = new Character ("Orc", 112, 24, 25);
            enemy = new Character ("Boss Bandit", 150, 24, 20);
            enemy = new Character("Giant", 220, 30, 39);
        }

        public void CreateCharacter(Player player)
        {
            Console.WriteLine("Please state your name, traveler.");
            string name = Console.ReadLine();
            new Player(name, 100, 9, 1, 20, 5);
        }

        public void OpenMainMenu()
        {
            char input;
            GetInput(out input, "Create Character", "Load Character", "Please select an option");
            if(input == '1')
            {
                CreateCharacter(player);
                Save();
            }
            else if(input == '2')
            {
                player = new Player();
                Load();
                return;
            }
        }

        public void ShopMenu(Shop shop)
        {
            shopInventory = new Item[] { battleShield, armour, babyDragon, cursedSword, woodenBow, broadSword, dagger, demonicGauntlets, dualBlades };
            shop = new Shop(shopInventory);
            Console.WriteLine("Welcome to the shop, traveler!! What would you like?");
            ShowInventory(shopInventory);
            Console.WriteLine("Gold: " + player.GetGold());

            char input = Console.ReadKey().KeyChar;

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
                case '6':
                    {
                        itemIndex = 5;
                        break;
                    }
                case '7':
                    {
                        itemIndex = 6;
                        break;
                    }
                case '8':
                    {
                        itemIndex = 7;
                        break;
                    }
                case '9':
                    {
                        itemIndex = 8;
                        break;
                    }
                default:
                    {
                        return;
                    }  
            }
            if(player.GetGold() < shopInventory[itemIndex].cost)
            {
                Console.WriteLine("You simply cannot afford this item traveler.");
                return;
            }

            Console.WriteLine("Which slot would you like to place the item in?");
        }

        //Performed once when the game begins
        public void Start()
        {
            IntializeItems();
            IntializeEnemies(enemy);
            OpenMainMenu();
        }

        //Repeated until the game ends
        public void Update()
        {

        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thanks for playing!!!");
        }
    }
}
