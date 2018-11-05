using System;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = number / 100;
            int b = a % 10;
            bool c = b == 7;
            Console.WriteLine(c);

        }
    }
}
