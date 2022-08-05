using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\David\Documents\log2.txt", true))
            {
                file.WriteLine(userAnswer);
                file.Close();
                string file2 = File.ReadAllText(@"C:\Users\David\Documents\log2.txt");
                Console.WriteLine("The number you entered is " + file2);
            }
            Console.ReadLine();
        }
    }
}
