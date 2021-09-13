using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Calculator
{
    class ArraySearch
    {
        public void ArrSearch()
        {
            string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            var stringToFind = "Bill";

            var result1 = Array.FindLast(names, element => element.Contains(stringToFind)); // only last match
            Console.WriteLine(result1);

            var result2 = Array.FindLast(names, element => element.StartsWith("B")); // only last match
            Console.WriteLine(result2);


            var result3 = Array.FindLast(names, element => element.Length >= 5);
            Console.WriteLine(result3);


            
            var totalElements = names.Count(); //6

            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            int totalNums = nums.Count(); //12
            Console.WriteLine($"count of elements in names array {totalElements}");
            Console.WriteLine($"count of elements in nums array {totalNums}");


            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            var totalCats = animals.Count(s => s == "Cat");

            
            var totalEvenNums = nums.Count(n => n % 2 == 0);
            Console.WriteLine($"no of even numbers in the array {totalEvenNums}");

            var animalsWithCapitalLetter = animals.Count(s =>
            {
                return Regex.IsMatch(s, "^[A-Z]");
            });
            Console.WriteLine(animalsWithCapitalLetter);


            
            string[] birds = { "Sparrow", "Peacock", "Dove", "Crow" };

            var Animal_Birds = animals.Union(birds).ToArray();

            int[] num1 = { 11, 200, 34, 4, 3, 55, 23, 2 };
           

            var all = num1.Union(nums).ToArray();
            Console.WriteLine(all);


            Person[] people1 = {
        new Person(){ FirstName="Steve", LastName="Jobs"},
        new Person(){ FirstName="Bill", LastName="Gates"},
        new Person(){ FirstName="Steve", LastName="Jobs"},
        new Person(){ FirstName="Lary", LastName="Page"}
    };

            Person[] people2 = {
        new Person(){ FirstName="Steve", LastName="Jobs"},
        new Person(){ FirstName="Lary", LastName="Page"},
        new Person(){ FirstName="Bill", LastName="Gates"}
    };

            var allp = people1.Union(people2).ToArray();
            Array.ForEach(allp, p => Console.WriteLine(p.FirstName));


            var str1 = String.Join(",", animals);
            var str2 = String.Join(",", nums);
            var str3 = String.Join(",", people1.Select(p => p.FirstName));

            Console.WriteLine(str1);
            Console.WriteLine(str2);


            int[] num_arra = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] dist1 = num_arra.Distinct().ToArray();
            string[] dist2 = animals.Distinct().ToArray();


            Console.WriteLine(dist1);
            Console.WriteLine(dist2);

    

            var dist = people1.Distinct().ToArray();
            Console.WriteLine(dist);

            Array.Sort(animals);
            Console.WriteLine(animals);
            Array.Sort(animals, 0, 3);
            Console.WriteLine(animals);

            Array.Reverse(animals);
            string[] animals1 = { "Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat" };

            var sortedStr = from name in animals1
                            orderby name
                            select name;

            Array.ForEach<string>(sortedStr.ToArray<string>(), s => Console.WriteLine(s));

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(animals1[i]);
            }


            Array.Sort(people1, new PersonComparer());

            var qry = from p in people1
                      orderby p.LastName
                      select p;

            Array.ForEach<Person>(qry.ToArray<Person>(), p => Console.WriteLine(p.FirstName + " " + p.LastName));

           

        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
    }
    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Person)x).LastName, ((Person)y).LastName);
        }
    }
}
