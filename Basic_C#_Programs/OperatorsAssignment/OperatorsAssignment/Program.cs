using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee(); //Creates a new object from the Employee class called one//
            Employee two = new Employee(); //Creates a new object from the Employee class called two//

            one.Id = 1; //Assigns the value of one's Id to 1//
            two.Id = 2; //Assigns the value of two's Id to 2//

            Console.WriteLine(one == two); //Prints the value of one == two to the console, which in this case will be false//
        }
    }
}
