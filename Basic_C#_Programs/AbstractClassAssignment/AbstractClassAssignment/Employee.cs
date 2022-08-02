using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public class Employee : Person //Creates a class called Employee that inherits from Person//
    {
        public void SayName() { Console.WriteLine("Name: " + FirstName + LastName); } //Implements the SayName method inside of the Employee class//

    }
}
