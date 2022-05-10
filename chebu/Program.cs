using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chebu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //test Roman 123 //test Roman 123
                Character Roma = new Character();
                Roma.MaxHealth = 100;
                Roma.CurrentHealth = 100;
                Roma.Damage = 10;
                Roma.Name = "Roma";

                Character Denys = new Character();
                Denys.MaxHealth = 100;
                Denys.CurrentHealth = 100;
                Denys.Damage = 15;
                Denys.Name = "Denys";

                BattleEngine battleEngine = new BattleEngine();
                while (Roma.IsDead != true && Denys.IsDead != true)
                {
                    battleEngine.Hit(Roma, Denys);
                    battleEngine.Hit(Denys, Roma);
                    Console.WriteLine($"{Roma.Name} attacked {Denys.Name}, and now {Denys.Name}'s Current health is {Denys.CurrentHealth}");
                    Console.WriteLine($"{Denys.Name} attacked {Roma.Name}, and now {Roma.Name}'s Current health is {Roma.CurrentHealth}");
                    if (Roma.CurrentHealth <= 0)
                        break;
                }



                Console.ReadLine();











            }
        }
    }
}
