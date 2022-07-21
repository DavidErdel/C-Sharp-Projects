using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your age?"); //Asks age//
            string yourAge = Console.ReadLine(); //Gets answer from previous line//
            int yrage = Convert.ToInt32(yourAge);//Converts answer from string to int//

            Console.WriteLine("Please affirm or deny the following statement by writing True or False: I have had a DIU"); //Asks whether applicant has had a DIU//
            string drivingUnderInfluence = Console.ReadLine(); //Gets answer from previous line//
            bool dui = Convert.ToBoolean(drivingUnderInfluence);//Converts answer from string to boolean//
            
            Console.WriteLine("How many speeding tickets have you had?"); //Asks how many speeding tickets the applicant has had//
            string numberOfTickets = Console.ReadLine(); //Gets answer from previous line//
            int numticks = Convert.ToInt32(numberOfTickets);//Converts answer from string to int//

            Console.WriteLine("Qualified?"); //Asks whether the applicant is qualified//
            Console.WriteLine((yrage > 15) && (dui == false) && (numticks <= 3)); //Returns True if applicant is older than fifteen and has not had a DIU and has had 3 or fewer speeding tickets. Returns False otherwise//




            Console.ReadLine();
        }
    }
}
