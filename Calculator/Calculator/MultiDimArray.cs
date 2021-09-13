using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MultiDimArray
    {
        public void MultiDim()
        {

            Console.WriteLine("demo of multidimensional array");
            int[,,] arr1 = new int[1, 2, 2]{
                { { 0, 0}, { 3, 8} }};

            int[,,] arr2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }};

            int[,,] arr3 = new int[2, 2, 3]{
                { { 11, 45, 5}, {4, 15, 6} },
                { { 17, 81, 9}, {10, 11, 12} }};


            Console.WriteLine(arr1[0, 0, 0]);
            Console.WriteLine(arr2[0, 0, 0]);
            Console.WriteLine(arr3[0, 0, 0]);
        }
    }
}
