using System;

namespace _10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("1.Сбор на цифрите = {0}", a + b + c + d);
            Console.WriteLine("2.Цифрите в обратен ред = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("3.Последна цифра на първо място = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("4.Размяна на трета и втора цифра = {0}{2}{1}{3}", a, b, c, d);
        }
    }
}
