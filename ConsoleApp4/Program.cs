using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());

            if (((x * x * x) - 15 * x) != 0)
            {
                Console.WriteLine(Math.Abs((x * x) - (x * x * x)) - ((7 * x) / ((x * x * x) - 15 * x)));
            }
            else Console.WriteLine("Знаменатель равен нулю");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Дана длина ребра куба. Найти площадь грани, площадь полной поверхности и объем этого куба.");
            Console.WriteLine();


            double a;
            Console.WriteLine("Введите длинну ребра куба");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Площадь грани:" + (a * a));

            Console.WriteLine("Площадь поверхости:" +  (6 * a * a));
            if (a < 0)
            {
                Console.WriteLine("Объем куба:" + (a * a * a));
            }
            else Console.WriteLine("Объем куба не может быть отрицательным");
            Console.ReadKey();
        }
    } 
}
