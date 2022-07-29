using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    public class Math //Creates a public class called Math//
    {

        public int add(int input) //Declares a method called add//
        {
            int result = input + 1; //Defines an integer called result as input +1//
            return result; //Returns result//
        }
        public int add(decimal input) //Creates a method to handle decimal inputs//
        {
            decimal result = input - 1;
            int result2 = Convert.ToInt32(result);
            return result2;
        }
        public int add(string input) //Creates a method to handle string inputs//
        {
            int result = Convert.ToInt32(input) * 2;
            return result; //Returns result//
        }
    }
}
