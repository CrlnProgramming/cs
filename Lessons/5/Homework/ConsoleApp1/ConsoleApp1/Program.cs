using System;

namespace ConsoleApp1
{
    enum Container:byte
    {
        Litter = 0b00000001,
        FiveLitter = 0b00000010,
        TwentyLitter = 0b00000100,//20
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write ur number: ");
            var number = Convert.ToDouble(Console.ReadLine());
            

            if (number >= 20)
            {
                var number20 = Convert.ToInt32(number % 20);
                number20 = number20 | (int)Container.TwentyLitter;
                if ((number20 & (int)Container.TwentyLitter) == (int)Container.TwentyLitter)
                {
                    Console.WriteLine($"В числе присутствует контейнеры больше 20 литров {Container.TwentyLitter}");
                }
            }

            if (number <= 5)
            {
                var number1 = Convert.ToInt32(number % 5); number1 = number1 | (int)Container.Litter;
                if ((number1 & (int)Container.FiveLitter) == (int)Container.FiveLitter)
                {
                    Console.WriteLine("В числе присутствует контейнеры по 5 литров");
                }
            }

            if (number > 5 & number < 20)
            {
                var number5 = Convert.ToInt32(number % 5); number5 = number5 | (int)Container.FiveLitter;
                if ((number5 & (int)Container.FiveLitter) == (int)Container.FiveLitter)
                {
                    Console.WriteLine("В числе присутствует контейнеры по 5 литров");
                }
            }
        }
    }
}


