using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            string p1hourlyrate = Console.ReadLine();
            int p1hr = Convert.ToInt32(p1hourlyrate);
            Console.WriteLine("How many hours do you work per week?");
            string p1weeklyhours = Console.ReadLine();
            int p1wh = Convert.ToInt32(p1weeklyhours);

            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            string p2hourlyrate = Console.ReadLine();
            int p2hr = Convert.ToInt32(p2hourlyrate);
            Console.WriteLine("How many hours do you work per week?");
            string p2weeklyhours = Console.ReadLine();
            int p2wh = Convert.ToInt32(p2weeklyhours);

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine((p1hr * p1wh) * 52);

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine((p2hr * p2wh) * 52);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(((p1hr * p1wh) * 52) > ((p2hr * p2wh) * 52));



            Console.ReadLine();
        }
    }
}
