using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();

            var secret = Convert.ToString(random.Next(99, 103));
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess a number ");
                var guess = (Console.ReadLine());
                if (guess == secret)
                {
                    Console.WriteLine("you won! ");
                    return;
                }

            }

            Console.WriteLine("you lost! ");
        }
    }
}
