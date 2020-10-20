using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Transactions;

namespace HelloWorld
{
    class Player : Character
    {
        private int gold;
        private Item[] inventory;
        private Item currentWeapon;

        public Player() : base()
        {
            gold = 100;
            inventory = new Item[3];
        }

        public Player(string nameVal, float healthVal, int damageVal, float levelVal, int goldVal) 
            : base(nameVal, healthVal, damageVal, levelVal)
        {
            gold = goldVal;
            inventory = new Item[9];
        }

        public Item[] GetInventory()
        {
            return inventory;
        }

        public bool Contains(int playerIndex)
        {
            if(playerIndex > 0 && playerIndex < inventory.Length)
            {
                return true;
            }
            return false;
        }

        public void EquipEquipment(int playerIndex)
        {
            if(Contains(playerIndex) == true)
            {
                currentWeapon = inventory[playerIndex];
            }
        }

        public override float Attack(Character enemy)
        {
            float totalDamage = baseDamage + currentWeapon.statBoost;
            return enemy.TakeDamage((int)totalDamage);
        }

        public bool Buy(Item item, int playerIndex)
        {
            if(gold >= item.cost)
            {
                gold -= item.cost;
                inventory[playerIndex] = item;
                return true;
            }
            return false;
        }

<<<<<<< Updated upstream
        public int GetGold(int gainedGold)
        {
            gainedGold = gold + 10;
            return gold;
=======
        public float GetGold()
        {
            return gold;
        }

        public void GainedGold()
        {
            float GainedGold = gold += 16;
>>>>>>> Stashed changes
        }

        public override void PrintStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + baseDamage);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Gold: " + gold);
            Console.WriteLine("EXP: " + EXP);
        }
    }
}
