using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chebu
{
    internal class BattleEngine
    {
        //test Roman 123
        public void Hit(Character attacker, Character defender)

        {
         defender.CurrentHealth = defender.CurrentHealth - attacker.Damage;

        }

    }
}

