using System;

namespace SignedUnsigned
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 0b11111111;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            byte c = 0b10000001;
            sbyte d = (sbyte)c;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}