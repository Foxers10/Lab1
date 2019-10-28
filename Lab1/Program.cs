using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static double a, b, c;
        static double d, x1, x2, xk1, xk2;
        static void Main(string[] args)
        {
            Console.Title = "Лисин Андрей РТ5-31Б";
            int key1 = 1;
            do
            {
                try
                {
                    key1 = 1;
                    Console.WriteLine("Введите a, b, c");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadKey();
                    key1 = 0;
                }
            } while (key1 == 0);
            d = b*b - 4 * a * c;
            if (a == 0)
            {
                if ((-1 * c / b) > 0)
                {
                    xk1 = -1 * c / b;
                    x1 = Math.Sqrt(xk1);
                    Console.Write("корень х= +-");
                    Console.WriteLine(x1);
                }
                else if ((-1 * c / b) == 0)
                {
                    Console.WriteLine("корень х= 0");
                }
                else
                {
                    Console.WriteLine("действительных корней нет");
                }
            }
            else
            {
                if (d > 0)
                {
                    xk1 = (-b + Math.Sqrt(d)) / (2 * a);
                    xk2 = (-b - Math.Sqrt(d)) / (2 * a);
                    if (xk1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("действительных корней нет");
                    }
                    else
                    {
                        x1 = Math.Sqrt(xk1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("корень х1= +-");
                        Console.WriteLine(x1);
                        if (xk2 < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("второго корня нет");
                        }
                        else
                        {
                            x2 = Math.Sqrt(xk2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("корень х2= +-");
                            Console.WriteLine(x2);
                        }
                    }
                }
                else if (d == 0)
                {
                    xk1 = (-b) / (2 * a);
                    if (xk1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("действительных корней нет");
                    }
                    else
                    {
                        x1 = Math.Sqrt(xk1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("корень х= +-", x1);
                        Console.WriteLine(x1);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("действительных корней нет");
                }
            }
            Console.ReadKey();
        }
    }
}
