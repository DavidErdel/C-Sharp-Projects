using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(); //Creates an object of the data type Number called num//
            num.Amount = 2; //Assigns the amount of num to 2//

            Console.WriteLine(num.Amount); //Prints the amount of num
            Console.ReadLine();
        }
        public struct Number //Creates a struct called Number//
        {
            public decimal Amount; //Gives Number the decimal property Amount//
        }
    }
}
