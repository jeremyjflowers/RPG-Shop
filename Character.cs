﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Character
    {
        private string name;
        private float health;
        protected int baseDamage;
        private float level;
        protected int EXP;

        public Character()
        {
            name = " ";
            health = 100;
            baseDamage = 9;
            level = 1;
        }

        public Character(string nameVal, float healthVal, int damageVal, float levelVal)
        {
            name = nameVal;
            health = healthVal;
            baseDamage = damageVal;
            level = levelVal;
        }

        public virtual float Attack(Character enemy)
        {
            float damageTaken = enemy.TakeDamage(baseDamage);
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
                    level += 1;
                    UpgradeStats(health, baseDamage);
                }
            }
        }

        public void UpgradeStats(float health, int baseDamage)
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
                baseDamage += 9;
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

        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine(name);
            writer.WriteLine(health);
            writer.WriteLine(baseDamage);
            writer.WriteLine(level);
        }

        public virtual bool Load(StreamReader reader)
        {
            string name = reader.ReadLine();
            float health = 0;
            int baseDamage = 0;
            float level = 0;

            if (float.TryParse(reader.ReadLine(), out health) == false)
            {
                return false;
            }
            if(int.TryParse(reader.ReadLine(), out baseDamage) == false)
            {
                return false;
            }
            if(float.TryParse(reader.ReadLine(), out level) == false)
            {
                return false;
            }

            this.name = name;
            this.health = health;
            this.baseDamage = baseDamage;
            this.level = level;
            return true;
        }
    }
}
