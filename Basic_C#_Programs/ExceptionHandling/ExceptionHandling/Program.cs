using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int>() { 2, 4, 8, 16, 24 };
            Console.WriteLine("Please input a whole number");
            int userAnswer = Convert.ToInt32(Console.ReadLine());


            foreach (int n in numbers)
            {
                Console.WriteLine(n / userAnswer);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution");
        Console.ReadLine();
    }
}

