using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quitter = new Employee(); //Creates an object of the type IQuittable called quitter//
            quitter.Quit(); //Calls the Quit method on quitter//

            Console.ReadLine();
        }
    }
}

