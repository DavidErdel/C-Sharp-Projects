using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Class1 //Creates a public class called "Class1"//
    {
        public int add(int input ) //Declares the first method, called "add"//
        {
            int result = input + 1; //Defines an integer called "result" as the input plus 1//
            return result; //Returns result//
        }
        public int sub(int input) //Declares the first method, called "sub"//
        {
            int result = input - 1; //Defines an integer called "result" as the input minus 1//
            return result; //Returns result//
        }
        public int mult(int input) //Declares the first method, called "mult"//
        {
            int result = input * 2; //Defines an integer called "result" as the input times 2//
            return result; //Returns result//
        }
    }
}
