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
        private Character enemy1;
        private Character enemy2;
        private Character enemy3;
        private Character enemy4;
        private Character enemy5;
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
            Console.Write("> \n");

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
            Console.Write("> \n ");

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

        public void ClearScreen()
        {
            Console.WriteLine("Prees any key to proceed");
            Console.Write("> ");
            Console.ReadKey();
            Console.Clear();
        }

        public void ShowInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + " " + inventory[i].cost + " Gold"); 
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

        public void IntializeEnemies(Character character)
        {
            enemy1 = new Character ("Bandit", 50, 10, 12);
            enemy2 = new Character ("Wolf", 10, 5, 5);
            enemy3 = new Character ("Orc", 112, 24, 25);
            enemy4 = new Character ("Boss Bandit", 150, 24, 20);
            enemy5 = new Character("Giant", 220, 30, 39);
        }

        public void SwapEquipment(Player player)
        {
            Item[] inventory = player.GetInventory();
            char input = ' ';
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + inventory[i].name + "\nDamage: " + inventory[i].statBoost);
            }
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;
            switch(input)
            {
                case '1':
                    {
                        player.EquipEquipment(0);
                        Console.WriteLine("You have equipped " + inventory[0].name);
                        Console.WriteLine("Damage has been increased by " + inventory[0].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '2':
                    {
                        player.EquipEquipment(1);
                        Console.WriteLine("You have equipped " + inventory[1].name);
                        Console.WriteLine("Damage has been increased by " + inventory[1].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '3':
                    {
                        player.EquipEquipment(2);
                        Console.WriteLine("You have equipped " + inventory[2].name);
                        Console.WriteLine("Damage has been increased by " + inventory[2].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '4':
                    {
                        player.EquipEquipment(3);
                        Console.WriteLine("You have equipped " + inventory[3].name);
                        Console.WriteLine("Damage has been increased by " + inventory[3].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '5':
                    {
                        player.EquipEquipment(4);
                        Console.WriteLine("You have equipped " + inventory[4].name);
                        Console.WriteLine("Damage has been increased by " + inventory[4].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '6':
                    {
                        player.EquipEquipment(5);
                        Console.WriteLine("You have equipped " + inventory[5].name);
                        Console.WriteLine("Damage has been increased by " + inventory[5].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '7':
                    {
                        player.EquipEquipment(6);
                        Console.WriteLine("You have equipped " + inventory[6].name);
                        Console.WriteLine("Damage has been increased by " + inventory[6].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '8':
                    {
                        player.EquipEquipment(7);
                        Console.WriteLine("You have equipped " + inventory[7].name);
                        Console.WriteLine("Damage has been increased by " + inventory[7].statBoost);
                        Console.ReadLine();
                        break;
                    }
                case '9':
                    {
                        player.EquipEquipment(8);
                        Console.WriteLine("You have equipped " + inventory[8].name);
                        Console.WriteLine("Damage has been increased by " + inventory[8].statBoost);
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You did not swap equipment");
                        Console.ReadLine();
                        break;
                    }
            }
        }

        public void OpenMainMenu()
        {
            char input;
            GetInput(out input, "New Game", "Load Game", "Please select an option");
            if(input == '1')
            {
                Save();
                Explore();
            }
            else if(input == '2')
            {
                Load();
                Explore();
                return;
            }
        }

        public void Explore()
        {
            while(gameOver == false)
            {
                char input;
                GetInput(out input, "Battle an enemy", "Go to shop", "What would you like to do first?");
                if(input == '2')
                {
                    ShopMenu(shop);
                }
                BattleStart(player, enemy2);
                BattleStart(player, enemy1);
                BattleStart(player, enemy4);
                BattleStart(player, enemy3);
                BattleStart(player, enemy5);
            }
        }

        public void BattleStart(Player player, Character enemy)
        {
            Console.Clear();
            while(player.GetIsAlive() && enemy.GetIsAlive())
            {
                Console.WriteLine(player);
                player.PrintStats();
                Console.WriteLine(enemy);
                enemy.PrintStats();

                char input;
                GetInput(out input, "Attack", "Change Equipment", "Save", "Your turn");

                if(input == '1')
                {
                    float damageTaken = player.Attack(enemy);
                    Console.WriteLine("\n" + player.GetName() + " dealt " + damageTaken + " damage to " + enemy.GetName());

                    damageTaken = enemy.Attack(player);
                    Console.WriteLine(enemy.GetName() + " dealt " + damageTaken + " damage to " + player.GetName());
                    Console.ReadKey();
                }
                else if(input == '2')
                {
                    SwapEquipment(player);
                }
                else
                {
                    Save();
                }
                Console.Clear();

                if(player.GetIsAlive())
                {
<<<<<<< Updated upstream
                    player.GetGold();
                    player.GainEXP();
=======
                    player.GainedGold();
                    player.LevelUp();
>>>>>>> Stashed changes
                    continue;
                }
                else
                {
                    gameOver = true;
                }
            }
        }

        public void ShopMenu(Shop shop)
        {
            shopInventory = new Item[] {dagger, battleShield, broadSword, armour, woodenBow, dualBlades, cursedSword, demonicGauntlets, babyDragon};
            shop = new Shop(shopInventory);
            Console.WriteLine("\nWelcome to the shop, traveler!! What would you like?");
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
                Console.WriteLine("\nYou simply cannot afford this item traveler.");
                return;
            }
            ShowInventory(player.GetInventory());

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
                case '4':
                    {
                        playerIndex = 3;
                        break;
                    }
                case '5':
                    {
                        playerIndex = 4;
                        break;
                    }
                case '6':
                    {
                        playerIndex = 5;
                        break;
                    }
                case '7':
                    {
                        playerIndex = 6;
                        break;
                    }
                case '8':
                    {
                        playerIndex = 7;
                        break;
                    }
                case '9':
                    {
                        playerIndex = 8;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            shop.Sell(player, itemIndex, playerIndex);

            GetInput(out input, "Yes", "No", "Would you like to leave the shop?");
            if(input == '2')
            {
                ShopMenu(shop);
            }
            Console.WriteLine("Come again, traveler!");
            Explore();
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            player = new Player(name, 100, 4, 1, 50);
            player.PrintStats();
            IntializeItems();
            IntializeEnemies(enemy1);
            IntializeEnemies(enemy2);
            IntializeEnemies(enemy3);
            IntializeEnemies(enemy4);
            IntializeEnemies(enemy5);
            OpenMainMenu();
        }

        //Repeated until the game ends
        public void Update()
        {
            Explore();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thanks for playing!!!");
        }
    }
}
