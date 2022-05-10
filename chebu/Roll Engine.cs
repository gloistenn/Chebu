using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chebu
{
    public class Roll
    {
        int roll = new object.Random();

        var bytes = new byte[5];
        rand.NextBytes(bytes);
        Console.WriteLine("Five random byte values:");
        foreach (byte byteValue in bytes)
        Console.Write("{0, 5}", byteValue);
        Console.WriteLine();

       





    }
}

