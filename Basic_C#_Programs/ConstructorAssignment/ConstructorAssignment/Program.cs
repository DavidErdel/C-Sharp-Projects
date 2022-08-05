using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
          
            const string name = "David"; //Creates a const variable//

            var age = 37; //Creates a variable using the keyword "var"//

        }
        public class Person //Creates a public class called Person//
        {
            public string fname; //Creates a public string called fname//
            public string lname; //Creates a public string called lname//
            
            public Person(string fname) : this (fname, "Smith") //Creates a contructor that is chained to the second constructor//
            {

            }
            public Person(string fname, string lname) //Creates a second constructor//
            {
                this.fname = fname;
                this.lname = lname;
            }
        }
    }
}
