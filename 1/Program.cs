using laba3_4.kuznecov;
using System;
using System.Collections.Generic;

namespace laba3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = 0, b = 0, c = 0;
                Console.WriteLine("ente 3 parameters a, b and c");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                MyLog.log("The equation is introduced: " + a + "X^2+" + b + "X+" + c + "=0");
                QuadraticEquation qe = new QuadraticEquation();
                List<double> list = qe.solve(a, b, c);
                String s = "Roots: ";
                foreach (double i in list)
                {
                    s += i + " ";
                }

                MyLog.log(s);

            }
            catch (KuzecovExeption e)
            {
                MyLog.log("Error: " + e.Message);
            }
            MyLog.write();
            Console.ReadKey();
        }
    }
}
