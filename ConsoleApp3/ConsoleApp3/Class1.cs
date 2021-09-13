using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    

    class User
    {
        public string name { get; set; }
    }
    class Class1
    {
        public void CreatePattern()
        {
            byte b1 = 45;  //0 - 255
            sbyte b2 = -45;
            User user = new User();
            Object obj = new Object();
            int a1 = b1;
            obj = user;

            Console.WriteLine(typeof(Object));
            Console.WriteLine(typeof(User));
            Console.WriteLine(user is User);
            Console.WriteLine(a1);
            
            Console.ReadLine();
        }
        public int age { get; } = 10;
        float balance = 10.4F;
        dynamic SomeData = "this is string";
        //SomeData = "new string"; error one time initialisation
        


    }
}
