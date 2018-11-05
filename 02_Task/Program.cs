using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            bool devisible = false; if (number % 5 == 0 && number % 7 == 0) { devisible = true; }
            Console.WriteLine("Числото се дели на 5 и на 7: {0} ", devisible);
        }
    }
}
