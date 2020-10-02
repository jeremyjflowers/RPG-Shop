using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Player
    {
        private string name;
        private int gold;
        public float playerIndex;
        private Item[] inventory;

        public Player()
        {
            name = " ";
            gold = 200;
            //Creates an inventory array for the player with three items
            inventory = new Item[3];
        }

        public Player(string nameVal, int goldVal)
        {
            name = nameVal;
            gold = goldVal;
            inventory = new Item[3];
        }

        //Allows the player to buy items from shop
        public bool Buy(Item item, int inventoryIndex)
        {
           if(gold >= item.cost)
           {
                gold -= item.cost;
                inventory[inventoryIndex] = item;
                return true;
           }

            return false;
        }

        public int GetGold()
        {
            return gold;
        }

        public Item[] GetInventory()
        {
            return inventory;
        }

        public virtual void Save(StreamWriter writer)
        {
            //Saves the character's name, gold, and inventory
            writer.WriteLine(name);
            writer.WriteLine(gold);
            writer.WriteLine(inventory);
        }

        public virtual bool Load(StreamReader reader)
        {
            string name = reader.ReadLine();
            float gold = 0;
            //Checks if loading was successful
            if(float.TryParse(reader.ReadLine(), out gold) == false)
            {
                return false;
            }
            //Set to update the member variables and return true
            this.name = name;
            this.gold = (int)gold;
            return true;
        }
    }
}
