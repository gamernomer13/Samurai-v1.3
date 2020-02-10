using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ClassA
    {
        protected List<double> myAL = new List<double>();


        public List<double> MyAL
        {
            get { return myAL; }
            set { myAL = value; }
        }
        public List<double> linearEquation(int a, int b)
        {
            if (a == 0)
            {
                throw new Exception("the equation does not exist!");
            }
            myAL.Add((double)-b / a);

            return myAL;
        }
    }

    class ClassB : ClassA
    {

        protected double discriminant(int a, int b, int c)
        {

            return b * b - 4 * a * c;

        }




        public List<double> solve(int a, int b, int c)
        {

            if (a == 0)
                return linearEquation(b, c);
            double d = this.discriminant(a, b, c);


            if (d == 0)
            //Корень один
            {

                myAL.Add((-b + Math.Sqrt(d)) / 2 * a);


            }
            else if (d > 0)
            // два корня
            {
                myAL.Add((-b + Math.Sqrt(d)) / 2 * a);
                myAL.Add((-b - Math.Sqrt(d)) / 2 * a);

            }
            else throw new Exception("D<0 no roots");

            return myAL;


        }

        class Program
        {
            static void Main(string[] args)
            {




                try
                {
                    ClassB b = new ClassB();
                    List<double> result = b.solve(0, 0, 0);
                    string s = "Roots: ";
                    foreach (double el in result)
                    {
                        s += el + " ";
                    }

                    Console.WriteLine(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}

