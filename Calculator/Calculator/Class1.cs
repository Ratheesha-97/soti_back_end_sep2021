using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Class1
    {
        public void demoTryParse()
        {


            string val = null;
            int result;
            bool ifSuccess = int.TryParse(val, out result); // definition of TryParse
            Console.WriteLine(ifSuccess);

            string val1 = "101.11";
            int result2;
            bool ifSuccess2 = int.TryParse(val1, out result2);
            Console.WriteLine(ifSuccess2);


        }
    }
}
