using System;

namespace TryCatchAssignment
{
    class Program
    {
        public class InputException: Exception
        {
            public InputException()
                : base() { }

            public InputException(string message)
                : base (message) { }

        }
        static void Main(string[] args)
        {
            int age;

            try
            {
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());

                if (age < 1)
                {
                    throw new InputException();
                }

                var today = DateTime.Now;

                var year1 = today.Year - age;

                Console.WriteLine("You were born in " + year1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter just an integer.");
            }
            catch (InputException)
            {
                Console.WriteLine("You entered either 0 or a negative number. Please enter a positive number greater than 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please contact support.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
