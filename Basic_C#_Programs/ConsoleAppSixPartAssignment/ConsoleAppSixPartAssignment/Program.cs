using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //THIS IS PART ONE (step 251//

        string[] beatles = { "John", "Paul", "George", "Ringo" }; //Creates a string array with the names of the The Beatles//
        Console.WriteLine("Please write a bit of text."); //Asks the user to input some text//
        string textBit = Console.ReadLine(); //Reads the text the user input//

        for (int b = 0; b < beatles.Length; b++) //Sets integer b at 0, then tells the loop to keep going so long as b is less than the number of items in the beatles array, then adds one to b//
        {
            beatles[b] = beatles[b] + textBit; //Adds the text the user input to each item in the array//
        }
        for (int b = 0; b < beatles.Length; b++) //Creates a loop that will do something to each string in the beatles array (same as line 13)//
        {
            Console.WriteLine(beatles[b]); //Prints each string in the array//
        }


        //THIS IS PART TWO(step 252)//

        int count = 2; //Creates an integer called "count" and gives it a value of 2//

        while (true) //Starts a while loop that will keep running as long as the value is true//
        {

            if (count > 1) //Tells the loop to do something as long as the value of count is greater than 1 (which it is)//
            {
                Console.WriteLine(count); //Tells the console to write the value of count//
                count++; //Adds 1 to count. This loop will go on forever if just left like this because the value of count will always be greater than 1//
            }

            if (count > 100) //Tells the loop to do something if tha value of count is greater than 100//
            {
                break; //Tells the loop to break. This will stop the loop, which would have gone on infinitely, from proceeding after counting to 100//
            }
        }

        //THIS IS PART THREE (step 253)//

        int num3 = 3; //Creates an integer called "num3" and assigns it a value of 3//

        while (num3 < 10) //Creates a while loop that will continue as long as the value of num3 is less than 10//
        {
            Console.WriteLine(num3); //Prints the value of num3//
            num3++;  //Adds 1 to the value of num3//
        }

        Console.WriteLine(""); //Prints a space between the output of the first loop and the output of the second//

        int num4 = 4; //Creates an integer called "num4" and assigns it a value of 4//

        while (num4 <= 10) //Creates a while loop that will continue as long as the value of num4 is less than or equal to 10//
        {
            Console.WriteLine(num4); //Prints the value of num4//
            num4++;  //Adds 1 to the value of num4//
        }


        //THIS IS PART FOUR//

        List<string> presidents = new List<string>() { "George", "Barack", "Donald", "Joe" }; //Creates a list containing the first names of the four most recent American presidents//
        Console.WriteLine("Please write the first name of one of the four most recent American presidents."); //Asks the user to write the first name of one of the four most recent American presidents//
        string userAnswer = Console.ReadLine(); //Creates a string called "userAnswer" that contains the text they input//


        for (int p = 0; p < presidents.Count; p++) //Creates a for loop that will iterate through the items in the list//
        {
            if (!presidents.Contains(userAnswer))
            {
                Console.WriteLine("You did not write the first name of any of the four most recent American presidents.");
                break;
            }
            else if (presidents[p] == userAnswer) //Creates an loop that tells the app to do something if  checkingItems equals userAnswer//
            {
                Console.WriteLine("The name of the president you wrote is at index " + p + " in this list."); //Tells the console to write whatever item from the list is at the index value of p (so long as that item equals the user answer)//
                break;
            }
        }

        //THIS IS PART FIVE//

        List<string> names = new List<string>() { "Adam", "Ben", "Adam", "Carl" }; //Creates a list of names two of which are identical//
        Console.WriteLine("Please input some text."); //Asks the user to write the first name of one of the four most recent American presidents//
        string userAnswer2 = Console.ReadLine(); //Creates a string called "userAnswer" that contains the text they input//

        for (int n = 0; n < names.Count; n++) //Creates a for loop that will iterate through the items in the list//
        {
            if (!names.Contains(userAnswer2))
            {
                Console.WriteLine("The text you input does not match any items in the list.");
                break;
            }
            else if (names[n] == userAnswer2) //Creates an loop that tells the app to do something if  checkingItems equals userAnswer//
            {
                Console.WriteLine("The text you input matches the name at index " + n + " in this list."); //Tells the console to write whatever item from the list is at the index value of p (so long as that item equals the user answer)//
            }
        }

        //THIS IS PART SIX//

        List<string> letters = new List<string>() { "A", "B", "A", "C" }; //Creates a list of names two of which are identical//
        List<string> letters2 = new List<string>(); //Creates a blank list//


        foreach (string l in letters) //Starts a foreach loop that will run through the first list and check whether something is true of each string in it//
        {  
            if (letters2.Contains(l)) //Tells the console to do something if the second list contains the string being checked//
            {
                Console.WriteLine(l + " is a duplicate."); //If the string being checked is in the second list, the console writes that it's a duplicate//
            }
            else //Starts an else loop to tell the console to do something else if the string being checked is not in the second list//
            { 
                Console.WriteLine(l + " is unique."); ////If the string being checked is not in the second list, the console writes that it's unique//
                letters2.Add(l); //If the string being checked isn't in the second list this line tells the consul to add it to that list//
            }
        }

        Console.ReadLine();
    }   
}

