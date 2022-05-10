using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chebu
{
    internal class BattleEngine
    {

        public void Hit(Character attacker, Character defender)

        {
         defender.CurrentHealth = defender.CurrentHealth - attacker.Damage;

        }


        public void battle (Character player1, Character player2)
        {

        }
    }
}

