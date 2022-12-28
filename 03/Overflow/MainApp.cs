using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a = a + 1;      // overflow

            Console.WriteLine(a);

            a = a + 1;      // overflow again

            Console.WriteLine(a);
        }
    }
}