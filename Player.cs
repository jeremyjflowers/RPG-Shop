using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace HelloWorld
{
    class Player : Character
    {
        private float gold;
        private Item[] inventory;
        private Item currentWeapon;

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

        public bool Contains(int playerIndex)
        {
            if(playerIndex > 0 && playerIndex < inventory.Length)
            {
                return true;
            }
            return false;
        }

        public void EquipWeapon(int playerIndex)
        {
            if(Contains(playerIndex))
            {
                currentWeapon = inventory[playerIndex];
            }
        }

        public override float Attack(Character enemy)
        {
            int totalDamage = baseDamage + currentWeapon.statBoost;
            return enemy.TakeDamage(totalDamage);
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

        public void PrintStats(float healthVal, int damageVal, float levelVal, int gold, int EXP)
        {
            Console.WriteLine("Health: " + healthVal);
            Console.WriteLine("Damage: " + damageVal);
            Console.WriteLine("Level: " + levelVal);
            Console.WriteLine("Gold: " + gold);
            Console.WriteLine("EXP: " + EXP);
        }
    }
}
