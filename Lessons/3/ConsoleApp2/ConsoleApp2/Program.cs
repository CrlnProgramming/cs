using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
            Console.Clear();
            double a,b;
            Console.WriteLine("Write first number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write second number numbe");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Choose an option below \nfrom the list(1-6):");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Division with remainder");
            Console.WriteLine("6)Exponentiation operation");
            Console.WriteLine("7)Exit");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
                switch (n)
                {
                    case 1:
                        double c = a + b;
                        Console.WriteLine($"Сalculation result:  {c}"); break;
                    case 2:
                        c = a - b;
                        Console.WriteLine($"Сalculation result:  {c}"); break;
                    case 3:
                        c = a * b;
                        Console.WriteLine($"Сalculation result:  {c}"); break;
                    case 4:
                        c = a / b;
                        Console.WriteLine($"Сalculation result:  {c}"); break;
                    case 5:
                        c = a % b;
                        Console.WriteLine($"Сalculation result:  {c}"); break;
                    case 6:
                        c = (Math.Pow(a, b));
                        Console.WriteLine($"Сalculation result:  {c}"); break;
                    default:
                        Console.WriteLine("Error!Unknown action"); break;
                }
                Console.WriteLine("Tap Enter to continuation");
                Console.ReadLine();
            }
        }
    }
}





