using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"C:\Программирование\CS\LABA2\First\First\output.txt");
            var new_in = new StreamReader(@"C:\Программирование\CS\LABA2\First\First\input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double a, b, c, d, e;
            double s, k;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((e * a - b * c < 0) || (e - a <= 0))
                Console.WriteLine("ERROR");
            else
            {
                s = Math.Sqrt(e * a - b * c) / Math.Sqrt(e - a);
                Console.WriteLine(String.Format("{0:0.0000}", s));
            }

            if ((a - 2 * b < 0) || (e - a + c <= 0))
                Console.WriteLine("ERROR");
            else
            {
                k = Math.Sqrt((a - 2 * b) * (a - 2 * b) * (a - 2 * b)) / Math.Sqrt(e - a + c);
                Console.WriteLine(String.Format("{0:0.0000}", k));
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}