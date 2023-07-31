using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19
{
    internal class ArithematicOp    {
        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Result\t " + result);
        }
        public void Diff(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Result\t " + result);
        }
        public void Div(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine("Result\t " + result);
        }
        public void Multi(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("Result\t " + result);
        }

       

    }
}
