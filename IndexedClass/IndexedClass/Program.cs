using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexedClassDemo
{    
    // for indexed class demo
    interface IUser
    {
        int a { get; set; }
        void work();
    }

    class User : IUser
    {
        public int a { get => a;
            set => a = value;
        }

        void IUser.work()
        {
            throw new NotImplementedException();
        }
    }
    


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
