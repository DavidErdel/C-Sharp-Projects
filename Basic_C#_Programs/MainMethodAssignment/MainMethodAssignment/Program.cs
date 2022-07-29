using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math one = new Math();

            Console.WriteLine("What number do you want to do math operations on?"); //Asks the user which number they want to do math operations on//
            int userAnswer = Convert.ToInt32(Console.ReadLine()); //Converts user answer from a string to an integer//

            int result = one.add(userAnswer); //Calls the add method and applies it to userAnswer//
            Console.WriteLine(result); //Writes the result of calling the add method and applying it to userAnswer//

            result = one.add(userAnswer);
            Console.WriteLine(result);

            Console.WriteLine("What string do you want to do math operations on?"); //Asks the user which string they want to do math operations on//
            string result7 = Console.ReadLine(); //Creates a new string and assigns the user answer to it//
            Console.WriteLine(one.add(result7)); //Writes the result of calling the add method on the new string//

            Console.WriteLine("What decimal do you want to do math operations on?"); //Asks the user which decimal they want to do math operations on//
            decimal result8 = Convert.ToDecimal(Console.ReadLine()); //Creates a new decimal and assigns the user answer to it//
            Console.WriteLine(one.add(result8)); //Writes the result of calling the add method on the new string//

            Console.ReadLine();
        }
    }
}
