using System;
using System.Collections.Generic;
using System.Text;

namespace laba3_4.kuznecov
{

    class QuadraticEquation : LinearEquation, Core.EquationInterface
    {

        protected double discriminant(double a, double b, double c)
        {

            return b * b - 4 * a * c;

        }

        public List<double> solve(double a, double b, double c)
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

            else throw new KuzecovExeption("NO ROOTS");

            MyLog.log("accepted, the equation");
            return myAL;


        }
    }
}

