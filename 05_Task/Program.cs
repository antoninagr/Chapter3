using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведи b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведи h:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Площ: ");
            Console.WriteLine((a + (b - a) / 2) * h);
        }
    }
}
