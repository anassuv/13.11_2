using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = x;
            int s = 0;
            while (n != 0) {
                s += n % 10;
                n /= 10;
            }
            Console.Write("{0} -> {1}\n\n", x, s);
            Console.ReadKey();
        }
    }
}
