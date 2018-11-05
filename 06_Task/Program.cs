using System;

namespace _06_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведи b:");
            int b = int.Parse(Console.ReadLine());

            int Perimeter = 2 * a + 2 * b;
            Console.WriteLine("Периметъра на правоъгълника е: " + Perimeter);

            int Area = a * b;
            Console.WriteLine("Лицето на правоъгълника е: " + Area);
        }
    }
}
