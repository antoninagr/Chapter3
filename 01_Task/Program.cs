using System;

namespace _01_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine()); if (numb % 2 == 0) 
            { Console.WriteLine("Числото е четно"); }
            else
            {
                Console.WriteLine("Числото е нечетно");
            }
        }
    }
}
