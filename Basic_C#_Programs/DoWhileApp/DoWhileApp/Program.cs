using System;

namespace DoWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's 2 + 2?");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer = answer == 4;

            while (!correctAnswer)
            {
                switch (answer)
                {
                    case 3:
                        Console.WriteLine("Your answer is incorrect. Try again!");
                        Console.WriteLine("What's 2 + 2?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Your answer is correct!");
                        correctAnswer = true;
                        break;
                    default:
                        Console.WriteLine("Your answer is incorrect. Try again!");
                        Console.WriteLine("What's 2 + 2?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("What's 2 + 3?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer2 = answer == 5;

            do
            {
                switch (answer2)
                {
                    case 3:
                        Console.WriteLine("Your answer is incorrect. Try again!");
                        Console.WriteLine("What's 2 + 3?");
                        answer2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Your answer is correct!");
                        correctAnswer2 = true;
                        break;
                    default:
                        Console.WriteLine("Your answer is incorrect. Try again!");
                        Console.WriteLine("What's 2 + 3?");
                        answer2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!correctAnswer2);

            Console.ReadLine();
        }
    }
}
