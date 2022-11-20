using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            double x = Convert.ToDouble (Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код операции");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            int k = Convert.ToInt32(Console.ReadLine());
            double calc = 0;
            try
            {
                switch(k)
                {
                    case 1:
                        calc = x + y;
                        break;              
                    case 2:
                        calc = x - y;
                        break;                
                    case 3:
                        calc = x * y;
                        break;
                    case 4:
                        calc = x / y;
                        break;
                    default:
                        Console.WriteLine("Введен невеный код операции");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(calc);
            Console.ReadKey();
           

        }
    }
}
