using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_One
{
    class First
    {
        static void Main(string[] args)
        {
            double Z = 8.5;
            double z = 3.2;
            double X = 4.0;
            double x = 2.5;

            if (Z == 0)
            {
                Console.WriteLine("Делить на 0 нельзя");
                Console.ReadKey();
                return;
            }

            if (x + X == 0)
            {
                Console.WriteLine("Делить на 0 нельзя");
                Console.ReadKey();
                return;
            }

            double p1 = Z * (z + x);
            double p2 = z / Z;
            double p3 = (z + Z) / (x + X);
            double Y = p1 + p2 - p3;

            Console.WriteLine($"Результат: {Y}");

            Console.WriteLine("");
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}