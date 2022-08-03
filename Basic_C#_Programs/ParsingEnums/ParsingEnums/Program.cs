using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week."); //Asks the user to input a day of the week//
            string userAnswer = Console.ReadLine(); //Reads the user's answer and assigns it to a string called userAnswer//


            DaysOfTheWeek day = new DaysOfTheWeek(); //Creates a new object name day of the enum DaysOfTheWeek//

            try //Starts the try portion of a try catch//
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userAnswer); //Assigns the value of day to the value of the DaysOfTheWeek enum that matches userAnswer//

                Console.WriteLine(day); //Writes day to the console//
            }
            catch //Starts the catch portion//
            {
                Console.WriteLine("Please enter an actual day of the week"); //Asks the user to enter an actual day of the week if they failed to do so//
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek //Creates an enum called DaysOfTheWeek and assigns the names of the days of the week to it//
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
