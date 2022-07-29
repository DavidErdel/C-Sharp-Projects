using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 one = new Class1();

            Console.WriteLine("What number do you want to do math operations on?"); //Asks the user which number they want to do math operations on//
            int userAnswer = Convert.ToInt32(Console.ReadLine()); //Converts the user answer from a string to an integer//

            int result = one.add(userAnswer); //Calls the add method and applies it to userAnswer//
            Console.WriteLine(result); //Writes the result of calling the add method and applying it to userAnswer//

            result = one.sub(userAnswer); //Calls the sub method and applies it to userAnswer//
            Console.WriteLine(result); //Writes the result of calling the sub method and applying it to userAnswer//

            result = one.mult(userAnswer); //Calls the mult method and applies it to userAnswer//
            Console.WriteLine(result); //Writes the result of calling the mult method and applying it to userAnswer//


            Console.ReadLine();
        }
    }
}
