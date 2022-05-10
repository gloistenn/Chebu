using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chebu
{
    internal class Character
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public string ColorName { get; set; }

    }
}

