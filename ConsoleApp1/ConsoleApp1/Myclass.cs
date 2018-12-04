using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Myclass
    {
        public Double Add (double num1, double num2)
        {
            return num1 + num2;
        }

        public Double substraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public Double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public Double division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new Exception("dont use num2 which is 0");
            }

            return num1 / num2;
        }
    }
}
