using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMngmt
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexedClass nameList = new IndexedClass();
            nameList[0] = "Ram";
            Console.WriteLine(nameList[0]);
            nameList[1] = "abc";
            Console.WriteLine(nameList[1]);

        }
    }
    
}
