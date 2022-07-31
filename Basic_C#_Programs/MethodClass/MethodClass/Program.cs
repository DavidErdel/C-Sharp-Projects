using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args) 
        {
            Math3 one = new Math3(); //Instantiates the Math3 class//

            Console.WriteLine("Please input a number"); //Asks the user to input a number//
            int firstAnswer = Convert.ToInt32(Console.ReadLine()); //Converts the user's answer to integer//

            Console.WriteLine("Please input a second number"); //Asks the user to input a number//
            int secondAnswer = Convert.ToInt32(Console.ReadLine()); //Converts the user's answer to integer//

            one.twoMoreIntegers(firstAnswer, secondAnswer); //Calls the twoIntegers method and passes in the two numbers the user just input//

            Console.ReadLine();
        }
        
    }
}
