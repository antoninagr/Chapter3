using System;

namespace _12_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи v:");
            int v = int.Parse(Console.ReadLine());

            Console.Write("Въведи p:");
            int p = int.Parse(Console.ReadLine());

            int i = 1;
            int mask = i << p;
            int result = v & mask;

            Console.Write("Бита на позиция p от числото v:");
            if (result == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


        }
    }
}
