using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> one = new Employee<string>();
            Employee<int> two = new Employee<int>();

            one.things = new List<string>() { "George", "Fred", "Bill" };

            two.things = new List<int>() { 234, 3454, 454 };

            foreach(string s in one.things)
            {
                Console.WriteLine(s);
            }

            foreach (int i in two.things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
