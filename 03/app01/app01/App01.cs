using System;

namespace IntegralTypes
{
    class App01
    {
        static void Main(string[] args)
        {
            sbyte a = -5;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; //7
            int f = 3_0000_0000;    //8

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;   //11
            long h = 200_0000_0000_0000_0000;   //18

            Console.WriteLine($"g={g}, f={h}");
        }
    }
}