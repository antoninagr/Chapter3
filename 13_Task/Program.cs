using System;

namespace _13_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, position, bit;
            Console.WriteLine("Въведете положително число n:");
            bool n = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Въведете положителна позиция p на бит:");
            bool p = int.TryParse(Console.ReadLine(), out position);
            Console.WriteLine("Въведете стойност v '1' или '0' :");
            bool v = int.TryParse(Console.ReadLine(), out bit);
            if (n && number >= 0 && p && position >= 0 && v && (bit == 0 | bit == 1))
            {
                if (bit == 0)
                {
                    int result = (~(1 << position) & number);
                    Console.WriteLine("Отговорът е: {0} или {1} в dec.",
               Convert.ToString(result, 2).PadLeft(32, '0'), result);
                }
                if (bit == 1)
                {
                    int resultOne = number | (1 << position);
                    Console.WriteLine("Отговорът е: {0} или {1} в dec.",
               Convert.ToString(resultOne, 2).PadLeft(32, '0'), resultOne);
                }
            }
        }
    }
}

