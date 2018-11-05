using System;

namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number: ");
            int number = int.Parse(Console.ReadLine());

            int mask = 1 << 3;
            int result = mask & number;
            result = result >> 3;

            if (result == 1)
            {
                Console.WriteLine("The bit 3 of a given number is 1");
            }

            else
            {
                Console.WriteLine("The bit 3 of a given number is 0");
            }
        }


    }
}
