using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math2 one = new Math2(); //Instantiates the Math2 class//

            Console.WriteLine("Please input a number"); //Asks the user to input a number//
            int firstAnswer = Convert.ToInt32(Console.ReadLine()); //Converts the user's input into an integer//

            Console.WriteLine("If you like, you can input a second number as well."); //Tell the user they can input a second number optionally, if they want//
            string secondAnswer = Console.ReadLine(); //Reads the user's second input--without converting it into an integer yet//

            if (secondAnswer == "") //Starts an if loop that will run if the second answer is blank--if the user didn't put anything in//
            {
                int result = one.twoIntegers(firstAnswer); //Calls the twoIntegers method just on firstAnswer//
                Console.WriteLine(result); //Prints the result//

            }
            else //Opens an else loop that will run only if the user input something when they were prompted for an optional second number//
            {
                int result = one.twoIntegers(firstAnswer, Convert.ToInt32(secondAnswer)); //Calls the twoIntegers method on both answers the user gave. Also converts the user's second answer from a string to an integer//
                Console.WriteLine(result); //Prints the result//
            }

            Console.ReadLine();
        }
    }
}
