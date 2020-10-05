using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Character
    {
        private string name;
        private float health;
        protected int damage;
        private float level;
        private int EXP;

        public Character()
        {
            name = " ";
            health = 100;
            damage = 9;
            level = 1;
        }

        public Character(string nameVal, float healthVal, int damageVal, float levelVal)
        {
            name = nameVal;
            health = healthVal;
            damage = damageVal;
            level = levelVal;
        }

        public virtual float Attack(Character enemy)
        {
            float damageTaken = enemy.TakeDamage(damage);
            return damageTaken;
        }

        public virtual float TakeDamage(int damageVal)
        {
            health -= damageVal;
            if(health < 0)
            {
                health = 0;
            }
            return damageVal;
        }

        public void LevelUp(float level, int EXP)
        {
            while (EXP > 100)
            {
                EXP += 1;
                if (EXP <= 100)
                {
                    UpgradeStats(health, damage);
                }
            }
        }

        public void UpgradeStats(float health, int damage)
        {
            Console.WriteLine("LEVEL UP!!!! You are now level " + level + "! Please choose a stat to upgrade.");
            Console.WriteLine("1. Increase Health");
            Console.WriteLine("2. Increase Damage");
            char input = ' ';

            if(input == '1')
            {
                health += 60;
                Console.WriteLine("Your health has been increased by 60 points.");
            }
            else if(input == '2')
            {
                damage += 9;
                Console.WriteLine("Your damage has been increased by 9 points.");
            }

        }

        public float GetEXP()
        {
            return EXP;
        }

        public bool GetIsAlive()
        {
            return health > 0;
        }
    }
}
