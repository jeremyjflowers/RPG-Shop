using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player : Character
    {
        private float gold;
        private Item[] inventory;

        public Player() : base()
        {
            gold = 100;
            inventory = new Item[3];
        }

        public Player(string nameVal, float healthVal, int damageVal, float levelVal, float goldVal, int inventorySize) 
            : base(nameVal, healthVal, damageVal, levelVal)
        {
            gold = goldVal;
            inventory = new Item[inventorySize];
        }

        public Item[] GetInventory()
        {
            return inventory;
        }

        public void AddToInventory(Item item, int playerIndex)
        {
            inventory[playerIndex] = item;
        }

        public bool Buy(Item item, int playerIndex)
        {
            if(gold >= item.cost)
            {
                gold -= item.cost;
                AddToInventory(item, playerIndex);
                return true;
            }
            return false;
        }

        public float GetGold()
        {
            return gold;
        }
    }
}
