using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public class Person //Creates a class call Person//
    {
        public string FirstName; //Gives the Person class a property of data type string called FirstName//

        public string LastName; //Gives the Person class a property of data type string called LastName//

        public void SayName() //Creates a void method called SayName with no parameters//
        {
            Console.WriteLine("Name: " + FirstName + LastName); //Prints the person's full name to the console//
        }

    }
}
