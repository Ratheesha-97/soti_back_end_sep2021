using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ArrayDemo
    {
        public void QueryArray()
        {
            int[] array1 = { 1, 2, 3, 4, 8 };
            var a = from i in array1 where i % 2 == 0 select i;
            foreach(var _a in a)
            {
                Console.WriteLine("{0}\n", _a);
            }
            Console.Read();
        }
            
    }
}
