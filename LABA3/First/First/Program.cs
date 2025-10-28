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
            var new_out = new StreamWriter(@"C:\Программирование\CS\LABA3\First\First\output.txt");
            var new_in = new StreamReader(@"C:\Программирование\CS\LABA3\First\First\input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            try
            {
                int t = 0, N = 1;
                double X = 0, Y = 0, Z = 0;

                t = Convert.ToInt32(Console.ReadLine());
                N = Convert.ToInt32(Console.ReadLine());
                X = Convert.ToDouble(Console.ReadLine());
                Y = Convert.ToDouble(Console.ReadLine());

                int i, step;
                double znam = 1, chisl = 0;

                Z = 0;

                if (t == 0)
                {
                    for (i = 1; i <= N; i++)
                    {
                        step = i * 2;
                        znam *= (step - 1) * step;
                        if (i % 2 == 0)
                            chisl = -Math.Pow(Y, step);
                        else
                            chisl = Math.Pow(X, step);
                        Z += (step - 1) * (step + 1) * chisl / znam;
                    }
                }
                else if (t == 1)
                {
                    i = 1;
                    while (i <= N)
                    {
                        step = i * 2;
                        znam *= (step - 1) * step;
                        if (i % 2 == 0)
                            chisl = -Math.Pow(Y, step);
                        else
                            chisl = Math.Pow(X, step);
                        Z += (step - 1) * (step + 1) * chisl / znam;
                        i++;
                    }
                }
                else if (t == 2)
                {
                    i = 1;
                    do
                    {
                        step = i * 2;
                        znam *= (step - 1) * step;
                        if (i % 2 == 0)
                            chisl = -Math.Pow(Y, step);
                        else
                            chisl = Math.Pow(X, step);
                        Z += (step - 1) * (step + 1) * chisl / znam;
                        i++;
                    }
                    while (i <= N);
                }

                Console.WriteLine(String.Format("{0:0.00000000}", Z));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                Console.SetOut(save_out);
                new_out.Close();
                Console.SetIn(save_in);
                new_in.Close();
            }
        }
    }
}