using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiates the Employee object with a first name of Sample and a last name of Student//

            employee.SayName(); //Calls the superclass method SayName on the Employee object//

        }
    }
}
