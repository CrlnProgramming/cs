using System;

namespace ConsoleClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            string[] Mass = new string[n];
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Mass[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Mass[i]);
            }

        }
    }
}
