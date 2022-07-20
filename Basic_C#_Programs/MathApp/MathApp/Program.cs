using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite number?"); //Asks the user to input a number//
            string favoriteNumber = Console.ReadLine(); //Reads the number the user inputs//
            int favNum = Convert.ToInt32(favoriteNumber); //Converts the number to an int//
            Console.WriteLine("Your favorite number multiplied by 50 is " + favNum * 50); //Multiplies the number by 50//

            Console.WriteLine("What's your second favorite number?"); //Asks the user to input a number//
            string secondFavoriteNumber = Console.ReadLine(); //Reads the number the user inputs//
            int secFavNum = Convert.ToInt32(secondFavoriteNumber); //Converts the number to an int//
            Console.WriteLine("Your second favorite number plus 25 is " + (secFavNum + 25)); //Adds 25 to the number//

            Console.WriteLine("What's your third favorite number?"); //Asks the user to input a number//
            string thirdFavoriteNumber = Console.ReadLine(); //Reads the number the user inputs//
            int thrFavNum = Convert.ToInt32(thirdFavoriteNumber); //Converts the number to an int//
            Console.WriteLine("Your third favorite number divided by 12.5 is " + (thrFavNum / 12.5)); //Divides the number by 12.5//

            Console.WriteLine("What's your fourth favorite number?"); //Asks the user to input a number//
            string fourthFavoriteNumber = Console.ReadLine(); //Reads the number the user inputs//
            int fouFavNum = Convert.ToInt32(fourthFavoriteNumber); //Converts the number to an int//
            Console.WriteLine("It is " + (fouFavNum > 50) + " that your fourth favorite number is greater than 50."); //Returns 'true' if number is greater than 50, 'false' otherwise//

            Console.WriteLine("What's your fifth favorite number?"); //Asks the user to input a number//
            string fifthFavoriteNumber = Console.ReadLine(); //Reads the number the user inputs//
            int fifFavNum = Convert.ToInt32(fifthFavoriteNumber); //Converts the number to an int//
            Console.WriteLine("When your fifth favorite number is divided by 7, the remainder is " + (fifFavNum % 7)); //Gives the remainder after the number is divided by 7//


            Console.ReadLine();
        }
    }
}
