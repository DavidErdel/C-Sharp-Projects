using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Prints current date and time to the console//

            Console.WriteLine("Please input a number"); //Asks user for a number//
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(userAnswer)); //Prints to the console the time it will be in the number of hours that is equal to the number the user input//



            Console.ReadLine();
        }  
    }
}
