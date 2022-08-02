using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id; //Creates a property called id of the data type int//
        public string FirstName; //Creates a property called FirstName of the data type string//
        public string LastName; //Creates a property called LastName of the data type string//

        public static bool operator== (Employee one, Employee two) //Overloads the == operator//
        {
            return one.Id == two.Id; //Returns true if one.Id == two.Id and false otherwise//
        }

        public static bool operator!= (Employee one, Employee two) //Overloads the != operator//
        {
            return one.Id != two.Id; //Returns false is one.Id == two.Id and false otherwise//
        }

    }
}
