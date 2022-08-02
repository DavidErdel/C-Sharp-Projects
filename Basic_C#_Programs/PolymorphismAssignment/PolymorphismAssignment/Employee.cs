using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
    public class Employee : IQuittable //Creates a class called Employee that inherits from interface IQuittable//
    {
        public void Quit() //Implements the Quit quite method//
        { 
            Console.WriteLine("Employee Quit"); //Prints Employee Quit to the console//
        } 

    }
}
