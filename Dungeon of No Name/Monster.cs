using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_of_No_Name
{
    public class Monster
    {
        public String Name { get; set; }
        public int Health { get; set; }
        public int AttackStrength { get; set; }

        public Monster(String name, int health, int attackStrength)
        {
            Name = name;
            Health = health;
            AttackStrength = attackStrength;
        }
    }
}
