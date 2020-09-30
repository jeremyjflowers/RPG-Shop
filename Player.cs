using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Player
    {
        private int gold;
        private Item[] inventory;

        public Player()
        {
            gold = 100;
            //Creates an inventory array for the player with three items
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
    }
}
