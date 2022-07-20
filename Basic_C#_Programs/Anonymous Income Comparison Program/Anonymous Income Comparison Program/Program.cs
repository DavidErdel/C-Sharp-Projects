using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Prints "Anonymous Income Comparison Program"//
            Console.WriteLine("Person 1:"); //Prints "Person 1: "//
            Console.WriteLine("What is your hourly rate?"); //Asks for Person 1's hourly rate//
            string p1hourlyrate = Console.ReadLine(); //Gets answer from previous line//
            int p1hr = Convert.ToInt32(p1hourlyrate); //Converts answer from string to int//
            Console.WriteLine("How many hours do you work per week?"); //Asks Person 1 how many hours they work per week//
            string p1weeklyhours = Console.ReadLine(); //Gets answer from previous line//
            int p1wh = Convert.ToInt32(p1weeklyhours); //Converts answer from string to int//

            Console.WriteLine("Person 2:"); //Prints "Person 2: "//
            Console.WriteLine("What is your hourly rate?"); //Asks for Person 2's hourly rate//
            string p2hourlyrate = Console.ReadLine(); //Gets answer from previous line//
            int p2hr = Convert.ToInt32(p2hourlyrate); //Converts answer from string to int//
            Console.WriteLine("How many hours do you work per week?"); //Asks Person 2 how many hours they work per week//
            string p2weeklyhours = Console.ReadLine(); //Gets answer from previous line//
            int p2wh = Convert.ToInt32(p2weeklyhours); //Converts answer from string to int//

            Console.WriteLine("Annual salary of Person 1: "); //Prints "Annual salary of Person 1: "//
            Console.WriteLine((p1hr * p1wh) * 52); //Multiplies Person 1's hourly rate by the number of hours they work per week by the number of weeks in a year and prints the result//

            Console.WriteLine("Annual salary of Person 2: "); //Prints "Annual salary of Person 2: "//
            Console.WriteLine((p2hr * p2wh) * 52); //Multiplies Person 2's hourly rate by the number of hours they work per week by the number of weeks in a year and prints the result//

            Console.WriteLine("Does Person 1 make more money than Person 2?"); //Asks whether Person 1 makes more than Person 2//
            Console.WriteLine(((p1hr * p1wh) * 52) > ((p2hr * p2wh) * 52)); //Returns 'True' if Person 1's annual salary is greater than Person 2's and 'False' otherwise//



            Console.ReadLine();
        }
    }
}
