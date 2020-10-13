using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int gold;
        private Item[] inventory;

        public Shop()
        {
            gold = 0;
            inventory = new Item[9];
        }

        public Shop(Item[] item)
        {
            gold = 0;
            inventory = item;
        }

        public bool Sell(Player player, int itemIndex, int playerIndex)
        {
            Item itemToBuy = inventory[itemIndex];
            if(player.Buy(itemToBuy, playerIndex))
            {
                gold += itemToBuy.cost;
                return true;
            }
            return false;
        }

        public Item[] GetInventory()
        {
            return inventory;
        }
    }
}
