using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");//Prints welcome statement//

            Console.WriteLine("How much does the package that you would like to ship weigh?"); //Asks for package weight//
            string packageweight = Console.ReadLine(); //Gets answer from previous line//
            int pweight = Convert.ToInt32(packageweight); //Converts string to int//

            if (pweight > 50) //Opens if statement about package weight//
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express. Sorry! Have a good day."); //Prints the 'Your package is too heavy' message if weight is over 50//
            }
            else //Allows the exchange to continue if package weighs less than 50//
            {
                Console.WriteLine("How wide is the package that you would like to ship?"); //Asks for package width//
                string packagewidth = Console.ReadLine(); //Gets answer from previous line//
                int pwidth = Convert.ToInt32(packagewidth); //Converts string to int//

                Console.WriteLine("How high is the package that you would like to ship?"); //Asks for package height//
                string packageheight = Console.ReadLine(); //Gets answer from previous line//
                int pheight = Convert.ToInt32(packageheight); //Converts string to int//

                Console.WriteLine("How long is the package that you would like to ship?"); //Asks for package length//
                string packagelength = Console.ReadLine(); //Gets answer from previous line//
                int plength = Convert.ToInt32(packagelength); //Converts string to int//

                if (pwidth + pheight + plength > 50) //Opens if statement about the sum of the package's width, height, and lengt//
                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express. Sorry! Have a good day."); //Prints the 'Your package is too big' message if sum of the dimensions exceeds 50//
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + (pwidth * pheight * plength)); //Calculates estimated total by multiplying package width times lenth times height and prints it//
                    Console.WriteLine("Thanks!"); //Thanks the user//
                }
            }


            Console.ReadLine();
        }
    }
}
