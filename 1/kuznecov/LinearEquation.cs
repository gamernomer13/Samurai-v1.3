using System;
using System.Collections.Generic;
using System.Text;

namespace laba3_4.kuznecov
{
    class LinearEquation
    {

        protected List<double> myAL = new List<double>();


        public List<double> MyAL
        {
            get { return myAL; }
            set { myAL = value; }
        }
        public List<double> linearEquation(double a, double b)
        {
            if (a == 0)
            {
                throw new KuzecovExeption("equation no exist!");
            }
            myAL.Add((double)-b / a);

            MyLog.log("definitely, linear equation");
            return myAL;
        }
    }
}
