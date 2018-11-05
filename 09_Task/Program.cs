using System;

namespace _09_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете X координати: ");
            decimal x = decimal.Parse(Console.ReadLine());

            Console.Write("Въведете Y координати: ");
            decimal y = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            bool result = (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9) && ((x < -1) || ((x >= -1) && ((y <= -1) || (y >= 1))));
            Console.WriteLine("Координатите са в окръжността и извън правоъгълника: {0}", result);
        }
    }
}


