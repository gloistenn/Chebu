using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chebu
{
    internal class Color
    {
        public void ColorGreen(Character character)
        {
            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(character.Name);

            Console.ForegroundColor = currentColor;

        }
    }
}
