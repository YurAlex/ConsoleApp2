using System;

namespace ConsoleApp2
{
    class Program
    {
        private static double Sum (double num1, double num2)
        {
            return num1 + num2;
        }

        private static double Dif (double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Prod(double num1, double num2)
        {
            return num1 * num2;
        }

        private static double Quot(double num1, double num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");

            bool repeat = true;
            while (repeat)
            {
                Console.Write("Значение 1: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Действие: ");
                char action = char.Parse(Console.ReadLine());
                Console.Write("Значение 2: ");
                double num2 = double.Parse(Console.ReadLine());
                switch(action)
                {
                    case '+':
                        Console.WriteLine(Sum(num1, num2));
                        break;
                    case '-':
                        Console.WriteLine(Dif(num1, num2));
                        break;
                    case '*':
                        Console.WriteLine(Prod(num1, num2));
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine(Quot(num1, num2));
                        }
                        else 
                        {
                            Console.WriteLine("На 0 делить нельзя");
                        }
                        break;
                }
                Console.WriteLine("Повторить Y/N");
                char answer = char.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 'Y':
                    case 'y':
                    case 'Н':
                    case 'н':
                        break;

                    case 'N':
                    case 'n':
                    case 'Т':
                    case 'т':
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Некоректный ввод");
                        break;
                }
                
            }
               
                
            
        }
    }
}
