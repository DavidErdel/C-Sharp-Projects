using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiates the Employee object with a first name of Sample and a last name of Student//

            employee.SayName(); //Calls the SayName method on employee//
        }
    }
}
