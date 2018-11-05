using System;

namespace _11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи n:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Въведи p:");
            int p = int.Parse(Console.ReadLine());

            int i = 1;
            int mask = i << p;
            int result = n & mask;
            Console.Write("Бита на позиция p от числото n:");
            if (result == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
