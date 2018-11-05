using System;

namespace _07_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Напишете килограмите си: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вашите килограми на луната са: {0} кг. ", weight * 0.17);
        }
    }
}
