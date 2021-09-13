using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            takeInputfromConsole();
            takeStringfromConsole();
            implicit_type_conv();
            var name = "Welcome";
            var a = 34;
            Console.WriteLine("name={0}, a={1}", name, a);
            Class1 c = new Class1();
            c.CreatePattern();
            ArrayDemo ad = new ArrayDemo();
            ad.QueryArray();



        }
        private static void implicit_type_conv()
        {
            int x = 2;
            float y = 3.9F, z;
            z = x + y;
            Console.WriteLine(z);
        }
        private static void takeInputfromConsole()
        {
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);
            //Console.Read();
        }
        private static void takeStringfromConsole()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}
