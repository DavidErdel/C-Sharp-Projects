using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class divideByTwo //Creates a class called divideByTwo//
    {
        public void divBy2(int input) //Creates a void method called divide by two that takes an integer as an input//
        {
            int result = input / 2; //Creates an integer called results that divides input by 2//
            Console.WriteLine(result); //Prints result//
        }

        public void outPar(out int x ) //Creates a void method called outPar that has an output parameter//
        {
            int int1 = 5; //Creates an integer called int1 that has a value of 5//
            x = int1 * 2; //Gives x the value of int1 times 2//
        }

        public void overload(int int2 = 6) //Creates a method called overload that takes an integer as a parameter named int2 and gives it a value of 6// 
        {
            int int3 = int2 * 3; //Creates an integer called int3 that has a value of int2 times 3//
        }

        public void overload(string string1 = "Hi") //Creates another method called overload (which overloads the first overload) and that has a string called string1 which reads Hi!//
        {
            Console.WriteLine(string1); //Writes string1//
        }

    }
}
