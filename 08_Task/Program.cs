using System;

namespace _08_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Въведете y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool isInside = (x * x + y * y <= 25) ? true : false;
            Console.WriteLine("Точка O({0},{1}) е вътре в окръжността K((0,0),5): {2}", x, y, isInside);
        }
    }
}
