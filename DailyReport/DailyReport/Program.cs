using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //Prints "The Tech Academy at the top of the consul//
            Console.WriteLine("Student Daily Report");//Prints "Student Daily Report" under "The Tech Academy"//

            Console.WriteLine("What is your name?");//Asks for your name//
            string yourName = Console.ReadLine();//Records answer as string//
            Console.WriteLine("What course are you on?");//Asks for your course//
            string yourCourse = Console.ReadLine();//Records answer as string//
            Console.WriteLine("What page number?");//Asks for your page number//
            string yourPageNumber = Console.ReadLine();//Records answer as string//
            int PageNumber = Convert.ToInt32(yourPageNumber);//Converts answer to int//
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'."); //Asks whether you need hlp//
            string DoYouNeedHelp = Console.ReadLine();//Records answer as string//
            bool NeedHelp = Convert.ToBoolean(DoYouNeedHelp);//Converts answer to boolean//
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");//Asks for positive experiences//
            string positiveexperiences = Console.ReadLine();//Records answer as string//
            Console.WriteLine("Is there any other feedback you’d like to provide ? Please be specific.");//Asks for extra feedback//
            string otherfeedback = Console.ReadLine();//Records answer as string//
            Console.WriteLine("How many hours did you study today?");//Asks how many hours you studied//
            string studyhours = Console.ReadLine();//Records answer as string//
            int stdyhrs = Convert.ToInt32(studyhours);//Converts answer to int//
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");//Prints thank you message//
            Console.ReadLine(); 

        }
    }
}
