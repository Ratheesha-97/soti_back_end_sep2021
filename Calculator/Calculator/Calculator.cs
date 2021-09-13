using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            /*  int x, y;
              Console.WriteLine("Enter the first number");
              x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter the second number");
              y = Convert.ToInt32(Console.ReadLine()); //ReadLine returns string , which is explicity converted 

              CalcSum(x, y);
            
            Class1 class1 = new Class1();
            class1.demoTryParse();

            
            BoxnUnbox b = new BoxnUnbox();
            b.Unboxing();

            
            while(true)
            {
                MathFun mf = new MathFun();
                try
                {
                    Console.WriteLine("Enter the value of y");
                    string input = Console.ReadLine();
                    if (input == "q")
                    {
                        break;
                    }
                    Console.WriteLine("the value of x is :{0}", mf.calculate(Convert.ToInt32(input)));
                }
                catch
                {
                    Console.WriteLine("enter a valid integer");
                }
            }


            

            MultiDimArray md = new MultiDimArray();
            md.MultiDim();
            */

            ArraySearch arrs = new ArraySearch();
            arrs.ArrSearch();




        }
        private static void CalcSum(int a, int b)
        {
            int Sum = a + b;
            Console.WriteLine("the sum is {0}", Sum);
        }
    }
}
