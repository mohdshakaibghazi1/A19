using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19
{
    public delegate void ArithmeticOperation(double num1, double num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithematicOp Ao = new ArithematicOp();
            ArithmeticOperation arith = new ArithmeticOperation(Ao.Add);
            ArithmeticOperation arith2 = new ArithmeticOperation(Ao.Div);
            ArithmeticOperation arith3 = new ArithmeticOperation(Ao.Multi);
            ArithmeticOperation arith4 = new ArithmeticOperation(Ao.Diff);


            Console.WriteLine("Enter item 1");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter item 2");
            double b= double.Parse(Console.ReadLine());
            Console.WriteLine("Press 1 for Adding Values\nPress 2 for Divide Values\nPress 3 for Multiply Values\nPress 4 for Diference Values\n");
            double exp = double.Parse(Console.ReadLine());
            switch (exp)
            {

                case 1:
                       Console.WriteLine("After Adding");
                       arith(a, b);
                        break;
                case 2:
                 
                       Console.WriteLine("After Divide");
                        arith2(a, b);
                       break;
                case 3:
                      Console.WriteLine("After Multi");
                       arith3(a, b);
                      break;


                case 4:
                      Console.WriteLine("After Difference");
                       arith4(a, b);
                    break;
                default: Console.WriteLine("incorrect key\t Try again");
                    break;


        }
            




        }
    }
}
