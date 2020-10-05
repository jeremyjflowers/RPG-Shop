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
        private Character player;
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
        private Item longSword;
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
            longSword.name = "Long Sword";
            longSword.statBoost = 19;
            longSword.cost = 14;
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
            enemy3 = new Character("Orc", 112, 24, 25);
        }

        public void CreateCharacter(Character player)
        {
            Console.WriteLine("Please state your name, traveler.");
            
        }

        public void ShopMenu()
        {

        }

        //Performed once when the game begins
        public void Start()
        {
 
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
