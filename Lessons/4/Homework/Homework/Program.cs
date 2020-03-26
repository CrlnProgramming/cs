using System;


namespace Homework
{
    class Program
    { 
        static void Main(string[] args)
        {
            var names = new string[3]; 
            var old = new int[3];
            for (var i = 0; i < names.Length; i++)
            {
                Console.Write($"Введите Имя №{i}: ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (var j = 0; j < old.Length; j++)
            {
                Console.Write($"Введите возраст {j}: ");
                old[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (var i = 0; i < names.Length;)
            {
                Console.WriteLine(names[i]);
                i++;
            }
            Console.WriteLine();
            for (var j = 0; j <names.Length; )
            {
                Console.WriteLine($"{names[j]} Возраст через 4 года :{old[j] + 4} ");
                j++;
            }
            Console.ReadKey();
        }
    }
}



