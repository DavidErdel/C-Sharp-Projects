using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() //Creates a list of 10 employees, two of which are named Joe//
            {
             new Employee {id = 1, FirstName = "Max", LastName = "Jones"},
             new Employee {id = 2, FirstName = "Bill", LastName = "Smith"},
             new Employee {id = 3, FirstName = "Joe", LastName = "Peters"},
             new Employee {id = 4, FirstName = "Jim", LastName = "Wells"},
             new Employee {id = 5, FirstName = "George", LastName = "Marks"},
             new Employee {id = 6, FirstName = "Fred", LastName = "Elliot"},
             new Employee {id = 7, FirstName = "Paul", LastName = "Brown"},
             new Employee {id = 8, FirstName = "Frank", LastName = "Miller"},
             new Employee {id = 9, FirstName = "Joe", LastName = "Davis"},
             new Employee {id = 10, FirstName = "Drew", LastName = "Johnson"},
            };

            List<Employee> employees2 = new List<Employee>() { }; //Creates a second list of employees//

            foreach (Employee e in employees) //Creates a foreach loop that goes through the employees in employees//
            {
                if (e.FirstName == "Joe")//Creates an if loop that does something if an employee's first name is Joe//
                {
                    employees2.Add(e); //Adds the employee to the second list of employees//
                }
            }

            employees.FindAll(x => x.FirstName == "Joe"); //A lambda expression that finds all employees with the first name Joe//

            employees.FindAll(x => x.id > 5); //A lambda expression that finds all employees with an id number greater than 5//
        }
    }
}
