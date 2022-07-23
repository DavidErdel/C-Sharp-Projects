using System;
using System.Collections.Generic;

namespace ArraysAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringArray = { "Ada", "Marie", "George", "Martin" }; //Creates an array of strings//

            Console.WriteLine("Pick a one of these numbers: 0, 1, 2, 3"); //Asks the user to pick one of the numbers corresponding to index numbers of the array//
            string stringChoice = Console.ReadLine(); //Reads what the user input//

            if (stringChoice == "0") 
            {
                Console.WriteLine(stringArray[0]); //Prints the element of the array at index 0 if the user picks 0//
            }
            else if (stringChoice == "1")
            {
                Console.WriteLine(stringArray[1]); //Prints the element of the array at index 1 if the user picks 1//
            }
            else if (stringChoice == "2")
            {
                Console.WriteLine(stringArray[2]); //Prints the element of the array at index 2 if the user picks 2//
            }
            else if (stringChoice == "3")
            {
                Console.WriteLine(stringArray[3]); //Prints the element of the array at index 3 if the user picks 3//
            }
            else
            {
                Console.WriteLine("You did not pick one of the choices."); //Prints a message telling the user that they did not pick one of the choices if the user did not pick one of the choices//
            }



            int[] integerArray = { 1000, 2000, 3000, 4000 }; //Creates an array of integers//

            Console.WriteLine("Pick a one of these numbers: 0, 1, 2, 3"); //Asks the user to pick one of the numbers corresponding to index numbers of the array//
            string integerChoice = Console.ReadLine(); //Reads what the user input//
            int intChoice = Convert.ToInt32(integerChoice); //Converts the users input into an integer//

            if (intChoice == 0)
            {
                Console.WriteLine(integerArray[0]); //Prints the element of the array at index 0 if the user picks 0//
            }
            else if (intChoice == 1)
            {
                Console.WriteLine(integerArray[1]); //Prints the element of the array at index 1 if the user picks 1//
            }
            else if (intChoice == 2)
            {
                Console.WriteLine(integerArray[2]); //Prints the element of the array at index 2 if the user picks 2//
            }
            else if (intChoice == 3)
            {
                Console.WriteLine(integerArray[3]); //Prints the element of the array at index 3 if the user picks 3//
            }
            else
            {
                Console.WriteLine("You did not pick one of the choices."); //Prints a message telling the user that they did not pick one of the choices if the user did not pick one of the choices//
            }


            List<string> stringList = new List<string>(); //Creates a list of strings//
            stringList.Add("David"); //Adds a string to the 0 position in the list index//
            stringList.Add("Joshua"); //Adds a string to the 1 position in the list index//
            stringList.Add("Ana"); //Adds a string to the 2 position in the list index//
            stringList.Add("Sierra"); //Adds a string to the 3 position in the list index//

            Console.WriteLine("Pick a one of these numbers: 0, 1, 2, 3"); //Asks the user to pick one of the numbers corresponding to index numbers of the list//
            string listChoice = Console.ReadLine(); //Reads the users input//
                int lstChoice = Convert.ToInt32(listChoice); //Converts the users input into an integer//

            if (lstChoice == 0)
                {
                    Console.WriteLine(stringList[0]); //Prints the element of the array at index 0 if the user picks 0//
            }
                else if (lstChoice == 1)
                {
                    Console.WriteLine(stringList[1]); //Prints the element of the array at index 1 if the user picks 1//
            }
                else if (lstChoice == 2)
                {
                    Console.WriteLine(stringList[2]); //Prints the element of the array at index 2 if the user picks 2//
            }
                else if (lstChoice == 3)
                {
                    Console.WriteLine(stringList[3]); //Prints the element of the array at index 3 if the user picks 3//
            }
                else
                {
                    Console.WriteLine("You did not pick one of the choices."); //Prints a message telling the user that they did not pick one of the choices if the user did not pick one of the choices//
            }

            Console.ReadLine();

        }


    }
}
