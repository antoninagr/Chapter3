using System;

namespace _14_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи n:");

            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            Console.WriteLine("Числото е просто-");
            Console.WriteLine(isPrime.ToString().ToLower());

        }
    }
}
