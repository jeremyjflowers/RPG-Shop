using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Shop
    {
        private int gold;
        private Item[] inventory;

        public Shop()
        {
            gold = 45;
            inventory = new Item[5];
        }

        public Shop(Item[] items)
        {
            gold = 45;
            //Creates an inventory array for the shop's items
            inventory = items;
        }

        public bool Sell(Player player, int itemIndex, int playerIndex)
        {
            //Finds the item to buy in the inventory array
            Item itemToBuy = inventory[itemIndex];
            //Checks if the item was purchased successfully
            if(player.Buy(itemToBuy, playerIndex))
            {
                //Increases the shop's gold by the cost of the item
                gold += itemToBuy.cost;
                return true;
            }

            return false;
        }
    }
}
