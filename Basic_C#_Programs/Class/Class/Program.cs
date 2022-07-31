using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            divideByTwo one = new divideByTwo(); //Instantiates the class divideByTwo//

            Console.WriteLine("Please input a number"); //Asks the user to input a number//
            int userAnswer = Convert.ToInt32(Console.ReadLine()); //Converts the user input to an integer//

            one.divBy2(userAnswer); //Calls the divby2 method on userAnswer//

            Console.ReadLine();
        }
    }
}
