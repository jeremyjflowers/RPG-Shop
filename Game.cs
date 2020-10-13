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
        private Player player1;
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
                Console.WriteLine((i + 1) + ". " + inventory[i].name + inventory[i].cost + " Gold"); 
            }
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            player1.Save(writer);
            writer.Close();
        }

        public void Load()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            player1.Load(reader);
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
            enemy1 = new Character ("Bandit", 50, 10, 12);
            enemy2 = new Character ("Wolf", 10, 5, 5);
            enemy3 = new Character ("Orc", 112, 24, 25);
            enemy4 = new Character ("Boss Bandit", 150, 24, 20);
            enemy5 = new Character("Giant", 220, 30, 39);
        }

        public Player CreateCharacter()
        {
            Console.WriteLine("\nPlease state your name, traveler.");
            string name = Console.ReadLine();
            Player player1 = new Player(name, 100, 9, 1, 20, 5);
            player1.PrintStats();
            return player1;
        }

        public void SwapEquipment(Player player1)
        {
            Item[] inventory = player1.GetInventory();
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
                        player1.EquipEquipment(0);
                        Console.WriteLine("You have equipped " + inventory[0].name);
                        Console.WriteLine("Damage has been increased by " + inventory[0].statBoost);
                        break;
                    }
                case '2':
                    {
                        player1.EquipEquipment(1);
                        Console.WriteLine("You have equipped " + inventory[1].name);
                        Console.WriteLine("Damage has been increased by " + inventory[1].statBoost);
                        break;
                    }
                case '3':
                    {
                        player1.EquipEquipment(2);
                        Console.WriteLine("You have equipped " + inventory[2].name);
                        Console.WriteLine("Damage has been increased by " + inventory[2].statBoost);
                        break;
                    }
                case '4':
                    {
                        player1.EquipEquipment(3);
                        Console.WriteLine("You have equipped " + inventory[3].name);
                        Console.WriteLine("Damage has been increased by " + inventory[3].statBoost);
                        break;
                    }
                case '5':
                    {
                        player1.EquipEquipment(4);
                        Console.WriteLine("You have equipped " + inventory[4].name);
                        Console.WriteLine("Damage has been increased by " + inventory[4].statBoost);
                        break;
                    }
                case '6':
                    {
                        player1.EquipEquipment(5);
                        Console.WriteLine("You have equipped " + inventory[5].name);
                        Console.WriteLine("Damage has been increased by " + inventory[5].statBoost);
                        break;
                    }
                case '7':
                    {
                        player1.EquipEquipment(6);
                        Console.WriteLine("You have equipped " + inventory[6].name);
                        Console.WriteLine("Damage has been increased by " + inventory[6].statBoost);
                        break;
                    }
                case '8':
                    {
                        player1.EquipEquipment(7);
                        Console.WriteLine("You have equipped " + inventory[7].name);
                        Console.WriteLine("Damage has been increased by " + inventory[7].statBoost);
                        break;
                    }
                case '9':
                    {
                        player1.EquipEquipment(8);
                        Console.WriteLine("You have equipped " + inventory[8].name);
                        Console.WriteLine("Damage has been increased by " + inventory[8].statBoost);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You did not swap equipment");
                        break;
                    }
            }
        }

        public void OpenMainMenu()
        {
            char input;
            GetInput(out input, "Create Character", "Load Character", "Please select an option");
            if(input == '1')
            {
                CreateCharacter();
                Explore();
            }
            else if(input == '2')
            {
                player1 = new Player();
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
                BattleStart(enemy2);
                BattleStart(enemy1);
                BattleStart(enemy4);
                BattleStart(enemy3);
                BattleStart(enemy5);
            }
        }

        public void BattleStart(Character enemy)
        {
            while(player1.GetIsAlive() && enemy.GetIsAlive())
            {
                Console.WriteLine(player1);
                player1.PrintStats();
                Console.WriteLine(enemy);
                enemy.PrintStats();

                char input;
                GetInput(out input, "Attack", "Change Equipment", "Save", "Your turn");

                if(input == '1')
                {
                    float damageTaken = player1.Attack(enemy);
                    Console.WriteLine(player1.GetName() + " dealt " + damageTaken + " damage to " + enemy.GetName());

                    damageTaken = enemy.Attack(player1);
                    Console.WriteLine(enemy.GetName() + " dealt " + damageTaken + " damage to " + player1.GetName());
                }
                else if(input == '2')
                {
                    SwapEquipment(player1);
                    float damageTaken = enemy.Attack(player1);
                    Console.WriteLine(enemy.GetName() + " dealt " + damageTaken + " damage to " + player1.GetName());
                }
                else
                {
                    Save();
                }
                Console.Clear();

                if(player1.GetIsAlive())
                {
                    player1.gainedGold();
                    player1.GainEXP();
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
            Console.WriteLine("Welcome to the shop, traveler!! What would you like?");
            ShowInventory(shopInventory);
            Console.WriteLine("Gold: " + player1.GetGold());

            char input = Console.ReadKey().KeyChar;

            int itemIndex = -1;
            int playerIndex = -1;
            switch(input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        player1.AddToInventory(dagger, playerIndex);
                        break;
                    }
                case '2':
                    {
                        itemIndex = 1;
                        player1.AddToInventory(battleShield, playerIndex);
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        player1.AddToInventory(broadSword, playerIndex);
                        break;
                    }
                case '4':
                    {
                        itemIndex = 3;
                        player1.AddToInventory(armour, playerIndex);
                        break;
                    }
                case '5':
                    {
                        itemIndex = 4;
                        player1.AddToInventory(woodenBow, playerIndex);
                        break;
                    }
                case '6':
                    {
                        itemIndex = 5;
                        player1.AddToInventory(dualBlades, playerIndex);
                        break;
                    }
                case '7':
                    {
                        itemIndex = 6;
                        player1.AddToInventory(cursedSword, playerIndex);
                        break;
                    }
                case '8':
                    {
                        itemIndex = 7;
                        player1.AddToInventory(demonicGauntlets, playerIndex);
                        break;
                    }
                case '9':
                    {
                        itemIndex = 8;
                        player1.AddToInventory(babyDragon, playerIndex);
                        break;
                    }
                default:
                    {
                        return;
                    }  
            }
            if(player1.GetGold() < shopInventory[itemIndex].cost)
            {
                Console.WriteLine("You simply cannot afford this item traveler.");
                return;
            }
            shop.Sell(player1, itemIndex, playerIndex);

            GetInput(out input, "Yes", "No", "Would you like to leave the shop?");
            if(input == '2')
            {
                return;
            }
            Console.WriteLine("Come again, traveler!");
            Explore();
        }

        //Performed once when the game begins
        public void Start()
        {
            IntializeItems();
            IntializeEnemies(enemy1);
            IntializeEnemies(enemy2);
            IntializeEnemies(enemy3);
            IntializeEnemies(enemy4);
            IntializeEnemies(enemy5);
            OpenMainMenu();
            CreateCharacter();
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
